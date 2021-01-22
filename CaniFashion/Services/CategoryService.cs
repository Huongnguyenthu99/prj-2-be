using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using CaniFashion.Models;
using Microsoft.Extensions.Configuration;

namespace CaniFashion.Services
{
    public class CategoryService
    {
        private readonly IMongoCollection<Category> _name;
        public CategoryService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("ProductStoreDb"));
            var database = client.GetDatabase("CaniFashion");
            _name = database.GetCollection<Category>("Category");
        }
        public List<Category> GetCategoryData()
        {
            return _name.Find(name => true).ToList();
        }
    }
}
