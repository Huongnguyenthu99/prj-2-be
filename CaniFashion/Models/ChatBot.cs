using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CaniFashion.Models
{
    public class ChatBot
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public List<Message> ListMessages { get; set; }
    }
    public class Message
    {
        public string request { get; set; }
        public string response { get; set; }
    }
}
