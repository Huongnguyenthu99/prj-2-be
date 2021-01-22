using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using CaniFashion.Models;
using Microsoft.Extensions.Configuration;

namespace CaniFashion.Services
{
    public class ChatBotService
    {
        private readonly IMongoCollection<ChatBot> _message;
        public ChatBotService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("ProductStoreDb"));
            var database = client.GetDatabase("CaniFashion");
            _message = database.GetCollection<ChatBot>("ChatBot");
        }

        public List<ChatBot> GetMessage()
        {
            return _message.Find(chatbot => true).ToList();
        }

        public void SaveMessage(ChatBot lstMessages)
        {
            _message.InsertOne(lstMessages);
        }
    }
}
