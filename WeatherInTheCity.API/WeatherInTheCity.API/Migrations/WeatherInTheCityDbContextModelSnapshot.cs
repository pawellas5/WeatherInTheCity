﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherInTheCity.API.DbContexts;

#nullable disable

namespace WeatherInTheCity.API.Migrations
{
    [DbContext(typeof(WeatherInTheCityDbContext))]
    partial class WeatherInTheCityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WeatherInTheCity.API.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "Madrid",
                            CountryCode = "es",
                            CountryName = "Spain"
                        },
                        new
                        {
                            Id = 2,
                            CityName = "Barcelona",
                            CountryCode = "es",
                            CountryName = "Spain"
                        },
                        new
                        {
                            Id = 3,
                            CityName = "Bilbao",
                            CountryCode = "es",
                            CountryName = "Spain"
                        },
                        new
                        {
                            Id = 4,
                            CityName = "Alicante",
                            CountryCode = "es",
                            CountryName = "Spain"
                        },
                        new
                        {
                            Id = 5,
                            CityName = "Toronto",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 6,
                            CityName = "Niagara Falls",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 7,
                            CityName = "Ottawa",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 8,
                            CityName = "Edmonton",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 9,
                            CityName = "Vancouver",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 10,
                            CityName = "Quebec",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 11,
                            CityName = "Calgary",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 12,
                            CityName = "Yellowknife",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 13,
                            CityName = "Dead Man's Flats",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 14,
                            CityName = "Eyebrow",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 15,
                            CityName = "Moose Jaw",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 16,
                            CityName = "Come By Chance",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 17,
                            CityName = "London",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 18,
                            CityName = "London",
                            CountryCode = "gb",
                            CountryName = "Great Britain"
                        },
                        new
                        {
                            Id = 19,
                            CityName = "Birmingham",
                            CountryCode = "gb",
                            CountryName = "Great Britain"
                        },
                        new
                        {
                            Id = 20,
                            CityName = "Manchester",
                            CountryCode = "gb",
                            CountryName = "Great Britain"
                        },
                        new
                        {
                            Id = 21,
                            CityName = "Liverpool",
                            CountryCode = "gb",
                            CountryName = "Great Britain"
                        },
                        new
                        {
                            Id = 22,
                            CityName = "Edinburgh",
                            CountryCode = "gb",
                            CountryName = "Great Britain"
                        },
                        new
                        {
                            Id = 23,
                            CityName = "Nottingham",
                            CountryCode = "gb",
                            CountryName = "Great Britain"
                        },
                        new
                        {
                            Id = 24,
                            CityName = "Berlin",
                            CountryCode = "de",
                            CountryName = "Germany"
                        },
                        new
                        {
                            Id = 25,
                            CityName = "Monachium",
                            CountryCode = "de",
                            CountryName = "Germany"
                        },
                        new
                        {
                            Id = 26,
                            CityName = "Hamburg",
                            CountryCode = "de",
                            CountryName = "Germany"
                        },
                        new
                        {
                            Id = 27,
                            CityName = "Dusseldorf",
                            CountryCode = "de",
                            CountryName = "Germany"
                        },
                        new
                        {
                            Id = 28,
                            CityName = "Stockholm",
                            CountryCode = "se",
                            CountryName = "Sweden"
                        },
                        new
                        {
                            Id = 29,
                            CityName = "Malmo",
                            CountryCode = "se",
                            CountryName = "Sweden"
                        },
                        new
                        {
                            Id = 30,
                            CityName = "Gothenburg",
                            CountryCode = "se",
                            CountryName = "Sweden"
                        },
                        new
                        {
                            Id = 31,
                            CityName = "Helsinki",
                            CountryCode = "fi",
                            CountryName = "Finland"
                        },
                        new
                        {
                            Id = 32,
                            CityName = "Tampere",
                            CountryCode = "fi",
                            CountryName = "Finland"
                        },
                        new
                        {
                            Id = 33,
                            CityName = "Oslo",
                            CountryCode = "no",
                            CountryName = "Norway"
                        },
                        new
                        {
                            Id = 34,
                            CityName = "Bergen",
                            CountryCode = "no",
                            CountryName = "Norway"
                        },
                        new
                        {
                            Id = 35,
                            CityName = "Trondheim",
                            CountryCode = "no",
                            CountryName = "Norway"
                        },
                        new
                        {
                            Id = 36,
                            CityName = "Rome",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 37,
                            CityName = "Milan",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 38,
                            CityName = "Naples",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 39,
                            CityName = "Palermo",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 40,
                            CityName = "Florence",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 41,
                            CityName = "Bologna",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 42,
                            CityName = "Venice",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 43,
                            CityName = "Turin",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 44,
                            CityName = "Genoa",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 45,
                            CityName = "Dublin",
                            CountryCode = "ie",
                            CountryName = "Ireland"
                        },
                        new
                        {
                            Id = 46,
                            CityName = "Sydney",
                            CountryCode = "au",
                            CountryName = "Australia"
                        },
                        new
                        {
                            Id = 47,
                            CityName = "Melbourne",
                            CountryCode = "au",
                            CountryName = "Australia"
                        },
                        new
                        {
                            Id = 48,
                            CityName = "Adelaide",
                            CountryCode = "au",
                            CountryName = "Australia"
                        },
                        new
                        {
                            Id = 49,
                            CityName = "Paris",
                            CountryCode = "fr",
                            CountryName = "France"
                        },
                        new
                        {
                            Id = 50,
                            CityName = "Bordeaux",
                            CountryCode = "fr",
                            CountryName = "France"
                        },
                        new
                        {
                            Id = 51,
                            CityName = "Lyon",
                            CountryCode = "fr",
                            CountryName = "France"
                        },
                        new
                        {
                            Id = 52,
                            CityName = "Marseille",
                            CountryCode = "fr",
                            CountryName = "France"
                        },
                        new
                        {
                            Id = 53,
                            CityName = "Nice",
                            CountryCode = "fr",
                            CountryName = "France"
                        },
                        new
                        {
                            Id = 54,
                            CityName = "Athens",
                            CountryCode = "gr",
                            CountryName = "Greece"
                        },
                        new
                        {
                            Id = 55,
                            CityName = "Corfu",
                            CountryCode = "gr",
                            CountryName = "Greece"
                        },
                        new
                        {
                            Id = 56,
                            CityName = "Rhodes",
                            CountryCode = "gr",
                            CountryName = "Greece"
                        },
                        new
                        {
                            Id = 57,
                            CityName = "Copenhagen",
                            CountryCode = "dk",
                            CountryName = "Denmark"
                        },
                        new
                        {
                            Id = 58,
                            CityName = "Aarhus",
                            CountryCode = "dk",
                            CountryName = "Denmark"
                        },
                        new
                        {
                            Id = 59,
                            CityName = "International Falls",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 60,
                            CityName = "Barrow",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 61,
                            CityName = "New York",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 62,
                            CityName = "Los Angeles",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 63,
                            CityName = "Houston",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 64,
                            CityName = "Philadelphia",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 65,
                            CityName = "Chicago",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 66,
                            CityName = "Dallas",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 67,
                            CityName = "Seattle",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 68,
                            CityName = "San Francisco",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 69,
                            CityName = "Nashville",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 70,
                            CityName = "El Paso",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 71,
                            CityName = "Washington",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 72,
                            CityName = "Boston",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 73,
                            CityName = "Las Vegas",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 74,
                            CityName = "Detroit",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 75,
                            CityName = "Sacramento",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 76,
                            CityName = "Kansas City",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 77,
                            CityName = "Phoenix",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 78,
                            CityName = "Miami",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 79,
                            CityName = "Tampa",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 80,
                            CityName = "New Orleans",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 81,
                            CityName = "Honolulu",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 82,
                            CityName = "Cincinnati",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 83,
                            CityName = "Bangkok",
                            CountryCode = "th",
                            CountryName = "Thailand"
                        },
                        new
                        {
                            Id = 84,
                            CityName = "Kuala Lumpur",
                            CountryCode = "my",
                            CountryName = "Malaysia"
                        },
                        new
                        {
                            Id = 85,
                            CityName = "Warsaw",
                            CountryCode = "pl",
                            CountryName = "Poland"
                        },
                        new
                        {
                            Id = 86,
                            CityName = "Gdansk",
                            CountryCode = "pl",
                            CountryName = "Poland"
                        },
                        new
                        {
                            Id = 87,
                            CityName = "Cracow",
                            CountryCode = "pl",
                            CountryName = "Poland"
                        },
                        new
                        {
                            Id = 88,
                            CityName = "Wroclaw",
                            CountryCode = "pl",
                            CountryName = "Poland"
                        },
                        new
                        {
                            Id = 89,
                            CityName = "Ulaanbaatar",
                            CountryCode = "mn",
                            CountryName = "Mongolia"
                        },
                        new
                        {
                            Id = 90,
                            CityName = "Cairo",
                            CountryCode = "eg",
                            CountryName = "Egypt"
                        },
                        new
                        {
                            Id = 91,
                            CityName = "Baghdad",
                            CountryCode = "iq",
                            CountryName = "Iraq"
                        },
                        new
                        {
                            Id = 92,
                            CityName = "Kuwait City",
                            CountryCode = "kw",
                            CountryName = "Kuwait"
                        },
                        new
                        {
                            Id = 93,
                            CityName = "Comodoro Rivadavia",
                            CountryCode = "ar",
                            CountryName = "Argentina"
                        },
                        new
                        {
                            Id = 94,
                            CityName = "Buenos Aires",
                            CountryCode = "ar",
                            CountryName = "Argentina"
                        },
                        new
                        {
                            Id = 95,
                            CityName = "Mexico City",
                            CountryCode = "mx",
                            CountryName = "Mexico"
                        },
                        new
                        {
                            Id = 96,
                            CityName = "Beijing",
                            CountryCode = "cn",
                            CountryName = "China"
                        },
                        new
                        {
                            Id = 97,
                            CityName = "Shanghai",
                            CountryCode = "cn",
                            CountryName = "China"
                        },
                        new
                        {
                            Id = 98,
                            CityName = "Tokyo",
                            CountryCode = "jp",
                            CountryName = "Japan"
                        },
                        new
                        {
                            Id = 99,
                            CityName = "Sapporo",
                            CountryCode = "jp",
                            CountryName = "Japan"
                        },
                        new
                        {
                            Id = 100,
                            CityName = "Osaka",
                            CountryCode = "jp",
                            CountryName = "Japan"
                        },
                        new
                        {
                            Id = 101,
                            CityName = "Hiroshima",
                            CountryCode = "jp",
                            CountryName = "Japan"
                        },
                        new
                        {
                            Id = 102,
                            CityName = "Yokohama",
                            CountryCode = "jp",
                            CountryName = "Japan"
                        },
                        new
                        {
                            Id = 103,
                            CityName = "Istanbul",
                            CountryCode = "tr",
                            CountryName = "Turkey"
                        },
                        new
                        {
                            Id = 104,
                            CityName = "Seoul",
                            CountryCode = "kr",
                            CountryName = "South Korea"
                        },
                        new
                        {
                            Id = 105,
                            CityName = "Mumbai",
                            CountryCode = "in",
                            CountryName = "India"
                        },
                        new
                        {
                            Id = 106,
                            CityName = "Delhi",
                            CountryCode = "in",
                            CountryName = "India"
                        },
                        new
                        {
                            Id = 107,
                            CityName = "Lisbon",
                            CountryCode = "pt",
                            CountryName = "Portugal"
                        },
                        new
                        {
                            Id = 108,
                            CityName = "Jakarta",
                            CountryCode = "id",
                            CountryName = "Indonesia"
                        },
                        new
                        {
                            Id = 109,
                            CityName = "Singapore",
                            CountryCode = "sg",
                            CountryName = "Singapore"
                        },
                        new
                        {
                            Id = 110,
                            CityName = "Havana",
                            CountryCode = "cu",
                            CountryName = "Cuba"
                        },
                        new
                        {
                            Id = 111,
                            CityName = "Vienna",
                            CountryCode = "at",
                            CountryName = "Austria"
                        },
                        new
                        {
                            Id = 112,
                            CityName = "Graz",
                            CountryCode = "at",
                            CountryName = "Austria"
                        },
                        new
                        {
                            Id = 113,
                            CityName = "Linz",
                            CountryCode = "at",
                            CountryName = "Austria"
                        },
                        new
                        {
                            Id = 114,
                            CityName = "Innsbruck",
                            CountryCode = "at",
                            CountryName = "Austria"
                        },
                        new
                        {
                            Id = 115,
                            CityName = "Cape Town",
                            CountryCode = "za",
                            CountryName = "South Africa"
                        },
                        new
                        {
                            Id = 116,
                            CityName = "Nuuk",
                            CountryCode = "gl",
                            CountryName = "Greenland"
                        },
                        new
                        {
                            Id = 117,
                            CityName = "Vilnius",
                            CountryCode = "lt",
                            CountryName = "Lithuania"
                        },
                        new
                        {
                            Id = 118,
                            CityName = "Minsk",
                            CountryCode = "by",
                            CountryName = "Belarus"
                        },
                        new
                        {
                            Id = 119,
                            CityName = "Tallinn",
                            CountryCode = "ee",
                            CountryName = "Estonia"
                        },
                        new
                        {
                            Id = 120,
                            CityName = "Amman",
                            CountryCode = "jo",
                            CountryName = "Jordan"
                        },
                        new
                        {
                            Id = 121,
                            CityName = "Kingston",
                            CountryCode = "jm",
                            CountryName = "Jamaica"
                        },
                        new
                        {
                            Id = 122,
                            CityName = "Port Antonio",
                            CountryCode = "jm",
                            CountryName = "Jamaica"
                        },
                        new
                        {
                            Id = 123,
                            CityName = "Reykjavik",
                            CountryCode = "is",
                            CountryName = "Islandia"
                        },
                        new
                        {
                            Id = 124,
                            CityName = "Moscow",
                            CountryCode = "ru",
                            CountryName = "Russia"
                        },
                        new
                        {
                            Id = 125,
                            CityName = "Norilsk",
                            CountryCode = "ru",
                            CountryName = "Russia"
                        },
                        new
                        {
                            Id = 126,
                            CityName = "Yakutsk",
                            CountryCode = "ru",
                            CountryName = "Russia"
                        },
                        new
                        {
                            Id = 127,
                            CityName = "Kyiv",
                            CountryCode = "ua",
                            CountryName = "ukraine"
                        },
                        new
                        {
                            Id = 128,
                            CityName = "Kharkiv",
                            CountryCode = "ua",
                            CountryName = "ukraine"
                        },
                        new
                        {
                            Id = 129,
                            CityName = "Odesa",
                            CountryCode = "ua",
                            CountryName = "Ukraine"
                        },
                        new
                        {
                            Id = 130,
                            CityName = "Riga",
                            CountryCode = "lv",
                            CountryName = "Latvia"
                        },
                        new
                        {
                            Id = 131,
                            CityName = "Bucharest",
                            CountryCode = "ro",
                            CountryName = "Romania"
                        },
                        new
                        {
                            Id = 132,
                            CityName = "Bern",
                            CountryCode = "ch",
                            CountryName = "Switzerland"
                        },
                        new
                        {
                            Id = 133,
                            CityName = "Prague",
                            CountryCode = "cz",
                            CountryName = "Czech Republic"
                        },
                        new
                        {
                            Id = 134,
                            CityName = "Sarajevo",
                            CountryCode = "ba",
                            CountryName = "Bosnia and Herzegovina"
                        },
                        new
                        {
                            Id = 135,
                            CityName = "Budapest",
                            CountryCode = "hu",
                            CountryName = "Hungary"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
