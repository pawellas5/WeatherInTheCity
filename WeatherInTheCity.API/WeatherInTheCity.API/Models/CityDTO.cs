namespace WeatherInTheCity.API.Models
{
    public class CityDTO
    {
        public string CityName { get; set; } = String.Empty;
        public string CountryName { get; set; } = String.Empty;
        public string CountryCode { get; set; } = String.Empty;
        public bool isCorrect { get; set; } = false;
        public bool isSelected { get; set; } = false;
    }
}
