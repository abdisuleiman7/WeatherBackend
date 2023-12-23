
using Weather.Api.Core;

public interface IWeatherProvider
{
    Task<WeatherInfo> GetWeatherByLocation(string cityName);
    Task<WeatherInfo> GetWeatherByCoordinates(float lat, float lon);
}
