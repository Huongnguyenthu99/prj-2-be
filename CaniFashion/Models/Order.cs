using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace CaniFashion.Models
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public CustomerInfo customer { get; set; }
        public List<ProductOfOrder> products { get; set; }
    }
    public class CustomerInfo
    {
        public string fullName { get; set; }
        public int phoneNum { get; set; }
        public string province { get; set; }
        public string address { get; set; }
    }
    public class ProductOfOrder
    {
        public Product product { get; set; }
        public int count { get; set; }
    }
}
