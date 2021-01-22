using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using CaniFashion.Models;
using CaniFashion.Services;

namespace CaniFashion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        //private readonly UserService _userService;
        //public UserController(UserService userService)
        //{
        //    _userService = userService;
        //}

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User model)
        {
            //if (ModelState.IsValid)
            //{
            //    User user = _userService.Get().Where(en => en.email == model.email).FirstOrDefault();
            //    if (user.email == model.email)
            //    {
            //        ViewBag.Error = "Email already exit";
            //        return View();
            //    }
            //    else
            //    {
            //        model.password = GetMD5(model.password);
            //        _userService.Create(model);
            //        RedirectToAction("Login", "User");
            //    }
            //}
            ViewBag.Error = "Hello";
            return View();
        }

        //[HttpGet("{id:length(24)}")]
        //public IActionResult Login()
        //{
        //    return View();
        //}

        //[HttpPost("{id:length(24)}")]
        //public IActionResult Login(string username, string password)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var passMD5 = GetMD5(password);
        //        var users = _userService.Get()
        //                                .Where(en => en.username == username
        //                                            && en.password == passMD5);
        //        if (users != null)
        //        {
        //            return RedirectToAction("Index", "Home");
        //        }
        //        else
        //        {
        //            ViewBag.Error = "Incorrect username or password";
        //            return RedirectToAction("Login");
        //        }
        //    }

        //    return View();

        //}

        //public string GetMD5(string pass)
        //{
        //    MD5 md5 = new MD5CryptoServiceProvider();
        //    md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass));

        //    byte[] result = md5.Hash;

        //    StringBuilder strBuilder = new StringBuilder();
        //    for (int i=0; i<result.Length; i++)
        //    {
        //        strBuilder.Append(result[i].ToString("x2"));
        //    }

        //    return strBuilder.ToString();
        //}
    }
}