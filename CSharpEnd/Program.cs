using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MongoSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
          MongoClient client = new MongoClient("mongodb://127.0.0.1:27017/test"); // connect to localhost
        }
    }
}