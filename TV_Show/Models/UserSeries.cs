using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TV_Show.Models
{
    public class UserSeries
    {
        private string _userSeriesLogin;
        private string _userSeriesPassword;
        private string _serialName;
        private string _serialNameEng;
        private int _serialSeason;
        private int _seriesNumber;
        private string _seriesName;

        public UserSeries(string UserSeriesLogin, string UserSeriesPassword, 
            string serialName, string serialNameEng, int serialSeason, int seriesNumber, string seriesName)
        {
            _userSeriesLogin = UserSeriesLogin;
            _userSeriesPassword = UserSeriesPassword;
            _serialName = serialName;
            _serialNameEng = serialNameEng;
            _serialSeason = serialSeason;
            _seriesNumber = seriesNumber;
            _seriesName = seriesName;
        }

        public UserSeries()
        {
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id { get; set; }
        public string UserSeriesLogin { get => _userSeriesLogin; set => _userSeriesLogin = value; }
        public string UserSeriesPassword { get => _userSeriesPassword; set => _userSeriesPassword = value; }
        public string SerialName { get => _serialName; set => _serialName = value; }
        public string SerialNameEng { get => _serialNameEng; set => _serialNameEng = value; }
        public int SerialSeason { get => _serialSeason; set => _serialSeason = value; }
        public int SeriesNumber { get => _seriesNumber; set => _seriesNumber = value; }
        public string SeriesName { get => _seriesName; set => _seriesName = value; }

        public static void AddUserSeriesToDb(UserSeries userSeries)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("TV_Shows");
            var collection = db.GetCollection<UserSeries>("UserSeries");
            collection.InsertOne(userSeries);
        }
    }
}
