using Microsoft.AspNetCore.Mvc;

namespace REST_APIs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello from Web API!" });
        }

        // GET api/helloapi/time
        [HttpGet("time")]
        public IActionResult GetCurrentTime()
        {
            var currentTime = DateTime.UtcNow;
            return Ok(new { currentTime = currentTime.ToString("o") }); // ISO 8601 format
        }
    }
}
