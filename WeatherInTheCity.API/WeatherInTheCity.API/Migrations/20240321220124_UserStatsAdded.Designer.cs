﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherInTheCity.API.DbContexts;

#nullable disable

namespace WeatherInTheCity.API.Migrations
{
    [DbContext(typeof(WeatherInTheCityDbContext))]
    [Migration("20240321220124_UserStatsAdded")]
    partial class UserStatsAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            CityName = "Ottawa",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 7,
                            CityName = "Edmonton",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 8,
                            CityName = "Vancouver",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 9,
                            CityName = "Quebec",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 10,
                            CityName = "Calgary",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 11,
                            CityName = "Yellowknife",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 12,
                            CityName = "Eyebrow",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 13,
                            CityName = "Moose Jaw",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 14,
                            CityName = "London",
                            CountryCode = "ca",
                            CountryName = "Canada"
                        },
                        new
                        {
                            Id = 15,
                            CityName = "London",
                            CountryCode = "gb",
                            CountryName = "Great Britain"
                        },
                        new
                        {
                            Id = 16,
                            CityName = "Birmingham",
                            CountryCode = "gb",
                            CountryName = "Great Britain"
                        },
                        new
                        {
                            Id = 17,
                            CityName = "Manchester",
                            CountryCode = "gb",
                            CountryName = "Great Britain"
                        },
                        new
                        {
                            Id = 18,
                            CityName = "Liverpool",
                            CountryCode = "gb",
                            CountryName = "Great Britain"
                        },
                        new
                        {
                            Id = 19,
                            CityName = "Edinburgh",
                            CountryCode = "gb",
                            CountryName = "Great Britain"
                        },
                        new
                        {
                            Id = 20,
                            CityName = "Nottingham",
                            CountryCode = "gb",
                            CountryName = "Great Britain"
                        },
                        new
                        {
                            Id = 21,
                            CityName = "Berlin",
                            CountryCode = "de",
                            CountryName = "Germany"
                        },
                        new
                        {
                            Id = 22,
                            CityName = "Monachium",
                            CountryCode = "de",
                            CountryName = "Germany"
                        },
                        new
                        {
                            Id = 23,
                            CityName = "Hamburg",
                            CountryCode = "de",
                            CountryName = "Germany"
                        },
                        new
                        {
                            Id = 24,
                            CityName = "Dusseldorf",
                            CountryCode = "de",
                            CountryName = "Germany"
                        },
                        new
                        {
                            Id = 25,
                            CityName = "Stockholm",
                            CountryCode = "se",
                            CountryName = "Sweden"
                        },
                        new
                        {
                            Id = 26,
                            CityName = "Malmo",
                            CountryCode = "se",
                            CountryName = "Sweden"
                        },
                        new
                        {
                            Id = 27,
                            CityName = "Gothenburg",
                            CountryCode = "se",
                            CountryName = "Sweden"
                        },
                        new
                        {
                            Id = 28,
                            CityName = "Helsinki",
                            CountryCode = "fi",
                            CountryName = "Finland"
                        },
                        new
                        {
                            Id = 29,
                            CityName = "Tampere",
                            CountryCode = "fi",
                            CountryName = "Finland"
                        },
                        new
                        {
                            Id = 30,
                            CityName = "Oslo",
                            CountryCode = "no",
                            CountryName = "Norway"
                        },
                        new
                        {
                            Id = 31,
                            CityName = "Bergen",
                            CountryCode = "no",
                            CountryName = "Norway"
                        },
                        new
                        {
                            Id = 32,
                            CityName = "Trondheim",
                            CountryCode = "no",
                            CountryName = "Norway"
                        },
                        new
                        {
                            Id = 33,
                            CityName = "Rome",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 34,
                            CityName = "Milan",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 35,
                            CityName = "Naples",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 36,
                            CityName = "Palermo",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 37,
                            CityName = "Florence",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 38,
                            CityName = "Bologna",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 39,
                            CityName = "Venice",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 40,
                            CityName = "Turin",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 41,
                            CityName = "Genoa",
                            CountryCode = "it",
                            CountryName = "Italy"
                        },
                        new
                        {
                            Id = 42,
                            CityName = "Dublin",
                            CountryCode = "ie",
                            CountryName = "Ireland"
                        },
                        new
                        {
                            Id = 43,
                            CityName = "Sydney",
                            CountryCode = "au",
                            CountryName = "Australia"
                        },
                        new
                        {
                            Id = 44,
                            CityName = "Melbourne",
                            CountryCode = "au",
                            CountryName = "Australia"
                        },
                        new
                        {
                            Id = 45,
                            CityName = "Adelaide",
                            CountryCode = "au",
                            CountryName = "Australia"
                        },
                        new
                        {
                            Id = 46,
                            CityName = "Paris",
                            CountryCode = "fr",
                            CountryName = "France"
                        },
                        new
                        {
                            Id = 47,
                            CityName = "Bordeaux",
                            CountryCode = "fr",
                            CountryName = "France"
                        },
                        new
                        {
                            Id = 48,
                            CityName = "Lyon",
                            CountryCode = "fr",
                            CountryName = "France"
                        },
                        new
                        {
                            Id = 49,
                            CityName = "Marseille",
                            CountryCode = "fr",
                            CountryName = "France"
                        },
                        new
                        {
                            Id = 50,
                            CityName = "Nice",
                            CountryCode = "fr",
                            CountryName = "France"
                        },
                        new
                        {
                            Id = 51,
                            CityName = "Athens",
                            CountryCode = "gr",
                            CountryName = "Greece"
                        },
                        new
                        {
                            Id = 52,
                            CityName = "Corfu",
                            CountryCode = "gr",
                            CountryName = "Greece"
                        },
                        new
                        {
                            Id = 53,
                            CityName = "Rhodes",
                            CountryCode = "gr",
                            CountryName = "Greece"
                        },
                        new
                        {
                            Id = 54,
                            CityName = "Copenhagen",
                            CountryCode = "dk",
                            CountryName = "Denmark"
                        },
                        new
                        {
                            Id = 55,
                            CityName = "Aarhus",
                            CountryCode = "dk",
                            CountryName = "Denmark"
                        },
                        new
                        {
                            Id = 56,
                            CityName = "Barrow",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 57,
                            CityName = "New York",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 58,
                            CityName = "Los Angeles",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 59,
                            CityName = "Houston",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 60,
                            CityName = "Philadelphia",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 61,
                            CityName = "Chicago",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 62,
                            CityName = "Dallas",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 63,
                            CityName = "Seattle",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 64,
                            CityName = "San Francisco",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 65,
                            CityName = "Nashville",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 66,
                            CityName = "El Paso",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 67,
                            CityName = "Washington",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 68,
                            CityName = "Boston",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 69,
                            CityName = "Las Vegas",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 70,
                            CityName = "Detroit",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 71,
                            CityName = "Sacramento",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 72,
                            CityName = "Kansas City",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 73,
                            CityName = "Phoenix",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 74,
                            CityName = "Miami",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 75,
                            CityName = "Tampa",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 76,
                            CityName = "New Orleans",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 77,
                            CityName = "Honolulu",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 78,
                            CityName = "Cincinnati",
                            CountryCode = "us",
                            CountryName = "USA"
                        },
                        new
                        {
                            Id = 79,
                            CityName = "Bangkok",
                            CountryCode = "th",
                            CountryName = "Thailand"
                        },
                        new
                        {
                            Id = 80,
                            CityName = "Kuala Lumpur",
                            CountryCode = "my",
                            CountryName = "Malaysia"
                        },
                        new
                        {
                            Id = 81,
                            CityName = "Warszawa",
                            CountryCode = "pl",
                            CountryName = "Poland"
                        },
                        new
                        {
                            Id = 82,
                            CityName = "Gdańsk",
                            CountryCode = "pl",
                            CountryName = "Poland"
                        },
                        new
                        {
                            Id = 83,
                            CityName = "Kraków",
                            CountryCode = "pl",
                            CountryName = "Poland"
                        },
                        new
                        {
                            Id = 84,
                            CityName = "Wrocław",
                            CountryCode = "pl",
                            CountryName = "Poland"
                        },
                        new
                        {
                            Id = 85,
                            CityName = "Ulaanbaatar",
                            CountryCode = "mn",
                            CountryName = "Mongolia"
                        },
                        new
                        {
                            Id = 86,
                            CityName = "Cairo",
                            CountryCode = "eg",
                            CountryName = "Egypt"
                        },
                        new
                        {
                            Id = 87,
                            CityName = "Baghdad",
                            CountryCode = "iq",
                            CountryName = "Iraq"
                        },
                        new
                        {
                            Id = 88,
                            CityName = "Kuwait City",
                            CountryCode = "kw",
                            CountryName = "Kuwait"
                        },
                        new
                        {
                            Id = 89,
                            CityName = "Buenos Aires",
                            CountryCode = "ar",
                            CountryName = "Argentina"
                        },
                        new
                        {
                            Id = 90,
                            CityName = "Mexico City",
                            CountryCode = "mx",
                            CountryName = "Mexico"
                        },
                        new
                        {
                            Id = 91,
                            CityName = "Beijing",
                            CountryCode = "cn",
                            CountryName = "China"
                        },
                        new
                        {
                            Id = 92,
                            CityName = "Shanghai",
                            CountryCode = "cn",
                            CountryName = "China"
                        },
                        new
                        {
                            Id = 93,
                            CityName = "Tokyo",
                            CountryCode = "jp",
                            CountryName = "Japan"
                        },
                        new
                        {
                            Id = 94,
                            CityName = "Sapporo",
                            CountryCode = "jp",
                            CountryName = "Japan"
                        },
                        new
                        {
                            Id = 95,
                            CityName = "Osaka",
                            CountryCode = "jp",
                            CountryName = "Japan"
                        },
                        new
                        {
                            Id = 96,
                            CityName = "Hiroshima",
                            CountryCode = "jp",
                            CountryName = "Japan"
                        },
                        new
                        {
                            Id = 97,
                            CityName = "Yokohama",
                            CountryCode = "jp",
                            CountryName = "Japan"
                        },
                        new
                        {
                            Id = 98,
                            CityName = "Istanbul",
                            CountryCode = "tr",
                            CountryName = "Turkey"
                        },
                        new
                        {
                            Id = 99,
                            CityName = "Seoul",
                            CountryCode = "kr",
                            CountryName = "South Korea"
                        },
                        new
                        {
                            Id = 100,
                            CityName = "Mumbai",
                            CountryCode = "in",
                            CountryName = "India"
                        },
                        new
                        {
                            Id = 101,
                            CityName = "Delhi",
                            CountryCode = "in",
                            CountryName = "India"
                        },
                        new
                        {
                            Id = 102,
                            CityName = "Lisbon",
                            CountryCode = "pt",
                            CountryName = "Portugal"
                        },
                        new
                        {
                            Id = 103,
                            CityName = "Jakarta",
                            CountryCode = "id",
                            CountryName = "Indonesia"
                        },
                        new
                        {
                            Id = 104,
                            CityName = "Singapore",
                            CountryCode = "sg",
                            CountryName = "Singapore"
                        },
                        new
                        {
                            Id = 105,
                            CityName = "Havana",
                            CountryCode = "cu",
                            CountryName = "Cuba"
                        },
                        new
                        {
                            Id = 106,
                            CityName = "Vienna",
                            CountryCode = "at",
                            CountryName = "Austria"
                        },
                        new
                        {
                            Id = 107,
                            CityName = "Graz",
                            CountryCode = "at",
                            CountryName = "Austria"
                        },
                        new
                        {
                            Id = 108,
                            CityName = "Linz",
                            CountryCode = "at",
                            CountryName = "Austria"
                        },
                        new
                        {
                            Id = 109,
                            CityName = "Innsbruck",
                            CountryCode = "at",
                            CountryName = "Austria"
                        },
                        new
                        {
                            Id = 110,
                            CityName = "Cape Town",
                            CountryCode = "za",
                            CountryName = "South Africa"
                        },
                        new
                        {
                            Id = 111,
                            CityName = "Nuuk",
                            CountryCode = "gl",
                            CountryName = "Greenland"
                        },
                        new
                        {
                            Id = 112,
                            CityName = "Vilnius",
                            CountryCode = "lt",
                            CountryName = "Lithuania"
                        },
                        new
                        {
                            Id = 113,
                            CityName = "Minsk",
                            CountryCode = "by",
                            CountryName = "Belarus"
                        },
                        new
                        {
                            Id = 114,
                            CityName = "Tallinn",
                            CountryCode = "ee",
                            CountryName = "Estonia"
                        },
                        new
                        {
                            Id = 115,
                            CityName = "Amman",
                            CountryCode = "jo",
                            CountryName = "Jordan"
                        },
                        new
                        {
                            Id = 116,
                            CityName = "Kingston",
                            CountryCode = "jm",
                            CountryName = "Jamaica"
                        },
                        new
                        {
                            Id = 117,
                            CityName = "Port Antonio",
                            CountryCode = "jm",
                            CountryName = "Jamaica"
                        },
                        new
                        {
                            Id = 118,
                            CityName = "Reykjavik",
                            CountryCode = "is",
                            CountryName = "Iceland"
                        },
                        new
                        {
                            Id = 119,
                            CityName = "Moscow",
                            CountryCode = "ru",
                            CountryName = "Russia"
                        },
                        new
                        {
                            Id = 120,
                            CityName = "Norilsk",
                            CountryCode = "ru",
                            CountryName = "Russia"
                        },
                        new
                        {
                            Id = 121,
                            CityName = "Yakutsk",
                            CountryCode = "ru",
                            CountryName = "Russia"
                        },
                        new
                        {
                            Id = 122,
                            CityName = "Kyiv",
                            CountryCode = "ua",
                            CountryName = "ukraine"
                        },
                        new
                        {
                            Id = 123,
                            CityName = "Kharkiv",
                            CountryCode = "ua",
                            CountryName = "ukraine"
                        },
                        new
                        {
                            Id = 124,
                            CityName = "Odesa",
                            CountryCode = "ua",
                            CountryName = "Ukraine"
                        },
                        new
                        {
                            Id = 125,
                            CityName = "Riga",
                            CountryCode = "lv",
                            CountryName = "Latvia"
                        },
                        new
                        {
                            Id = 126,
                            CityName = "Bucharest",
                            CountryCode = "ro",
                            CountryName = "Romania"
                        },
                        new
                        {
                            Id = 127,
                            CityName = "Bern",
                            CountryCode = "ch",
                            CountryName = "Switzerland"
                        },
                        new
                        {
                            Id = 128,
                            CityName = "Prague",
                            CountryCode = "cz",
                            CountryName = "Czech Republic"
                        },
                        new
                        {
                            Id = 129,
                            CityName = "Budapest",
                            CountryCode = "hu",
                            CountryName = "Hungary"
                        });
                });

            modelBuilder.Entity("WeatherInTheCity.API.Entities.UserStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Defeats")
                        .HasColumnType("int");

                    b.Property<int>("Games")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserStats");
                });
#pragma warning restore 612, 618
        }
    }
}
