using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Docker.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Health : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Healthy: " + DateTime.Now);
        }
    }
}
