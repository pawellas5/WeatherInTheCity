using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeatherInTheCity.API.Models;
using WeatherInTheCity.API.Services;

namespace WeatherInTheCity.API.Controllers
{
    [Route("game")]
    [ApiController]

    public class GameController : ControllerBase
    {
        private readonly IOpenWeatherService _openWeatherService;
        private readonly ICityService _citiesService;

        public GameController(IOpenWeatherService openWeatherService, ICityService citiesService)
        {
            _openWeatherService = openWeatherService;
            _citiesService = citiesService;
        }

        [HttpGet]
        //[Authorize]
        public async Task<ActionResult<GameDataDTO>> Get()
        {

            var gameData = new GameDataDTO();
            var cities = await _citiesService.Rand4Cities();
            var weatherCity = cities.Where(c=>c.isCorrect==true).First();
            var weather = await _openWeatherService.GetWeather($"{weatherCity.CityName.ToLower()},{weatherCity.CountryCode.ToLower()}");

            gameData.Weather = weather;
            gameData.Cities = cities;


            if (gameData == null)
            {
                return NotFound();
            }

            return Ok(gameData);

        }

    }
}
