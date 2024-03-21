namespace WeatherInTheCity.API.Entities
{
    public class UserStats
    {
        public int Id { get; set; }
        public string UserId { get; set; } = String.Empty;
        public int Wins  { get; set; } 
        public int Defeats { get; set; }
        public int Games { get; set; }
    }
}
