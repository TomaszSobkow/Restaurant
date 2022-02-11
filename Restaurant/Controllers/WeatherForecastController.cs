using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWheatherForecastService service;
        private readonly ILogger<WeatherForecastController> logger;

        //Constructor
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWheatherForecastService service)
        {
            this.logger = logger;
            this.service = service;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var resault = service.Get();
            return resault;
        
        }

        [HttpGet]
        [Route("curretDay")]
        public IEnumerable<WeatherForecast> Get2()
        {
            var resault = service.Get();
            return resault;

        }


    }
}
