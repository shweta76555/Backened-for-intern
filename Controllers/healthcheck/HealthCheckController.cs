using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backened_for_intern.Controllers.healthcheck
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {

        [HttpGet]
        public IActionResult HealthCheck()
        {
            return Ok("Ok sabb thik hai serverver chal raha hai--> http://localhost:5052");
        }

    }
}
