using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CofeeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        private static readonly string[] Cofees = new[]
        {
            "Cofee1", "Cofee2", "Cofee3", "Cofee4", "Cofee5"
        };

        private readonly ILogger<CoffeeController> _logger;

        public CoffeeController(ILogger<CoffeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Cofee> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Cofee
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                CofeeType = Cofees[rng.Next(Cofees.Length)]
            })
            .ToArray();
        }
    }
}
