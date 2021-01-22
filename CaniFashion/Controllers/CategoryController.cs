using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CaniFashion.Services;
using CaniFashion.Models;

namespace CaniFashion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly CategoryService _nameService;
        public CategoryController(CategoryService name)
        {
            _nameService = name;
        }

        [HttpGet]
        public ActionResult <List<Category>> GetName()
        {
            return _nameService.GetCategoryData();
        }
    }
}