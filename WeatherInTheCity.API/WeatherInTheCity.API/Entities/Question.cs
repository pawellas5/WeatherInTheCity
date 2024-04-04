namespace WeatherInTheCity.API.Entities
{
    public class Question
    {

        public int QuestionNumber { get; set; }
        public string CorrectAnswer { get; set; } = string.Empty;
        public bool UserPoint { get; set; } = false;


    }
}
