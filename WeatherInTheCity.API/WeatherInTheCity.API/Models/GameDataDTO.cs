namespace WeatherInTheCity.API.Models
{
    public class GameDataDTO
    {
        public OpenWeatherDTO Weather { get; set; } = new OpenWeatherDTO();
        public List<CityDTO> Cities { get; set; } = new List<CityDTO>();
        public string? GameFlowId { get; set; }
    }
}
