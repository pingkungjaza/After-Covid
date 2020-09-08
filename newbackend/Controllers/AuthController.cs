using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using newbackend.Models;
using newbackend.Services;

namespace newbackend.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository authRepository;
        ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger, IAuthRepository authRepository)
        {
            this.authRepository = authRepository;
            _logger = logger;
        }


        [HttpPut]
        [HttpPost("login")]
        public IActionResult Login([FromBody] Users user)
        {
            try
            {
                (Users users, String token) = authRepository.Login(user);
                if (user == null)
                {
                    return Unauthorized(new { message = "username invalid" });
                }

                if (String.IsNullOrEmpty(token))
                {
                    return Unauthorized(new { message = "password invalid" });
                }

                return Ok(new { token = token, message = "login successfully" });
            }
            catch (Exception error)
            {
                _logger.LogError("Failed to execute DELETE");
                return StatusCode(500, new { message = error });
            }
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] Users user)
        {
            try
            {
                authRepository.Register(user);
                return Ok(new { message = "register successfully" });
            }
            catch (Exception error)
            {
                _logger.LogError("Failed to execute DELETE");
                return StatusCode(500, new { message = error });
            }
        }

    }
}