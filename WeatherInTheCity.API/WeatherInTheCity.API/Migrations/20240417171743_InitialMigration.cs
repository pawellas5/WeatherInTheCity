using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeatherInTheCity.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CityName = table.Column<string>(type: "text", nullable: false),
                    CountryName = table.Column<string>(type: "text", nullable: false),
                    CountryCode = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameFlows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Question = table.Column<string>(type: "text", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameFlows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    Wins = table.Column<int>(type: "integer", nullable: false),
                    Defeats = table.Column<int>(type: "integer", nullable: false),
                    Games = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStats", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName", "CountryCode", "CountryName" },
                values: new object[,]
                {
                    { 1, "Madrid", "es", "Spain" },
                    { 2, "Barcelona", "es", "Spain" },
                    { 3, "Bilbao", "es", "Spain" },
                    { 4, "Alicante", "es", "Spain" },
                    { 5, "Toronto", "ca", "Canada" },
                    { 6, "Ottawa", "ca", "Canada" },
                    { 7, "Edmonton", "ca", "Canada" },
                    { 8, "Vancouver", "ca", "Canada" },
                    { 9, "Quebec", "ca", "Canada" },
                    { 10, "Calgary", "ca", "Canada" },
                    { 11, "Yellowknife", "ca", "Canada" },
                    { 12, "Eyebrow", "ca", "Canada" },
                    { 13, "Moose Jaw", "ca", "Canada" },
                    { 14, "London", "ca", "Canada" },
                    { 15, "London", "gb", "Great Britain" },
                    { 16, "Birmingham", "gb", "Great Britain" },
                    { 17, "Manchester", "gb", "Great Britain" },
                    { 18, "Liverpool", "gb", "Great Britain" },
                    { 19, "Edinburgh", "gb", "Great Britain" },
                    { 20, "Nottingham", "gb", "Great Britain" },
                    { 21, "Berlin", "de", "Germany" },
                    { 22, "Monachium", "de", "Germany" },
                    { 23, "Hamburg", "de", "Germany" },
                    { 24, "Dusseldorf", "de", "Germany" },
                    { 25, "Stockholm", "se", "Sweden" },
                    { 26, "Malmo", "se", "Sweden" },
                    { 27, "Gothenburg", "se", "Sweden" },
                    { 28, "Helsinki", "fi", "Finland" },
                    { 29, "Tampere", "fi", "Finland" },
                    { 30, "Oslo", "no", "Norway" },
                    { 31, "Bergen", "no", "Norway" },
                    { 32, "Trondheim", "no", "Norway" },
                    { 33, "Rome", "it", "Italy" },
                    { 34, "Milan", "it", "Italy" },
                    { 35, "Naples", "it", "Italy" },
                    { 36, "Palermo", "it", "Italy" },
                    { 37, "Florence", "it", "Italy" },
                    { 38, "Bologna", "it", "Italy" },
                    { 39, "Venice", "it", "Italy" },
                    { 40, "Turin", "it", "Italy" },
                    { 41, "Genoa", "it", "Italy" },
                    { 42, "Dublin", "ie", "Ireland" },
                    { 43, "Sydney", "au", "Australia" },
                    { 44, "Melbourne", "au", "Australia" },
                    { 45, "Adelaide", "au", "Australia" },
                    { 46, "Paris", "fr", "France" },
                    { 47, "Bordeaux", "fr", "France" },
                    { 48, "Lyon", "fr", "France" },
                    { 49, "Marseille", "fr", "France" },
                    { 50, "Nice", "fr", "France" },
                    { 51, "Athens", "gr", "Greece" },
                    { 52, "Corfu", "gr", "Greece" },
                    { 53, "Rhodes", "gr", "Greece" },
                    { 54, "Copenhagen", "dk", "Denmark" },
                    { 55, "Aarhus", "dk", "Denmark" },
                    { 56, "Barrow", "us", "USA" },
                    { 57, "New York", "us", "USA" },
                    { 58, "Los Angeles", "us", "USA" },
                    { 59, "Houston", "us", "USA" },
                    { 60, "Philadelphia", "us", "USA" },
                    { 61, "Chicago", "us", "USA" },
                    { 62, "Dallas", "us", "USA" },
                    { 63, "Seattle", "us", "USA" },
                    { 64, "San Francisco", "us", "USA" },
                    { 65, "Nashville", "us", "USA" },
                    { 66, "El Paso", "us", "USA" },
                    { 67, "Washington", "us", "USA" },
                    { 68, "Boston", "us", "USA" },
                    { 69, "Las Vegas", "us", "USA" },
                    { 70, "Detroit", "us", "USA" },
                    { 71, "Sacramento", "us", "USA" },
                    { 72, "Kansas City", "us", "USA" },
                    { 73, "Phoenix", "us", "USA" },
                    { 74, "Miami", "us", "USA" },
                    { 75, "Tampa", "us", "USA" },
                    { 76, "New Orleans", "us", "USA" },
                    { 77, "Honolulu", "us", "USA" },
                    { 78, "Cincinnati", "us", "USA" },
                    { 79, "Bangkok", "th", "Thailand" },
                    { 80, "Kuala Lumpur", "my", "Malaysia" },
                    { 81, "Warszawa", "pl", "Poland" },
                    { 82, "Gdańsk", "pl", "Poland" },
                    { 83, "Kraków", "pl", "Poland" },
                    { 84, "Wrocław", "pl", "Poland" },
                    { 85, "Ulaanbaatar", "mn", "Mongolia" },
                    { 86, "Cairo", "eg", "Egypt" },
                    { 87, "Baghdad", "iq", "Iraq" },
                    { 88, "Kuwait City", "kw", "Kuwait" },
                    { 89, "Buenos Aires", "ar", "Argentina" },
                    { 90, "Mexico City", "mx", "Mexico" },
                    { 91, "Beijing", "cn", "China" },
                    { 92, "Shanghai", "cn", "China" },
                    { 93, "Tokyo", "jp", "Japan" },
                    { 94, "Sapporo", "jp", "Japan" },
                    { 95, "Osaka", "jp", "Japan" },
                    { 96, "Hiroshima", "jp", "Japan" },
                    { 97, "Yokohama", "jp", "Japan" },
                    { 98, "Istanbul", "tr", "Turkey" },
                    { 99, "Seoul", "kr", "South Korea" },
                    { 100, "Mumbai", "in", "India" },
                    { 101, "Delhi", "in", "India" },
                    { 102, "Lisbon", "pt", "Portugal" },
                    { 103, "Jakarta", "id", "Indonesia" },
                    { 104, "Singapore", "sg", "Singapore" },
                    { 105, "Havana", "cu", "Cuba" },
                    { 106, "Vienna", "at", "Austria" },
                    { 107, "Graz", "at", "Austria" },
                    { 108, "Linz", "at", "Austria" },
                    { 109, "Innsbruck", "at", "Austria" },
                    { 110, "Cape Town", "za", "South Africa" },
                    { 111, "Nuuk", "gl", "Greenland" },
                    { 112, "Vilnius", "lt", "Lithuania" },
                    { 113, "Minsk", "by", "Belarus" },
                    { 114, "Tallinn", "ee", "Estonia" },
                    { 115, "Amman", "jo", "Jordan" },
                    { 116, "Kingston", "jm", "Jamaica" },
                    { 117, "Port Antonio", "jm", "Jamaica" },
                    { 118, "Reykjavik", "is", "Iceland" },
                    { 119, "Moscow", "ru", "Russia" },
                    { 120, "Norilsk", "ru", "Russia" },
                    { 121, "Yakutsk", "ru", "Russia" },
                    { 122, "Kyiv", "ua", "ukraine" },
                    { 123, "Kharkiv", "ua", "ukraine" },
                    { 124, "Odesa", "ua", "Ukraine" },
                    { 125, "Riga", "lv", "Latvia" },
                    { 126, "Bucharest", "ro", "Romania" },
                    { 127, "Bern", "ch", "Switzerland" },
                    { 128, "Prague", "cz", "Czech Republic" },
                    { 129, "Budapest", "hu", "Hungary" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "GameFlows");

            migrationBuilder.DropTable(
                name: "UserStats");
        }
    }
}
