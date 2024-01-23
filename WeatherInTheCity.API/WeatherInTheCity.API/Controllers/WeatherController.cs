using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
        private readonly ICitiesService _citiesService;

        public WeatherController(IOpenWeatherService openWeatherService, ICitiesService citiesService)
        {
            _openWeatherService = openWeatherService;
            _citiesService = citiesService;
        }

        [HttpGet]
        public async Task<ActionResult<OpenWeatherDTO>> Get()
        {
            _citiesService.Rand4Cities();

            var possibleCities = _citiesService.PossibleCities;
            var correctCity = _citiesService.CorrectCity;

            var weather = await _openWeatherService.GetWeather($"{correctCity.CityName},{correctCity.CountryCode})");

            
            if (weather == null)
            {
                return NotFound();
            }

            return Ok(weather);

        }

    }
}
