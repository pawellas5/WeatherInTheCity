using Microsoft.Extensions.Configuration;
using Microsoft.Net.Http.Headers;
using System.Net.Http;
using System.Text.Json;
using WeatherInTheCity.API.Models;
using System.Net.Http.Headers;
using System.Net;
namespace WeatherInTheCity.API.Services
{
    public class OpenWeatherService : IOpenWeatherService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        public OpenWeatherService(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        public async Task<OpenWeatherDTO> GetWeather(string city)
        {
            var apiKey = _configuration["WeatherApiKey"];

            var httpClient = _httpClientFactory.CreateClient();
            httpClient.Timeout = new TimeSpan(0, 0, 45);

            var httpRequestMessage = new HttpRequestMessage(
            HttpMethod.Get,
            $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={apiKey}");
            httpRequestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
            
            httpResponseMessage.EnsureSuccessStatusCode();

            using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

            var weather = await JsonSerializer.DeserializeAsync<OpenWeatherDTO>(contentStream);


            return weather!;
        }
    }
}
