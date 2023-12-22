using Microsoft.AspNetCore.Mvc;
using Weather.Api.Core;

namespace Weather.Api.REST.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherProvider _weatherProvider;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,IWeatherProvider weatherProvider)
    {
        _logger = logger;
        _weatherProvider = weatherProvider;

    }

    [HttpGet(Name = "GetWeatherForecastByCityName")]
    public Task<WeatherInfo> GetWeather(string cityName)
    {

          return _weatherProvider.GetWeatherDataAsync(cityName);
        
    }

    // [HttpGet(Name = "GetWeatherForecastByCoordinates")]
    // public Task<WeatherInfo> GetWeather(float lat, float lon)
    // {

    //     return _weatherProvider.GetWeatherDataAsync(lat, lon);

    // }

}
