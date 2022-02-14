using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant {

    public class WheatherForecastService : IWheatherForecastService
    {

        private static readonly string[] Summaries = new[]{
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecast> Get(int numberOfResaults, int minTemp, int maxTemp)
        {
            var rng = new Random();
            return Enumerable.Range(1, numberOfResaults).Select(index => new WeatherForecast {
                No = index,
                Date = DateTime.Now,
                TemperatureC = rng.Next(minTemp, maxTemp),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray();
        }
    }

}
