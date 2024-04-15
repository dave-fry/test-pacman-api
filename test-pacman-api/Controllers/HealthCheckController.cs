using Microsoft.AspNetCore.Mvc;

namespace test_pacman_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet("ping")]
        public string Ping()
        {
            return "pong";
        }
    }
}
