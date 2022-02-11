using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant {

    public class WheatherForecastService : IWheatherForecastService
    {

        private static readonly string[] Summaries = new[]{
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 2).Select(index => new WeatherForecast {
                No = index,
                Date = DateTime.Now,
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray();
        }
    }

}
