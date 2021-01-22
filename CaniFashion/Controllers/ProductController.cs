using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CaniFashion.Services;
using CaniFashion.Models;
using System.IO;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace CaniFashion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly ProductService _prodService;

        public ProductController(ProductService prodService)
        {
            _prodService = prodService;
        }

        [HttpGet]   
        public ActionResult<List<Product>> Get()
        {
            List<Product> lstProducts = _prodService.Get();
            //ViewData["Message"] = lstProducts;
            return lstProducts;
        }

        [HttpGet("{id:length(24)}")]
        public ActionResult<Product> Get(string id)
        {
            var prod = _prodService.Get(id);

            if (prod == null)
            {
                return NotFound();
            }
                        
            return prod;
        }

        [HttpPost("add")]
        public ActionResult<Product> Create(Product prod)
        {
            return _prodService.Create(prod);
        }

        [HttpPut("{id:length(24)}")]
        public ActionResult<Product> Update(string id, Product prodIn)
        {
            var prod = _prodService.Get(id);

            if (prod == null)
            {
                return NotFound();
            }

            _prodService.Update(id, prodIn);

            return prod;
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var prod = _prodService.Get(id);

            if (prod == null)
            {
                return NotFound();
            }

            _prodService.Remove(prod.Id);

            return NoContent();
        }
        [HttpPost("upload")]
        public ActionResult UploadImage(IFormFile file)
        {
            var path =  _prodService.UploadImage(file);
            return Json(new { fileName = path });
        }
    }
}