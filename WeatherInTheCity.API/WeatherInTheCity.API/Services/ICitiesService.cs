using WeatherInTheCity.API.Entities;

namespace WeatherInTheCity.API.Services
{
    public interface ICitiesService

    {
        public City CorrectCity { get; }
        public List<City> PossibleCities { get; }
        public void Rand4Cities();

    }
}
