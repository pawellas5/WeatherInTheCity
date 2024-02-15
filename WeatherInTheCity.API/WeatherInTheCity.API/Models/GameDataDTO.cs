namespace WeatherInTheCity.API.Models
{
    public class GameDataDTO
    {
        public OpenWeatherDTO? Weather { get; set; }
        public List<CityDTO>? Cities { get; set; }
    }
}
