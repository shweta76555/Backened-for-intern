using backened_for_intern.Data;
using backened_for_intern.Models;
using backened_for_intern.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backened_for_intern.Controllers.Auth
{
    [Route("api/v1/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            // Check if email already exists
            if (_context.Users.Any(u => u.Email == dto.Email))
            {
                return BadRequest(new { message = "Email already exists" });
            }

            // Hash password
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password);

            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                PasswordHash = passwordHash
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok(new { message = "User registered successfully" });
        }
    }



}

