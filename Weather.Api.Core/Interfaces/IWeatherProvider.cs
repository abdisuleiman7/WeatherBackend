
using Weather.Api.Core;

public interface IWeatherProvider
{
    Task<WeatherInfo> GetWeatherDataAsync(string cityName);
}
