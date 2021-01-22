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
    public class OrderController : Controller
    {
        private readonly OrderService _orderService;
        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }
        
        [HttpGet]
        public ActionResult<List<Order>> Get()
        {
            List<Order> lstProducts = _orderService.Get();
            return lstProducts;
        }
        [HttpPost]
        public ActionResult CreatOrder(Order order)
        {
            _orderService.Create(order);
            return NoContent();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}