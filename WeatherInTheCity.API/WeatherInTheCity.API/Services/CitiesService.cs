using WeatherInTheCity.API.Entities;

namespace WeatherInTheCity.API.Services
{
    public class CitiesService : ICitiesService
    {
        private readonly List<City> cities = new List<City>() {
            new City(){Id = 1,CityName = "barcelona", CountryName = "spain", CountryCode = "es"},
            new City(){Id = 2,CityName = "toronto", CountryName = "canada", CountryCode = "ca"},
            new City(){Id = 3,CityName = "calgary", CountryName = "canada", CountryCode = "ca"},
            new City(){Id = 4,CityName = "london", CountryName = "great britain", CountryCode = "gb"},
            new City(){Id = 5,CityName = "berlin", CountryName = "germany", CountryCode = "de"},
            new City(){Id = 6,CityName = "zakopane", CountryName = "poland", CountryCode = "pl"},
            new City(){Id = 7,CityName = "dublin", CountryName = "ireland", CountryCode = "ie"},
            new City(){Id = 8,CityName = "sydney", CountryName = "australia", CountryCode = "au"},
            new City(){Id = 9,CityName = "paris", CountryName = "france", CountryCode = "fr"},
            new City(){Id = 10,CityName = "london", CountryName = "canada", CountryCode = "ca"},
        };

        private City correctCity = new City();
        private List<City> possibleCities = new List<City>();

        public City CorrectCity { get { return correctCity; } }
        public List<City> PossibleCities { get { return possibleCities; } }

        /// <summary>
        /// Randomizes four possible cities for guessing the weather and determines the one that is correct.
        /// </summary>
        /// <returns>Returns a list of four cities.</returns>
        public void Rand4Cities()
        {

            var possibleCitiesInit = new List<City>();

            do
            {
                var city = cities[new Random().Next(cities.Count)];
                if (possibleCitiesInit.Any(c => c.Id == city.Id)) continue;
                possibleCitiesInit.Add(city);
            } while (possibleCitiesInit.Count < 4);

            correctCity = possibleCitiesInit[0];
            possibleCities = possibleCitiesInit.OrderBy(c => c.CityName.GetHashCode()).ToList();

        }

    }


}
