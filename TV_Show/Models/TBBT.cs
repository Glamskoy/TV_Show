using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TV_Show.Models
{
    public class TBBT
    {
        private string _serialName;
        private string _serialNameEng;
        private int _serialSeason;
        private int _seriesNumber;
        private string _seriesName;

        public TBBT(string serialName, string serialNameEng, int serialSeason, int seriesNumber, string seriesName)
        {
            SerialName = serialName;
            SerialNameEng = serialNameEng;
            SerialSeason = serialSeason;
            SeriesNumber = seriesNumber;
            SeriesName = seriesName;
        }

        public TBBT()
        {
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id { get; set; }
        public string SerialName { get => _serialName; set => _serialName = value; }
        public string SerialNameEng { get => _serialNameEng; set => _serialNameEng = value; }
        public int SerialSeason { get => _serialSeason; set => _serialSeason = value; }
        public int SeriesNumber { get => _seriesNumber; set => _seriesNumber = value; }
        public string SeriesName { get => _seriesName; set => _seriesName = value; }

        public static void AddSeriesTBBTToDb(TBBT tbbt)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("TV_Shows");
            var collection = db.GetCollection<TBBT>("TheBigBangTheory");
            collection.InsertOne(tbbt);
        }
     }
}

