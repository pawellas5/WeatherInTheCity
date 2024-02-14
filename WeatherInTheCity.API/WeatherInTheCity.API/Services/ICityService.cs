using WeatherInTheCity.API.Entities;
using WeatherInTheCity.API.Models;

namespace WeatherInTheCity.API.Services
{
    public interface ICityService

    {
        public Task<List<CityDTO>>Rand4Cities();
        public Task<List<City>> Get4CitiesById(List<int> indices);
        public  Task<int> CountCities();



    }
}
