using System.ComponentModel.DataAnnotations;

namespace WeatherInTheCity.API.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; } = String.Empty;
        public string CountryName { get; set; } = String.Empty;
        public string CountryCode { get; set; } = String.Empty;

    }
}
