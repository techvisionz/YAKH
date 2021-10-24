using LiteDB;
using System.Collections.Generic;

namespace YAKH.classes
{
    public class KafkaServer
    {
        public KafkaServer()
        {
            Topics = new List<string>();
        }

        [BsonId]
        public int Id { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string GroupId { get; set; }
        public List<string> Topics { get; set; }
    }
}
