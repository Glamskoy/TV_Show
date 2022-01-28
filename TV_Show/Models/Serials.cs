using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TV_Show.Models
{
    public class Serials
    {
        private string _serialName;
        private string _serialNameEng;
        private string _releaseDate;
        private string _finishDate;
        private int _seriesTime;
        private int _seasons;
        private string _about;

        public Serials()
        {
        }

        public Serials(string serialName, string serialNameEng, string releaseDate, string finishDate, 
            int seriesTime, int seasons, string about)
        {
            SerialName = serialName;
            SerialNameEng = serialNameEng;
            ReleaseDate = releaseDate;
            FinishDate = finishDate;
            SeriesTime = seriesTime;
            Seasons = seasons;
            About = about;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id { get; set; }
        public string SerialName { get => _serialName; set => _serialName = value; }
        public string SerialNameEng { get => _serialNameEng; set => _serialNameEng = value; }
        public string ReleaseDate { get => _releaseDate; set => _releaseDate = value; }
        public string FinishDate { get => _finishDate; set => _finishDate = value; }
        public int SeriesTime { get => _seriesTime; set => _seriesTime = value; }
        public int Seasons { get => _seasons; set => _seasons = value; }
        public string About { get => _about; set => _about = value; }

        public static void AddSerialsToDb(Serials serial)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("TV_Shows");
            var collection = db.GetCollection<Serials>("Serials");
            collection.InsertOne(serial);
        }
    }
}
