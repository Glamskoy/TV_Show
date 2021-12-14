﻿using MongoDB.Bson;
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
        private int _seasons;
        private int _year;

        private string _serieslName;
        private int _serieslNumber;
        

        public Serials()
        {
        }

        public Serials(string serialName, int seasons, int year)
        {
            SerialName = serialName;
            Seasons = seasons;
            Year = year;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id { get; set; }
        public string SerialName { get => _serialName; set => _serialName = value; }
        public int Seasons { get => _seasons; set => _seasons = value; }
        public int Year { get => _year; set => _year = value; }
        public string SerieslName { get => _serieslName; set => _serieslName = value; }
        public int SerieslNumber { get => _serieslNumber; set => _serieslNumber = value; }
        

        public static async Task AddSerialsToDb(Serials serial)
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("TV_Shows");
            var collection = db.GetCollection<Serials>("Serials");
            collection.InsertOne(serial);

        }

        public static void AddToFile(Serials ser)
        {
            //FileInfo newFile = new FileInfo("D:/Projects/TV_Show/TV_Show/Db/Serials.txt");
            //newFile.Refresh();

            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("TV_Shows");
            var collection = db.GetCollection<Serials>("Serials").ToString();
            //foreach (var item in collection)
            //{
            //    using (FileStream fs = new FileStream("D:/Projects/TV_Show/TV_Show/Db/Serials.txt", FileMode.OpenOrCreate))
            //    {
            //        fs.Write(((byte)item), 0, ((byte)item));
            //    }

            //}

            //using (FileStream fs = new FileStream("D:/Projects/TV_Show/TV_Show/Db/Serials.txt", FileMode.OpenOrCreate))
            //{
            //    fs.Write();
            //}
            //StreamReader str = new StreamReader("D:/Projects/TV_Show/TV_Show/Db/Serials.xtx");
            //str.ReadToEnd();
        }
        //public static void AddSeriesToDb(Serials series)
        //{
        //    var connectionString = "mongodb://localhost";
        //    var client = new MongoClient(connectionString);
        //    var db = client.GetDatabase("TV_Shows");
        //    var collection = db.GetCollection<Serials>("Series");
        //    collection.InsertOne(series);
        //}

        //public static void GetSerialsFromDb(string serialName)
        //{
        //    var connectionString = "mongodb://localhost";
        //    var client = new MongoClient(connectionString);
        //    var db = client.GetDatabase("TV_Shows");
        //    var collection = db.GetCollection<Serials>("Serials");
        //    Serials serials = collection.Find(filter => filter.SerialName == serialName).FirstOrDefault();
        //}
    }
}