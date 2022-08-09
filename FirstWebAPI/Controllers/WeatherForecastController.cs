using FirstWebAPI.Data;
using FirstWebAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly FirstAPIContext _firstAPIContext;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, FirstAPIContext firstAPIContext)
        {
            _logger = logger;
            _firstAPIContext = firstAPIContext;
        }

        [HttpPost]
        public IActionResult Post(string name)
        {
            User user = new User();
            user.name = name;
            _firstAPIContext.Users.Add(user);
            _firstAPIContext.SaveChanges();
            return Ok();

        }

        [HttpGet]
        public IActionResult get()
        {
            return Ok("hello world");

        }
    }
}
