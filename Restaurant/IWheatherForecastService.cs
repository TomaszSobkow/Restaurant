using System.Collections.Generic;

namespace Restaurant
{
    public interface IWheatherForecastService
    {
        IEnumerable<WeatherForecast> Get();
    }
}