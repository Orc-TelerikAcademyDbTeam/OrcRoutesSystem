using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo
{
    using System.Runtime.InteropServices;

    using MongoDB.Driver;

    public class MongWorker
    {
        private MongoClient client = new MongoClient("mongodb://localhost");

        public void Test()
        {
            var server = client.GetServer();
        }
    }
}
