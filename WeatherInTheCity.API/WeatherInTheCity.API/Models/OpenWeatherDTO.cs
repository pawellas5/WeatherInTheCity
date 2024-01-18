using System;
using System.Runtime.CompilerServices;

namespace WeatherInTheCity.API.Models
{
    public class OpenWeatherDTO
    {
        public string Name { get; set; }
        public Sys Sys { get; set; }
        public Main Main { get; set; }
        public List<Weather> Weather { get; set; }
        public Wind Wind { get; set; }
        public int Dt { get; set; }
        public int TimeZone { get; set; }

    }

    public class Main
    {
        public float Temp { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }

    }
    public class Weather
    {
        public string Description { get; set; }
    }
    public class Wind
    {
        public float Speed { get; set; }
    }

    public class Sys
    {
        public string Country { get; set; }
    }
}




