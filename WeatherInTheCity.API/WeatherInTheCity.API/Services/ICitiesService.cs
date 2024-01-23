namespace WeatherInTheCity.API.Services
{
    public interface ICitiesService

    {
        public string CorrectCity { get; }
        public List<string> FourCities { get; }
        public List<string> Rand4Cities();

    }
}
