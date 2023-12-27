using Microsoft.AspNetCore.Mvc;
using Weather.Api.Core;

namespace Weather.Api.REST.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherProvider _weatherProvider;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,IWeatherProvider weatherProvider)
    {
        _logger = logger;
        _weatherProvider = weatherProvider;

    }

    [HttpGet("GetWeather/{cityName}")]
    public Task<WeatherResult> GetWeatherByCityName(string cityName)
    {
        return new WeatherResult().WeatherMapping(_weatherProvider.GetWeatherByLocation(cityName));
    }

    [HttpGet("GetWeather/{lon}/{lat}")]
    public Task<WeatherResult> GetWeatherByCoordinates(float lon, float lat)
    {
        return new WeatherResult().WeatherMapping(_weatherProvider.GetWeatherByCoordinates(lon, lat));
    }

}
