using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PollySample.API.Services;

namespace PollySample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet("hello")]
        public async Task<IActionResult> GetHello()
        {
            var result = await _messageService.GetHelloMessage();
            return Ok(result);
        }

        [HttpGet("goodbye")]
        public async Task<IActionResult> GetGoodbye()
        {
            var result = await _messageService.GetGoodbyeMessage();
            return Ok(result);
        }
    }
}
