using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;


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

        [HttpGet()]
        [Route("currentDay/{max}")]
        public IEnumerable<WeatherForecast> Get([FromQuery] int start, [FromRoute] int max)
        {
            var resault = service.Get();
            return resault;
        }

        [HttpPost]
        public string Hello([FromBody]string name) {
            return $"Hello{name}";
        }


        //1 option to change HttpGet 
        //[HttpGet("currentDay")]
        //public IEnumerable<WeatherForecast> Get2()
        //{
        //    var resault = service.Get();
        //    return resault;

        //}


    }
}
