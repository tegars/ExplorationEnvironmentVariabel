using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace LearnEnvironmentVariabel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public WeatherForecastController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            bool isChallenge = Helpers.EnvironmentVariable.IsChallenge(_configuration);
            string domain = Helpers.EnvironmentVariable.Freshdesk(_configuration, "domain");
            string password = Helpers.EnvironmentVariable.Freshdesk(_configuration, "password");


            var EnvironmentVariabel = new
            {
                isChallenge = isChallenge,
                domain = domain,
                password = password
            };
            return Ok(EnvironmentVariabel);
        }
    }
}
