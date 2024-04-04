namespace WeatherInTheCity.API.Entities
{
    public class QuestionList
    {
        public List<Question> Questions { get; set; } = new List<Question>();
        public int TotalPoints { get; set; } = 0;
    }
}
