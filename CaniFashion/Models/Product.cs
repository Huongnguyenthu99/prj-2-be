using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CaniFashion.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int amount { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public string imageUrl { get; set; }
    }   
}
