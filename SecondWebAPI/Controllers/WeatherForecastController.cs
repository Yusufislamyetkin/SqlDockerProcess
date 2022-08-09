using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SecondWebAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly SecondAPIContext _secondAPIContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, SecondAPIContext secondAPIContext)
        {
            _logger = logger;
            _secondAPIContext = secondAPIContext;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public IActionResult Post(Order order)
        {
            Order or = new Order();
            or.Name = order.Name;
            or.UserId = order.UserId;
            _secondAPIContext.orders.Add(or);
      
            _secondAPIContext.SaveChanges();
            return Ok();
        }
    }
}
