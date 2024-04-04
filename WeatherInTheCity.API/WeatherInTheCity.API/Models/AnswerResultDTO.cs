namespace WeatherInTheCity.API.Models
{
    public class AnswerResultDTO
    {
        public string CorrectAnswer { get; set; } = string.Empty;
        public string UserAnswer { get; set; } = string.Empty;
        public bool IsUserCorrect { get; set; } = false;
        public string GameFlowId { get; set; } = string.Empty;
        public int? TotalPoints { get; set;}
    }
}
