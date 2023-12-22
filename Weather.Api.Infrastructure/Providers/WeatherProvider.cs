using System.Net.Http.Json;
using System.Text.Json;
using Weather.Api.Core;

namespace Weather.Api.Infrastructure
{
    public class WeatherProvider : IWeatherProvider
    {
        private HttpClient _client;
        public WeatherProvider()
        {
            _client = new HttpClient();
        }

        public async Task<WeatherInfo> GetWeatherDataAsync(string cityName)
        {
            string requestUrl = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid=69f9eae33587e1cbbd7d84f5077021d2";
            
            var response = await _client.GetAsync(requestUrl);
                
            WeatherInfo weather = await response.Content.ReadFromJsonAsync<WeatherInfo>();

            return weather;
        }
    }
}
