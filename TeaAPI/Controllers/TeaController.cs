using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TeaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeaController : ControllerBase
    {
        private static readonly string[] Teas = new[]
        {
            "Tea1", "Tea2", "Tea3", "Tea4"
        };

        private readonly ILogger<TeaController> _logger;

        public TeaController(ILogger<TeaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Tea> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Tea
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                TeaType = Teas[rng.Next(Teas.Length)]
            })
            .ToArray();
        }
    }
}
