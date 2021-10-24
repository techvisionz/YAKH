using Confluent.Kafka;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace YAKH.classes
{
    public class KafkaManager
    {
        public delegate void MessageReceived(ConsumeResult<Ignore, string> consumeResult);
        public MessageReceived onMessageReceived;
        bool _isStopped = false;
        bool _userFilter = false;
        string _filterValue = "";
        JObject _filterObject;

        string _host;
        int _port;
        bool _storeOffset;
        AutoOffsetReset _autoOffsetReset;
        DataStream _dataStream;

        public string ErrorMessage { get; set; }
        public KafkaManager(string host, int port, AutoOffsetReset autoOffsetReset, bool storeOffset)
        {
            this._host = host;
            this._port = port;
            this._autoOffsetReset = autoOffsetReset;
            this._storeOffset = storeOffset;

            this._dataStream = new DataStream();
        }

        /**
         * Check if topic exists on Kafka Server
         */
        public bool topicExists(string topic)
        {
            var adminConfig = new AdminClientConfig()
            {
                BootstrapServers = this._host + ":" + this._port.ToString()
            };

            using (var adminClient = new AdminClientBuilder(adminConfig).Build())
            {
                Metadata metadata = null;
                try
                {
                    metadata = adminClient.GetMetadata(TimeSpan.FromSeconds(5));
                }
                catch (Exception ex)
                {
                    this.ErrorMessage = ex.Message;
                    return false;
                }
                var topicsMetadata = metadata.Topics;
                var topicFound = metadata.Topics.Select(a => a.Topic.ToString().Equals(topic)).FirstOrDefault();

                if (topicFound)
                {
                    return true;
                }
            }

            return false;
        }

        public void startListening(string topic, string groupId, string filterValue, int timeout = 5000)
        {
            bool isJson = false;
            this._isStopped = false;
            this._userFilter = string.IsNullOrEmpty(filterValue);
            this._filterValue = filterValue;
            this._dataStream.resetCounter();

            if (_userFilter && string.IsNullOrEmpty(this._filterValue))
            {
                try
                {
                    this._filterObject = JObject.Parse(this._filterValue);
                    isJson = true;
                }
                catch (Exception e)
                {
                    this._filterObject = null;
                    this.ErrorMessage = e.Message;
                }
            }

            ConsumerConfig config = new ConsumerConfig
            {
                BootstrapServers = this._host + ":" + this._port.ToString(),
                AutoOffsetReset = this._autoOffsetReset,
                GroupId = groupId,
                EnableAutoCommit = true,
                EnableAutoOffsetStore = false,
            };

            using (var consumer = new ConsumerBuilder<Ignore, string>(config).Build())
            {
                consumer.Subscribe(topic);

                while (!_isStopped)
                {
                    var consumeResult = consumer.Consume(new TimeSpan(timeout));

                    if (consumeResult != null)
                    {
                        if (onMessageReceived != null)
                        {

                            if (!this._userFilter || Utilities.filterMe(consumeResult.Message.Value, this._filterValue, isJson, this._filterObject))
                            {
                                //dataStream.add(new MessageData(consumeResult.Message.Timestamp.UtcDateTime, consumeResult.Message.Value));
                                this._dataStream.increment();
                                onMessageReceived(consumeResult);
                            }
                        }

                        if (this._storeOffset)
                        {
                            consumer.StoreOffset(consumeResult);
                        }
                    }
                }
            }
        }

        public DataStream DataStream()
        {
            return this._dataStream;
        }
        public void stopListening()
        {
            this._dataStream.ChartData.Clear();
            this._isStopped = true;
        }
    }
}
