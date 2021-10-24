using LiteDB;
using System.Collections.Generic;

namespace YAKH.classes
{
    public class DBManager
    {
        static string YAKMDB = @"YAKHDB.db";
        static string KAFKA_COLLECTION = "kafkaservers";
        public static void createServer(KafkaServer server)
        {
            using (var db = new LiteDatabase(YAKMDB))
            {
                var col = db.GetCollection<KafkaServer>(KAFKA_COLLECTION);
                col.Insert(server);
            }
        }

        public static void updateServer(KafkaServer server)
        {
            using (var db = new LiteDatabase(YAKMDB))
            {
                var col = db.GetCollection<KafkaServer>(KAFKA_COLLECTION);
                col.Update(server);
            }
        }

        public static KafkaServer findServer(string host)
        {
            using (var db = new LiteDatabase(YAKMDB))
            {
                var col = db.GetCollection<KafkaServer>(KAFKA_COLLECTION);
                var server = col.FindOne(x => x.Host == host);

                if (server != null)
                {
                    return (KafkaServer)server;
                }
            }

            return null;
        }

        public static IEnumerable<KafkaServer> getServers()
        {
            using (var db = new LiteDatabase(YAKMDB))
            {
                var col = db.GetCollection<KafkaServer>(KAFKA_COLLECTION);
                var servers = col.FindAll();
                if (servers != null)
                {
                    return servers;
                }
            }

            return null;
        }
    }
}
