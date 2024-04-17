using Microsoft.EntityFrameworkCore;
using WeatherInTheCity.API.DbContexts;
using WeatherInTheCity.API.Entities;
using WeatherInTheCity.API.Models;

namespace WeatherInTheCity.API.Services
{
    public class CityService : ICityService
    {
        private readonly WeatherInTheCityDbContext _context;
        public CityService(WeatherInTheCityDbContext context)
        {
            _context = context;

        }
       
        /// <summary>
        /// Randomizes four possible cities for guessing the weather and determines the one that is correct.
        /// </summary>
        /// <returns>Returns a list of four cities.</returns>
        public async Task<List<CityDTO>> Rand4Cities()
        {
            var randIndices = new List<int>();
            var possibleCitiesInit = new List<CityDTO>();
            var citiesCount = await CountCities();

            do
            {
                var index = new Random().Next(1, citiesCount + 1);
                if (randIndices.Any(c => c == index)) continue;
                randIndices.Add(index);
            } while (randIndices.Count < 4);

             (await Get4CitiesById(randIndices))
                 .ForEach(c => possibleCitiesInit.Add(new CityDTO() { CityName = c.CityName, CountryName = c.CountryName , CountryCode = c.CountryCode}));

            

            return possibleCitiesInit;

        }

        public async Task<List<City>> Get4CitiesById(List<int> indices)
        {
             int n = 0;
            var cities = await _context.Cities
                    .FromSql($"SELECT * FROM \"Cities\" WHERE \"Id\" IN({indices[n++]},{indices[n++]},{indices[n++]},{indices[n++]});")
                    .ToListAsync();

            if (cities != null) return cities;

            throw new Exception("Cities not found");

        }

        public async Task<int> CountCities()
        {
            var count = await _context.Cities.CountAsync();

            return count;

        }


    }
}
