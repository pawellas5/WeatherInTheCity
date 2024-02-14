using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Polly;
using System.Reflection.Metadata.Ecma335;
using WeatherInTheCity.API.DbContexts;
using WeatherInTheCity.API.Entities;

namespace WeatherInTheCity.API.Services
{
    public class CityService : ICityService
    {
        private readonly WeatherInTheCityDbContext _context;
        public CityService(WeatherInTheCityDbContext context)
        {
            _context = context;

        }

        private City correctCity = new City();
        private List<City> possibleCities = new List<City>();

        public City CorrectCity { get { return correctCity; } }
        public List<City> PossibleCities { get { return possibleCities; } }
       

        /// <summary>
        /// Randomizes four possible cities for guessing the weather and determines the one that is correct.
        /// </summary>
        /// <returns>Returns a list of four cities.</returns>
        public async Task Rand4Cities()
        {
            var randIndices = new List<int>();
            var possibleCitiesInit = new List<City>();

            do
            {
                var index = new Random().Next(await CountCities());
                if (randIndices.Any(c => c == index)) continue;
                randIndices.Add(index);
            } while (randIndices.Count < 4);

            possibleCitiesInit = await Get4CitiesById(randIndices);
            correctCity = possibleCitiesInit[0];
            possibleCities = possibleCitiesInit.OrderBy(c => c.CityName.GetHashCode()).ToList();
            
        }

        public async Task<List<City>> Get4CitiesById(List<int> indices)
        {
            int n = 0;
            var cities = await _context.Cities
                    .FromSql($"SELECT * FROM dbo.Cities WHERE Id IN({indices[n++]},{indices[n++]},{indices[n++]},{indices[n++]});")
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
