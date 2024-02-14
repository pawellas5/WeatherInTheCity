using WeatherInTheCity.API.Entities;

namespace WeatherInTheCity.API.Services
{
    public interface ICityService

    {
        public City CorrectCity { get; }
        public List<City> PossibleCities { get; }
        public Task Rand4Cities();
        public Task<List<City>> Get4CitiesById(List<int> indices);
        public  Task<int> CountCities();



    }
}
