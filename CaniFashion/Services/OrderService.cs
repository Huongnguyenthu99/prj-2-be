using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using CaniFashion.Models;
using Microsoft.Extensions.Configuration;

namespace CaniFashion.Services
{
    public class OrderService
    {
        private readonly IMongoCollection<Order> _order;
        public OrderService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("ProductStoreDb"));
            var database = client.GetDatabase("CaniFashion");
            _order = database.GetCollection<Order>("Order");
        }
        public List<Order> Get()
        {
            return _order.Find(product => true).ToList();
        }
        public Order Create(Order order)
        {
            _order.InsertOne(order);
            return order;
        }
    }
}
