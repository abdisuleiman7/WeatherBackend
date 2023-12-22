using System.Net.Http.Json;
using Microsoft.Extensions.Configuration;
using Weather.Api.Core;
namespace Weather.Api.Infrastructure
{
    public class WeatherProvider : IWeatherProvider
    {
        private HttpClient _client;
        private readonly string _apiKey;
        private readonly IConfiguration _configuration; 

        public WeatherProvider(IConfiguration configuration)
        {
            _configuration = configuration;
            _client = new HttpClient();
            
        }

        public async Task<WeatherInfo> GetWeatherDataAsync(string cityName)
        {
            var apiKey = _configuration["ApiKey"];

            string requestUrl = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}";
            
            var response = await _client.GetAsync(requestUrl);
                
            WeatherInfo weather = await response.Content.ReadFromJsonAsync<WeatherInfo>();

            return weather;
        }
    }
}
