using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using newbackend.Data;

namespace backend
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class PruductController : ControllerBase
    {
        ILogger<PruductController> _logger;

        public PruductController(ILogger<PruductController> logger, DataContext dataContext)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok("tanakorn");
            }
            catch (Exception)
            {
                _logger.LogError("Failed to execute GET");
                return StatusCode(500);
            }
        }

        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                return Created("", null);
            }
            catch (Exception)
            {
                _logger.LogError("Failed to execute POST");
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Put()
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                _logger.LogError("Failed to execute PUT");
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                _logger.LogError("Failed to execute DELETE");
                return BadRequest();
            }
        }

        [AllowAnonymous]
        [HttpGet("images/{name}")]
        public IActionResult ProductImage(string name)
        {
            return File($"~/images/{name}", "image/jpg");
        }
    }
}