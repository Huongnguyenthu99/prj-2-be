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
    public class ChatBotController : Controller
    {
        private readonly ChatBotService _messService;

        public ChatBotController(ChatBotService messService)
        {
            _messService = messService;
        }

        [HttpGet]
        public ActionResult<List<ChatBot>> GetMessages()
        {
            return _messService.GetMessage();
        }

        [HttpPost]
        public IActionResult SaveMessages(ChatBot lstMessage)
        {
            _messService.SaveMessage(lstMessage);
            return NoContent();
        }
    }
}