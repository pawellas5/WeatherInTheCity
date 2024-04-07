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
        private readonly IGameFlowService _gameFlowService;

        public GameController(IOpenWeatherService openWeatherService, ICityService citiesService, IGameFlowService gameFlowService)
        {
            _openWeatherService = openWeatherService;
            _citiesService = citiesService;
            _gameFlowService = gameFlowService;
        }
        [HttpGet]
        public async Task<ActionResult<GameDataDTO>> Get([FromHeader] string? gameFlowId)
        {

            var gameData = new GameDataDTO();
            var randCities = await _citiesService.Rand4Cities();
            var weatherCity = randCities[0];
            var cities = randCities.OrderBy(c => c.CityName.GetHashCode()).ToList();
            var weather = await _openWeatherService.GetWeather($"{weatherCity.CityName.ToLower()},{weatherCity.CountryCode.ToLower()}");

            gameData.Weather = weather;
            gameData.Cities = cities;

            if (gameFlowId == null) // null, because it's the first question
            {
                gameFlowId = await _gameFlowService.CreateGameFlow(weatherCity.CityName);
            }
            else
            {
                gameFlowId = await _gameFlowService.AddQuestion(weatherCity.CityName, gameFlowId!);
            }


            gameData.GameFlowId = gameFlowId;

            return Ok(gameData);

        }

        [HttpPost("check")]
        public async Task<ActionResult<AnswerResultDTO>> CheckAnswer(AnswerDTO answer, [FromHeader] string gameFlowId)
        {

            var answerResultDTO = await _gameFlowService.GetCorrectAnswer(gameFlowId, answer.QuestionNumber);

            var isCorrect = (answer.City.ToLower() == answerResultDTO.CorrectAnswer.ToLower()) && (answer.City != string.Empty); //check the answer

            if (isCorrect)
            {
                await _gameFlowService.GivePoint(answer.QuestionNumber, gameFlowId);
            }

            answerResultDTO.IsUserCorrect = isCorrect;
            answerResultDTO.UserAnswer = answer.City;
            answerResultDTO.GameFlowId = gameFlowId;


            return Ok(answerResultDTO);
        }


        [HttpGet("result")]
        public async Task<ActionResult<int>> GetPercentageResult([FromHeader] string gameFlowId)
        {
            var result = await _gameFlowService.GetPercentageResult(gameFlowId);

            if (result == null) return BadRequest();

            return Ok(result);
        }



        [HttpDelete("gameflow")]
        public async Task<ActionResult> RemoveGameFlow([FromHeader] string? gameFlowId)
        {
            if (gameFlowId == null) return NoContent();

            await _gameFlowService.RemoveGameFlow(gameFlowId);

            return NoContent();
        }
    }
}