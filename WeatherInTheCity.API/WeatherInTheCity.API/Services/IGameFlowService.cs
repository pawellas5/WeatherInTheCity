using WeatherInTheCity.API.Models;

namespace WeatherInTheCity.API.Services
{
    public interface IGameFlowService
    {
        public Task<string> CreateGameFlow(string correctCity);
        public Task GivePoint(int questionId, string gameFlowId);
        public Task<string> AddQuestion(string correctCity, string gameFlowId);
        public Task RemoveGameFlow(string gameFlowId);
        public Task<AnswerResultDTO> GetCorrectAnswer(string gameFlowId, int questionNumber);
        public Task<int?> GetPercentageResult(string gameFlowId);



    }
}
