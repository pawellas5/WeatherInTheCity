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
        //[Authorize]
        public async Task<ActionResult<GameDataDTO>> Get([FromHeader] string? gameFlowId)
        {

            var gameData = new GameDataDTO();
            var cities = await _citiesService.Rand4Cities();
            var weatherCity = cities.Where(c => c.isCorrect == true).First();
            var weather = await _openWeatherService.GetWeather($"{weatherCity.CityName.ToLower()},{weatherCity.CountryCode.ToLower()}");

            gameData.Weather = weather;
            gameData.Cities = cities;


            if (gameData == null)
            {
                return NotFound();
            }
            var correctCity = gameData.Cities.FirstOrDefault(c => c.isCorrect == true);

            if (gameFlowId == null) // null, because it's the first question
            {
                gameFlowId = await _gameFlowService.CreateGameFlow(correctCity!.CityName); 
            }
            else
            {               
                gameFlowId = await _gameFlowService.AddQuestion(correctCity!.CityName, gameFlowId!); 
            }


            gameData.GameFlowId = gameFlowId;

            return Ok(gameData);

        }

        [HttpPost("check")]
        public async Task<ActionResult<AnswerResultDTO>> CheckAnswer(AnswerDTO answer, [FromHeader] string gameFlowId)
        {

            var correctAnswer = await _gameFlowService.GetCorrectAnswer(gameFlowId, answer.QuestionNumber);

            var isCorrect = (answer.City.ToLower() == correctAnswer.ToLower()) && (answer.City != string.Empty); //check the answer

            if (isCorrect)
            {
                await _gameFlowService.GivePoint(answer.QuestionNumber, gameFlowId);
            }

            var answerResult = new AnswerResultDTO();
            answerResult.IsUserCorrect = isCorrect;
            answerResult.UserAnswer = answer.City;
            answerResult.CorrectAnswer = correctAnswer;
            answerResult.GameFlowId = gameFlowId;


            return Ok(answerResult);
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