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

        public User()
        {
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

        
        public static void AddUserToDb(User user)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("TV_Shows");
            var collection = db.GetCollection<User>("Users");
            collection.InsertOne(user);
        }

        //public static void RemoveUserSerialsFromDb(User user)
        //{
        //    var connectionString = "mongodb://localhost";
        //    var client = new MongoClient(connectionString);
        //    var db = client.GetDatabase("TV_Shows");
        //    var collection = db.GetCollection<User>("Users");
        //}
    }
}
