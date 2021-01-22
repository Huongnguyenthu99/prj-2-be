using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace CaniFashion.Models
{
    public class User
    {
        [BsonId]
        public string Id { get; set; }

        [BsonElement("username")]
        public string username { get; set; }
        public string password { get; set; }
        [Display(Name ="Confirm Password")]
        [Compare("password", ErrorMessage="Comfirm password do not match")]
        public string confirmPassword { get; set; }
        public string email { get; set; }
    }
}
