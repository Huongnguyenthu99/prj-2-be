using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using CaniFashion.Models;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace CaniFashion.Services
{
    public class ProductService
    {
        private readonly IHostingEnvironment _environment;

        private readonly IMongoCollection<Product> _product;
        public ProductService(IConfiguration config, IHostingEnvironment IHostingEnvironment)
        {
            var client = new MongoClient(config.GetConnectionString("ProductStoreDb"));
            var database = client.GetDatabase("CaniFashion");
            _product = database.GetCollection<Product>("Product");
            _environment = IHostingEnvironment;
        }

        public List<Product> Get()
        {
             return _product.Find(product => true).ToList();
        }

        public Product Get(string id) { 
            return _product.Find<Product>(en => en.Id == id).FirstOrDefault();
        }

        public Product Create(Product product)
        {
            _product.InsertOne(product);
            return product;
        }

        public void Update(string id, Product proIn)
        {
            _product.ReplaceOne(en => en.Id == id, proIn);
        }

        public void Remove(Product proIn)
        {
            _product.DeleteOne(en => en.Id == proIn.Id);
        }

        public void Remove(string id)
        {
            _product.DeleteOne(en => en.Id == id);
        }

        public string UploadImage(IFormFile file)
        {
            string uploads = Path.Combine(_environment.WebRootPath, "uploads");
            string filePath = Path.Combine(uploads, file.FileName);  
            using (Stream fileStream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyToAsync(fileStream);
            }
            return filePath;
        }
    }
}
