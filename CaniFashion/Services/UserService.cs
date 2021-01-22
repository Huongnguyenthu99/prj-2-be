using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using CaniFashion.Models;
using Microsoft.Extensions.Configuration;

namespace CaniFashion.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;
        public UserService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("ProductStoreDb"));
            var database = client.GetDatabase("CaniFashion");
            _users = database.GetCollection<User>("User");
        }
        public List<User> Get() =>
            _users.Find(user => true).ToList();

        public User Get(string id) =>
            _users.Find<User>(user => user.Id == id).FirstOrDefault();

        public User Create(User user)
        {
            _users.InsertOne(user);
            return user;
        }

        public void Update(string id, User userIn) =>
            _users.ReplaceOne(user => user.Id == id, userIn);

        public void Remove(User userIn) =>
            _users.DeleteOne(user => user.Id == userIn.Id);

        public void Remove(string id) =>
            _users.DeleteOne(user => user.Id == id);
    }
}