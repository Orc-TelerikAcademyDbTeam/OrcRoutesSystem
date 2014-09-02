using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo
{
    using System.Runtime.InteropServices;

    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;
    using MongoDB.Driver;

    public class MongoWorker
    {
        private MongoClient client = new MongoClient("mongodb://localhost");

        public void Test()
        {
            var server = client.GetServer();
            MongoDatabase db = server.GetDatabase("Tester");
            var test = db.GetCollection("justatest");
            test.Insert(
                new Log()
                    {
                        Id = ObjectId.GenerateNewId().ToString(),
                        LogDate = DateTime.Now,
                        Text = "Something important happened"
                    });
        }

        class Log
        {
            [BsonRepresentation(BsonType.ObjectId)]
            public string Id { get; set; }

            public string Text { get; set; }

            public DateTime LogDate { get; set; }
        }
    }
}
