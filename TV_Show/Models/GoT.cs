using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TV_Show.Models {
    public class GoT : Serials 
    {
        private string _serieslName;
        private int _serieslNumber;
        private int _serialSeason;

        public GoT(int serialSeason, int serieslNumber, string serieslName)
        {
            SerialSeason = serialSeason;
            SerieslNumber = serieslNumber;
            SerieslName = serieslName;
        }

        public GoT()
        {
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id { get; set; }
        public string SerieslName { get => _serieslName; set => _serieslName = value; }
        public int SerieslNumber { get => _serieslNumber; set => _serieslNumber = value; }
        public int SerialSeason { get => _serialSeason; set => _serialSeason = value; }

        public static void AddSeriesToDb(GoT got)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("TV_Shows");
            var collection = db.GetCollection<GoT>("GameofThrones");
            collection.InsertOne(got);
        }
    }
}
