using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Console_Print.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsolePrintController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            return Ok(new { Message = "Hello World" });
        }
    }
}
