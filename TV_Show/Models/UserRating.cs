using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TV_Show.Models
{
    public class UserRating
    {
        private string _userRatingLogin;
        private string _userRatingPassword;
        private string _serialNameEng;
        private int _singleUserRating;

        public UserRating()
        {
        }

        public UserRating(string userRatingLogin, string userRatingPassword, string serialNameEng, int singleUserRating)
        {
            UserRatingLogin = userRatingLogin;
            UserRatingPassword = userRatingPassword;
            SerialNameEng = serialNameEng;
            SingleUserRating = _singleUserRating;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id { get; set; }
        public string UserRatingLogin { get => _userRatingLogin; set => _userRatingLogin = value; }
        public string UserRatingPassword { get => _userRatingPassword; set => _userRatingPassword = value; }
        public string SerialNameEng { get => _serialNameEng; set => _serialNameEng = value; }
        public int SingleUserRating { get => _singleUserRating; set => _singleUserRating = value; }

        public static void AddUserRatingToDb(UserRating userRating)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("TV_Shows");
            var collection = db.GetCollection<UserRating>("UserRating");
            collection.InsertOne(userRating);
        }
    }
}
