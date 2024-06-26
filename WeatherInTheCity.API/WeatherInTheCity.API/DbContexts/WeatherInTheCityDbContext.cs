﻿using Microsoft.EntityFrameworkCore;
using WeatherInTheCity.API.Entities;

namespace WeatherInTheCity.API.DbContexts
{
    public class WeatherInTheCityDbContext : DbContext
    {
        public WeatherInTheCityDbContext(DbContextOptions<WeatherInTheCityDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            int id = 1;

            modelBuilder.Entity<City>().HasData(new List<City>() {

                new City() { Id = id++, CityName = "Madrid", CountryName = "Spain", CountryCode = "es" },
                new City() { Id = id++, CityName = "Barcelona", CountryName = "Spain", CountryCode = "es" },
                new City() { Id = id++, CityName = "Bilbao", CountryName = "Spain", CountryCode = "es" },
                new City() { Id = id++, CityName = "Alicante", CountryName = "Spain", CountryCode = "es" },
                new City() { Id = id++, CityName = "Toronto", CountryName = "Canada", CountryCode = "ca" },
                new City() { Id = id++, CityName = "Ottawa", CountryName = "Canada", CountryCode = "ca" },
                new City() { Id = id++, CityName = "Edmonton", CountryName = "Canada", CountryCode = "ca" },
                new City() { Id = id++, CityName = "Vancouver", CountryName = "Canada", CountryCode = "ca" },
                new City() { Id = id++, CityName = "Quebec", CountryName = "Canada", CountryCode = "ca" },
                new City() { Id = id++, CityName = "Calgary", CountryName = "Canada", CountryCode = "ca" },
                new City() { Id = id++, CityName = "Yellowknife", CountryName = "Canada", CountryCode = "ca" },
                new City() { Id = id++, CityName = "Eyebrow", CountryName = "Canada", CountryCode = "ca" },
                new City() { Id = id++, CityName = "Moose Jaw", CountryName = "Canada", CountryCode = "ca" },
                new City() { Id = id++, CityName = "London", CountryName = "Canada", CountryCode = "ca" },
                new City() { Id = id++, CityName = "London", CountryName = "Great Britain", CountryCode = "gb" },
                new City() { Id = id++, CityName = "Birmingham", CountryName = "Great Britain", CountryCode = "gb" },
                new City() { Id = id++, CityName = "Manchester", CountryName = "Great Britain", CountryCode = "gb" },
                new City() { Id = id++, CityName = "Liverpool", CountryName = "Great Britain", CountryCode = "gb" },
                new City() { Id = id++, CityName = "Edinburgh", CountryName = "Great Britain", CountryCode = "gb" },
                new City() { Id = id++, CityName = "Nottingham", CountryName = "Great Britain", CountryCode = "gb" },
                new City() { Id = id++, CityName = "Berlin", CountryName = "Germany", CountryCode = "de" },
                new City() { Id = id++, CityName = "Monachium", CountryName = "Germany", CountryCode = "de" },
                new City() { Id = id++, CityName = "Hamburg", CountryName = "Germany", CountryCode = "de" },
                new City() { Id = id++, CityName = "Dusseldorf", CountryName = "Germany", CountryCode = "de" },
                new City() { Id = id++, CityName = "Stockholm", CountryName = "Sweden", CountryCode = "se" },
                new City() { Id = id++, CityName = "Malmo", CountryName = "Sweden", CountryCode = "se" },
                new City() { Id = id++, CityName = "Gothenburg", CountryName = "Sweden", CountryCode = "se" },
                new City() { Id = id++, CityName = "Helsinki", CountryName = "Finland", CountryCode = "fi" },
                new City() { Id = id++, CityName = "Tampere", CountryName = "Finland", CountryCode = "fi" },
                new City() { Id = id++, CityName = "Oslo", CountryName = "Norway", CountryCode = "no" },
                new City() { Id = id++, CityName = "Bergen", CountryName = "Norway", CountryCode = "no" },
                new City() { Id = id++, CityName = "Trondheim", CountryName = "Norway", CountryCode = "no" },
                new City() { Id = id++, CityName = "Rome", CountryName = "Italy", CountryCode = "it" },
                new City() { Id = id++, CityName = "Milan", CountryName = "Italy", CountryCode = "it" },
                new City() { Id = id++, CityName = "Naples", CountryName = "Italy", CountryCode = "it" },
                new City() { Id = id++, CityName = "Palermo", CountryName = "Italy", CountryCode = "it" },
                new City() { Id = id++, CityName = "Florence", CountryName = "Italy", CountryCode = "it" },
                new City() { Id = id++, CityName = "Bologna", CountryName = "Italy", CountryCode = "it" },
                new City() { Id = id++, CityName = "Venice", CountryName = "Italy", CountryCode = "it" },
                new City() { Id = id++, CityName = "Turin", CountryName = "Italy", CountryCode = "it" },
                new City() { Id = id++, CityName = "Genoa", CountryName = "Italy", CountryCode = "it" },
                new City() { Id = id++, CityName = "Dublin", CountryName = "Ireland", CountryCode = "ie" },
                new City() { Id = id++, CityName = "Sydney", CountryName = "Australia", CountryCode = "au" },
                new City() { Id = id++, CityName = "Melbourne", CountryName = "Australia", CountryCode = "au" },
                new City() { Id = id++, CityName = "Adelaide", CountryName = "Australia", CountryCode = "au" },
                new City() { Id = id++, CityName = "Paris", CountryName = "France", CountryCode = "fr" },
                new City() { Id = id++, CityName = "Bordeaux", CountryName = "France", CountryCode = "fr" },
                new City() { Id = id++, CityName = "Lyon", CountryName = "France", CountryCode = "fr" },
                new City() { Id = id++, CityName = "Marseille", CountryName = "France", CountryCode = "fr" },
                new City() { Id = id++, CityName = "Nice", CountryName = "France", CountryCode = "fr" },
                new City() { Id = id++, CityName = "Athens", CountryName = "Greece", CountryCode = "gr" },
                new City() { Id = id++, CityName = "Corfu", CountryName = "Greece", CountryCode = "gr" },
                new City() { Id = id++, CityName = "Rhodes", CountryName = "Greece", CountryCode = "gr" },
                new City() { Id = id++, CityName = "Copenhagen", CountryName = "Denmark", CountryCode = "dk" },
                new City() { Id = id++, CityName = "Aarhus", CountryName = "Denmark", CountryCode = "dk" },
                new City() { Id = id++, CityName = "Barrow", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "New York", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Los Angeles", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Houston", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Philadelphia", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Chicago", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Dallas", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Seattle", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "San Francisco", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Nashville", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "El Paso", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Washington", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Boston", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Las Vegas", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Detroit", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Sacramento", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Kansas City", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Phoenix", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Miami", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Tampa", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "New Orleans", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Honolulu", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Cincinnati", CountryName = "USA", CountryCode = "us" },
                new City() { Id = id++, CityName = "Bangkok", CountryName = "Thailand", CountryCode = "th" },
                new City() { Id = id++, CityName = "Kuala Lumpur", CountryName = "Malaysia", CountryCode = "my" },
                new City() { Id = id++, CityName = "Warszawa", CountryName = "Poland", CountryCode = "pl" },
                new City() { Id = id++, CityName = "Gdańsk", CountryName = "Poland", CountryCode = "pl" },
                new City() { Id = id++, CityName = "Kraków", CountryName = "Poland", CountryCode = "pl" },
                new City() { Id = id++, CityName = "Wrocław", CountryName = "Poland", CountryCode = "pl" },
                new City() { Id = id++, CityName = "Ulaanbaatar", CountryName = "Mongolia", CountryCode = "mn" },
                new City() { Id = id++, CityName = "Cairo", CountryName = "Egypt", CountryCode = "eg" },
                new City() { Id = id++, CityName = "Baghdad", CountryName = "Iraq", CountryCode = "iq" },
                new City() { Id = id++, CityName = "Kuwait City", CountryName = "Kuwait", CountryCode = "kw" },
                new City() { Id = id++, CityName = "Buenos Aires", CountryName = "Argentina", CountryCode = "ar" },
                new City() { Id = id++, CityName = "Mexico City", CountryName = "Mexico", CountryCode = "mx" },
                new City() { Id = id++, CityName = "Beijing", CountryName = "China", CountryCode = "cn" },
                new City() { Id = id++, CityName = "Shanghai", CountryName = "China", CountryCode = "cn" },
                new City() { Id = id++, CityName = "Tokyo", CountryName = "Japan", CountryCode = "jp" },
                new City() { Id = id++, CityName = "Sapporo", CountryName = "Japan", CountryCode = "jp" },
                new City() { Id = id++, CityName = "Osaka", CountryName = "Japan", CountryCode = "jp" },
                new City() { Id = id++, CityName = "Hiroshima", CountryName = "Japan", CountryCode = "jp" },
                new City() { Id = id++, CityName = "Yokohama", CountryName = "Japan", CountryCode = "jp" },
                new City() { Id = id++, CityName = "Istanbul", CountryName = "Turkey", CountryCode = "tr" },
                new City() { Id = id++, CityName = "Seoul", CountryName = "South Korea", CountryCode = "kr" },
                new City() { Id = id++, CityName = "Mumbai", CountryName = "India", CountryCode = "in" },
                new City() { Id = id++, CityName = "Delhi", CountryName = "India", CountryCode = "in" },
                new City() { Id = id++, CityName = "Lisbon", CountryName = "Portugal", CountryCode = "pt" },
                new City() { Id = id++, CityName = "Jakarta", CountryName = "Indonesia", CountryCode = "id" },
                new City() { Id = id++, CityName = "Singapore", CountryName = "Singapore", CountryCode = "sg" },
                new City() { Id = id++, CityName = "Havana", CountryName = "Cuba", CountryCode = "cu" },
                new City() { Id = id++, CityName = "Vienna", CountryName = "Austria", CountryCode = "at" },
                new City() { Id = id++, CityName = "Graz", CountryName = "Austria", CountryCode = "at" },
                new City() { Id = id++, CityName = "Linz", CountryName = "Austria", CountryCode = "at" },
                new City() { Id = id++, CityName = "Innsbruck", CountryName = "Austria", CountryCode = "at" },
                new City() { Id = id++, CityName = "Cape Town", CountryName = "South Africa", CountryCode = "za" },
                new City() { Id = id++, CityName = "Nuuk", CountryName = "Greenland", CountryCode = "gl" },
                new City() { Id = id++, CityName = "Vilnius", CountryName = "Lithuania", CountryCode = "lt" },
                new City() { Id = id++, CityName = "Minsk", CountryName = "Belarus", CountryCode = "by" },
                new City() { Id = id++, CityName = "Tallinn", CountryName = "Estonia", CountryCode = "ee" },
                new City() { Id = id++, CityName = "Amman", CountryName = "Jordan", CountryCode = "jo" },
                new City() { Id = id++, CityName = "Kingston", CountryName = "Jamaica", CountryCode = "jm" },
                new City() { Id = id++, CityName = "Port Antonio", CountryName = "Jamaica", CountryCode = "jm" },
                new City() { Id = id++, CityName = "Reykjavik", CountryName = "Iceland", CountryCode = "is" },
                new City() { Id = id++, CityName = "Moscow", CountryName = "Russia", CountryCode = "ru" },
                new City() { Id = id++, CityName = "Norilsk", CountryName = "Russia", CountryCode = "ru" },
                new City() { Id = id++, CityName = "Yakutsk", CountryName = "Russia", CountryCode = "ru" },
                new City() { Id = id++, CityName = "Kyiv", CountryName = "ukraine", CountryCode = "ua" },
                new City() { Id = id++, CityName = "Kharkiv", CountryName = "ukraine", CountryCode = "ua" },
                new City() { Id = id++, CityName = "Odesa", CountryName = "Ukraine", CountryCode = "ua" },
                new City() { Id = id++, CityName = "Riga", CountryName = "Latvia", CountryCode = "lv" },
                new City() { Id = id++, CityName = "Bucharest", CountryName = "Romania", CountryCode = "ro" },
                new City() { Id = id++, CityName = "Bern", CountryName = "Switzerland", CountryCode = "ch" },
                new City() { Id = id++, CityName = "Prague", CountryName = "Czech Republic", CountryCode = "cz" },
                new City() { Id = id++, CityName = "Budapest", CountryName = "Hungary", CountryCode = "hu" }
        });


        }

        public DbSet<City> Cities { get; set; }
        public DbSet<UserStats> UserStats { get; set; }
        public DbSet<GameFlow> GameFlows { get; set; }

    }
}
