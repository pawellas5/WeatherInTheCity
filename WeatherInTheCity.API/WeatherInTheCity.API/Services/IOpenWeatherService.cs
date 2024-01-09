using WeatherInTheCity.API.Models;

namespace WeatherInTheCity.API.Services
{
    public interface IOpenWeatherService
    {
        public Task<OpenWeatherDTO> GetWeather(string city);
    }
}
