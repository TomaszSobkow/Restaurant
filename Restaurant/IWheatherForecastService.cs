using System.Collections.Generic;

namespace Restaurant
{
    public interface IWheatherForecastService
    {
        IEnumerable<WeatherForecast> Get(int numberOfResaults, int minTemp, int maxTemp);
       // IEnumerable<WeatherForecast> Get();
    }

}