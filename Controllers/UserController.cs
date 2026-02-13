using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace backened_for_intern.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]  // 🔐 Ye protect karega
    public class UserController : ControllerBase
    {


        [HttpGet("profile")]
        public IActionResult GetProfile()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var email = User.FindFirst(ClaimTypes.Email)?.Value;
            var role = User.FindFirst(ClaimTypes.Role)?.Value;

            return Ok(new
            {
                message = "Authorized access successful",
                userId,
                email,
                role
            });
        }
    }
}
