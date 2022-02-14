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

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var resault = service.Get();
        //    return resault;

        //}

        //[HttpGet()]
        //[Route("currentDay/{max}")]
        //public IEnumerable<WeatherForecast> Get([FromQuery] int start, [FromRoute] int max)
        //{
        //    var resault = service.Get();
        //    return resault;
        //}

        [HttpPost("generate")]
        public ActionResult<IEnumerable<WeatherForecast>> Generate([FromQuery]int noOfResaults,
            [FromBody] TemperatureRequest temperature){

            if (noOfResaults <= 0 || temperature.minTemperature > temperature.maxTemperature)
            {
                return StatusCode(400);
            }
            else {
                var resault = service.Get(noOfResaults, temperature.minTemperature, temperature.maxTemperature);
                return Ok(resault);
            }
        }

        [HttpPost]
        public ActionResult<string> Hello([FromBody]string name) {
            // HttpContext.Response.StatusCode = 401;
            // Return $"Hello {name}";
            return StatusCode(401, $"Hello{name}");
           // return NotFound($"Hello{ name }");
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
