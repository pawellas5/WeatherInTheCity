namespace WeatherInTheCity.API.Services
{
    public class CitiesService : ICitiesService
    {
        private readonly List<string> cities = new List<string>() { "Barcelona", "Toronto", "Calgary", "Berlin", "Zakopane", "Dublin", "Sydney", "Paris", "London" };

        private string correctCity = "";
        private List<string> fourCities = new List<string>();

        public string CorrectCity { get { return correctCity; } }
        public List<string> FourCities { get { return fourCities; } }

        /// <summary>
        /// Randomizes four possible cities for guessing the weather and determines the one that is correct.
        /// </summary>
        /// <returns>Returns a list of four cities.</returns>
        public List<string> Rand4Cities()
        {

            var fourCitiesInit = new List<string>();

            do
            {
                var city = cities[new Random().Next(cities.Count)];
                if (fourCitiesInit.Contains(city)) continue;
                fourCitiesInit.Add(city);
            } while (fourCitiesInit.Count < 4);

            correctCity = fourCitiesInit[0];
            fourCities = fourCitiesInit.OrderBy(c => c.GetHashCode()).ToList();

            return fourCities;
        }

    }


}
