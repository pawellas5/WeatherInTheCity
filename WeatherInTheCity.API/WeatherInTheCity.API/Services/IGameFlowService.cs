namespace WeatherInTheCity.API.Services
{
    public interface IGameFlowService
    {
        public Task<string> CreateGameFlow(string correctCity);
        public Task<string> GivePoint(int questionId, string gameFlowId);
        public Task<string> AddQuestion(string correctCity, string gameFlowId);
        public Task RemoveGameFlow(string gameFlowId);
        public Task<string> GetCorrectAnswer(string gameFlowId, int questionNumber);

    }
}
