using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WeatherInTheCity.API.Models;
using WeatherInTheCity.API.Services;

namespace WeatherInTheCity.API.Controllers
{
    [ApiController]
    [Route("weather")]
    public class WeatherController : ControllerBase
    {
        private readonly IOpenWeatherService _openWeatherService;
        public WeatherController(IOpenWeatherService openWeatherService)
        {
                _openWeatherService = openWeatherService;
        }
        [HttpGet("{city}")]
        public async Task<ActionResult<OpenWeatherDTO>> Get(string city)
        {
           var weather = await _openWeatherService.GetWeather(city);
           if(weather == null)
            {
                return NotFound();
            }

            return Ok(weather);

        }
    }
}
