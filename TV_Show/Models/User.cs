using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TV_Show.Models
{
    public class User
    {
        private string _currentUserLogin;
        private string _currentUserPassword;
        private string _serialName;
        private int _serialSeason;
        private int _seriesNumber;
        private string _seriesName;

        public User()
        {
        }

        public User(string currentUserLogin, string currentUserPassword, string serialName, 
            int serialSeason, int seriesNumber, string seriesName)
        {
            _currentUserLogin = currentUserLogin;
            _currentUserPassword = currentUserPassword;
            _serialName = serialName;
            _serialSeason = serialSeason;
            _seriesNumber = seriesNumber;
            _seriesName = seriesName;
        }

        public User(string currentUserLogin, string currentUserPassword)
        {
            _currentUserLogin = currentUserLogin;
            _currentUserPassword = currentUserPassword;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id { get; set; }

        public string CurrentUserLogin { get => _currentUserLogin; set => _currentUserLogin = value; }
        public string CurrentUserPassword { get => _currentUserPassword; set => _currentUserPassword = value; }
        public string SerialName { get => _serialName; set => _serialName = value; }
        public int SerialSeason { get => _serialSeason; set => _serialSeason = value; }
        public int SeriesNumber { get => _seriesNumber; set => _seriesNumber = value; }
        public string SeriesName { get => _seriesName; set => _seriesName = value; }

        
        public static void AddUserSerialsToDb(User user)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("TV_Shows");
            var collection = db.GetCollection<User>("Users");
            collection.InsertOne(user);
        }
        public static void AddUserToDb(User user)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("TV_Shows");
            var collection = db.GetCollection<User>("Users");
            collection.InsertOne(user);
        }
    }
}
