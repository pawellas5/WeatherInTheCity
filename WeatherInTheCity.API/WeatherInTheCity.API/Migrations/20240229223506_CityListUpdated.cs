using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeatherInTheCity.API.Migrations
{
    /// <inheritdoc />
    public partial class CityListUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CityName",
                value: "Ottawa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CityName",
                value: "Edmonton");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CityName",
                value: "Vancouver");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CityName",
                value: "Quebec");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CityName",
                value: "Calgary");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CityName",
                value: "Yellowknife");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CityName",
                value: "Eyebrow");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CityName",
                value: "Moose Jaw");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CityName",
                value: "London");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "London", "gb", "Great Britain" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Birmingham", "gb", "Great Britain" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Manchester", "gb", "Great Britain" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CityName",
                value: "Liverpool");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CityName",
                value: "Edinburgh");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CityName",
                value: "Nottingham");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Berlin", "de", "Germany" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Monachium", "de", "Germany" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Hamburg", "de", "Germany" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CityName",
                value: "Dusseldorf");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Stockholm", "se", "Sweden" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Malmo", "se", "Sweden" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Gothenburg", "se", "Sweden" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Helsinki", "fi", "Finland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Tampere", "fi", "Finland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Oslo", "no", "Norway" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Bergen", "no", "Norway" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Trondheim", "no", "Norway" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Rome", "it", "Italy" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Milan", "it", "Italy" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Naples", "it", "Italy" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CityName",
                value: "Palermo");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CityName",
                value: "Florence");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CityName",
                value: "Bologna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CityName",
                value: "Venice");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CityName",
                value: "Turin");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CityName",
                value: "Genoa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Dublin", "ie", "Ireland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Sydney", "au", "Australia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Melbourne", "au", "Australia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Adelaide", "au", "Australia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Paris", "fr", "France" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Bordeaux", "fr", "France" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Lyon", "fr", "France" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CityName",
                value: "Marseille");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CityName",
                value: "Nice");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Athens", "gr", "Greece" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Corfu", "gr", "Greece" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Rhodes", "gr", "Greece" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Copenhagen", "dk", "Denmark" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Aarhus", "dk", "Denmark" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Barrow", "us", "USA" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "New York", "us", "USA" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Los Angeles", "us", "USA" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 59,
                column: "CityName",
                value: "Houston");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 60,
                column: "CityName",
                value: "Philadelphia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 61,
                column: "CityName",
                value: "Chicago");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 62,
                column: "CityName",
                value: "Dallas");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 63,
                column: "CityName",
                value: "Seattle");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 64,
                column: "CityName",
                value: "San Francisco");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 65,
                column: "CityName",
                value: "Nashville");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 66,
                column: "CityName",
                value: "El Paso");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 67,
                column: "CityName",
                value: "Washington");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 68,
                column: "CityName",
                value: "Boston");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 69,
                column: "CityName",
                value: "Las Vegas");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 70,
                column: "CityName",
                value: "Detroit");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 71,
                column: "CityName",
                value: "Sacramento");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 72,
                column: "CityName",
                value: "Kansas City");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 73,
                column: "CityName",
                value: "Phoenix");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 74,
                column: "CityName",
                value: "Miami");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 75,
                column: "CityName",
                value: "Tampa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 76,
                column: "CityName",
                value: "New Orleans");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 77,
                column: "CityName",
                value: "Honolulu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 78,
                column: "CityName",
                value: "Cincinnati");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Bangkok", "th", "Thailand" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Kuala Lumpur", "my", "Malaysia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Warszawa", "pl", "Poland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Gdańsk", "pl", "Poland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Kraków", "pl", "Poland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Wrocław", "pl", "Poland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Ulaanbaatar", "mn", "Mongolia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Cairo", "eg", "Egypt" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Baghdad", "iq", "Iraq" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Kuwait City", "kw", "Kuwait" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Buenos Aires", "ar", "Argentina" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Mexico City", "mx", "Mexico" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Beijing", "cn", "China" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Shanghai", "cn", "China" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Tokyo", "jp", "Japan" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Sapporo", "jp", "Japan" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Osaka", "jp", "Japan" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Hiroshima", "jp", "Japan" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Yokohama", "jp", "Japan" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Istanbul", "tr", "Turkey" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Seoul", "kr", "South Korea" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Mumbai", "in", "India" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Delhi", "in", "India" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Lisbon", "pt", "Portugal" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Jakarta", "id", "Indonesia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Singapore", "sg", "Singapore" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Havana", "cu", "Cuba" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Vienna", "at", "Austria" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Graz", "at", "Austria" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Linz", "at", "Austria" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Innsbruck", "at", "Austria" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Cape Town", "za", "South Africa" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Nuuk", "gl", "Greenland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Vilnius", "lt", "Lithuania" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Minsk", "by", "Belarus" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Tallinn", "ee", "Estonia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Amman", "jo", "Jordan" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Kingston", "jm", "Jamaica" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Port Antonio", "jm", "Jamaica" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Reykjavik", "is", "Iceland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Moscow", "ru", "Russia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Norilsk", "ru", "Russia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Yakutsk", "ru", "Russia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Kyiv", "ua", "ukraine" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Kharkiv", "ua", "ukraine" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Odesa", "ua", "Ukraine" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Riga", "lv", "Latvia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Bucharest", "ro", "Romania" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Bern", "ch", "Switzerland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Prague", "cz", "Czech Republic" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Budapest", "hu", "Hungary" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CityName",
                value: "Niagara Falls");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CityName",
                value: "Ottawa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CityName",
                value: "Edmonton");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CityName",
                value: "Vancouver");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CityName",
                value: "Quebec");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CityName",
                value: "Calgary");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CityName",
                value: "Yellowknife");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CityName",
                value: "Dead Man's Flats");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CityName",
                value: "Eyebrow");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Moose Jaw", "ca", "Canada" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Come By Chance", "ca", "Canada" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "London", "ca", "Canada" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CityName",
                value: "London");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CityName",
                value: "Birmingham");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CityName",
                value: "Manchester");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Liverpool", "gb", "Great Britain" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Edinburgh", "gb", "Great Britain" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Nottingham", "gb", "Great Britain" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CityName",
                value: "Berlin");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Monachium", "de", "Germany" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Hamburg", "de", "Germany" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Dusseldorf", "de", "Germany" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Stockholm", "se", "Sweden" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Malmo", "se", "Sweden" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Gothenburg", "se", "Sweden" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Helsinki", "fi", "Finland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Tampere", "fi", "Finland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Oslo", "no", "Norway" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Bergen", "no", "Norway" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Trondheim", "no", "Norway" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CityName",
                value: "Rome");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CityName",
                value: "Milan");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CityName",
                value: "Naples");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CityName",
                value: "Palermo");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CityName",
                value: "Florence");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CityName",
                value: "Bologna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Venice", "it", "Italy" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Turin", "it", "Italy" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Genoa", "it", "Italy" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Dublin", "ie", "Ireland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Sydney", "au", "Australia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Melbourne", "au", "Australia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Adelaide", "au", "Australia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49,
                column: "CityName",
                value: "Paris");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50,
                column: "CityName",
                value: "Bordeaux");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Lyon", "fr", "France" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Marseille", "fr", "France" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Nice", "fr", "France" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Athens", "gr", "Greece" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Corfu", "gr", "Greece" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Rhodes", "gr", "Greece" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Copenhagen", "dk", "Denmark" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Aarhus", "dk", "Denmark" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 59,
                column: "CityName",
                value: "International Falls");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 60,
                column: "CityName",
                value: "Barrow");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 61,
                column: "CityName",
                value: "New York");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 62,
                column: "CityName",
                value: "Los Angeles");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 63,
                column: "CityName",
                value: "Houston");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 64,
                column: "CityName",
                value: "Philadelphia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 65,
                column: "CityName",
                value: "Chicago");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 66,
                column: "CityName",
                value: "Dallas");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 67,
                column: "CityName",
                value: "Seattle");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 68,
                column: "CityName",
                value: "San Francisco");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 69,
                column: "CityName",
                value: "Nashville");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 70,
                column: "CityName",
                value: "El Paso");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 71,
                column: "CityName",
                value: "Washington");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 72,
                column: "CityName",
                value: "Boston");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 73,
                column: "CityName",
                value: "Las Vegas");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 74,
                column: "CityName",
                value: "Detroit");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 75,
                column: "CityName",
                value: "Sacramento");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 76,
                column: "CityName",
                value: "Kansas City");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 77,
                column: "CityName",
                value: "Phoenix");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 78,
                column: "CityName",
                value: "Miami");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Tampa", "us", "USA" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "New Orleans", "us", "USA" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Honolulu", "us", "USA" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Cincinnati", "us", "USA" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Bangkok", "th", "Thailand" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Kuala Lumpur", "my", "Malaysia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Warszawa", "pl", "Poland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Gdańsk", "pl", "Poland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Kraków", "pl", "Poland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Wrocław", "pl", "Poland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Ulaanbaatar", "mn", "Mongolia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Cairo", "eg", "Egypt" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Baghdad", "iq", "Iraq" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Kuwait City", "kw", "Kuwait" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Comodoro Rivadavia", "ar", "Argentina" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Buenos Aires", "ar", "Argentina" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Mexico City", "mx", "Mexico" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Beijing", "cn", "China" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Shanghai", "cn", "China" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Tokyo", "jp", "Japan" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Sapporo", "jp", "Japan" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Osaka", "jp", "Japan" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Hiroshima", "jp", "Japan" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Yokohama", "jp", "Japan" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Istanbul", "tr", "Turkey" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Seoul", "kr", "South Korea" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Mumbai", "in", "India" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Delhi", "in", "India" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Lisbon", "pt", "Portugal" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Jakarta", "id", "Indonesia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Singapore", "sg", "Singapore" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Havana", "cu", "Cuba" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Vienna", "at", "Austria" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Graz", "at", "Austria" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Linz", "at", "Austria" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Innsbruck", "at", "Austria" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Cape Town", "za", "South Africa" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Nuuk", "gl", "Greenland" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Vilnius", "lt", "Lithuania" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Minsk", "by", "Belarus" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Tallinn", "ee", "Estonia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Amman", "jo", "Jordan" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Kingston", "jm", "Jamaica" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Port Antonio", "jm", "Jamaica" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Reykjavik", "is", "Islandia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Moscow", "ru", "Russia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Norilsk", "ru", "Russia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Yakutsk", "ru", "Russia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Kyiv", "ua", "ukraine" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Kharkiv", "ua", "ukraine" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CityName", "CountryCode", "CountryName" },
                values: new object[] { "Odesa", "ua", "Ukraine" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName", "CountryCode", "CountryName" },
                values: new object[,]
                {
                    { 130, "Riga", "lv", "Latvia" },
                    { 131, "Bucharest", "ro", "Romania" },
                    { 132, "Bern", "ch", "Switzerland" },
                    { 133, "Prague", "cz", "Czech Republic" },
                    { 134, "Sarajevo", "ba", "Bosnia and Herzegovina" },
                    { 135, "Budapest", "hu", "Hungary" }
                });
        }
    }
}
