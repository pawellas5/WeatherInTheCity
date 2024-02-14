using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeatherInTheCity.API.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { 6, "Niagara Falls", "ca", "Canada" },
                    { 7, "Ottawa", "ca", "Canada" },
                    { 8, "Edmonton", "ca", "Canada" },
                    { 9, "Vancouver", "ca", "Canada" },
                    { 10, "Quebec", "ca", "Canada" },
                    { 11, "Calgary", "ca", "Canada" },
                    { 12, "Yellowknife", "ca", "Canada" },
                    { 13, "Dead Man's Flats", "ca", "Canada" },
                    { 14, "Eyebrow", "ca", "Canada" },
                    { 15, "Moose Jaw", "ca", "Canada" },
                    { 16, "Come By Chance", "ca", "Canada" },
                    { 17, "London", "ca", "Canada" },
                    { 18, "London", "gb", "Great Britain" },
                    { 19, "Birmingham", "gb", "Great Britain" },
                    { 20, "Manchester", "gb", "Great Britain" },
                    { 21, "Liverpool", "gb", "Great Britain" },
                    { 22, "Edinburgh", "gb", "Great Britain" },
                    { 23, "Nottingham", "gb", "Great Britain" },
                    { 24, "Berlin", "de", "Germany" },
                    { 25, "Monachium", "de", "Germany" },
                    { 26, "Hamburg", "de", "Germany" },
                    { 27, "Dusseldorf", "de", "Germany" },
                    { 28, "Stockholm", "se", "Sweden" },
                    { 29, "Malmo", "se", "Sweden" },
                    { 30, "Gothenburg", "se", "Sweden" },
                    { 31, "Helsinki", "fi", "Finland" },
                    { 32, "Tampere", "fi", "Finland" },
                    { 33, "Oslo", "no", "Norway" },
                    { 34, "Bergen", "no", "Norway" },
                    { 35, "Trondheim", "no", "Norway" },
                    { 36, "Rome", "it", "Italy" },
                    { 37, "Milan", "it", "Italy" },
                    { 38, "Naples", "it", "Italy" },
                    { 39, "Palermo", "it", "Italy" },
                    { 40, "Florence", "it", "Italy" },
                    { 41, "Bologna", "it", "Italy" },
                    { 42, "Venice", "it", "Italy" },
                    { 43, "Turin", "it", "Italy" },
                    { 44, "Genoa", "it", "Italy" },
                    { 45, "Dublin", "ie", "Ireland" },
                    { 46, "Sydney", "au", "Australia" },
                    { 47, "Melbourne", "au", "Australia" },
                    { 48, "Adelaide", "au", "Australia" },
                    { 49, "Paris", "fr", "France" },
                    { 50, "Bordeaux", "fr", "France" },
                    { 51, "Lyon", "fr", "France" },
                    { 52, "Marseille", "fr", "France" },
                    { 53, "Nice", "fr", "France" },
                    { 54, "Athens", "gr", "Greece" },
                    { 55, "Corfu", "gr", "Greece" },
                    { 56, "Rhodes", "gr", "Greece" },
                    { 57, "Copenhagen", "dk", "Denmark" },
                    { 58, "Aarhus", "dk", "Denmark" },
                    { 59, "International Falls", "us", "USA" },
                    { 60, "Barrow", "us", "USA" },
                    { 61, "New York", "us", "USA" },
                    { 62, "Los Angeles", "us", "USA" },
                    { 63, "Houston", "us", "USA" },
                    { 64, "Philadelphia", "us", "USA" },
                    { 65, "Chicago", "us", "USA" },
                    { 66, "Dallas", "us", "USA" },
                    { 67, "Seattle", "us", "USA" },
                    { 68, "San Francisco", "us", "USA" },
                    { 69, "Nashville", "us", "USA" },
                    { 70, "El Paso", "us", "USA" },
                    { 71, "Washington", "us", "USA" },
                    { 72, "Boston", "us", "USA" },
                    { 73, "Las Vegas", "us", "USA" },
                    { 74, "Detroit", "us", "USA" },
                    { 75, "Sacramento", "us", "USA" },
                    { 76, "Kansas City", "us", "USA" },
                    { 77, "Phoenix", "us", "USA" },
                    { 78, "Miami", "us", "USA" },
                    { 79, "Tampa", "us", "USA" },
                    { 80, "New Orleans", "us", "USA" },
                    { 81, "Honolulu", "us", "USA" },
                    { 82, "Cincinnati", "us", "USA" },
                    { 83, "Bangkok", "th", "Thailand" },
                    { 84, "Kuala Lumpur", "my", "Malaysia" },
                    { 85, "Warsaw", "pl", "Poland" },
                    { 86, "Gdansk", "pl", "Poland" },
                    { 87, "Cracow", "pl", "Poland" },
                    { 88, "Wroclaw", "pl", "Poland" },
                    { 89, "Ulaanbaatar", "mn", "Mongolia" },
                    { 90, "Cairo", "eg", "Egypt" },
                    { 91, "Baghdad", "iq", "Iraq" },
                    { 92, "Kuwait City", "kw", "Kuwait" },
                    { 93, "Comodoro Rivadavia", "ar", "Argentina" },
                    { 94, "Buenos Aires", "ar", "Argentina" },
                    { 95, "Mexico City", "mx", "Mexico" },
                    { 96, "Beijing", "cn", "China" },
                    { 97, "Shanghai", "cn", "China" },
                    { 98, "Tokyo", "jp", "Japan" },
                    { 99, "Sapporo", "jp", "Japan" },
                    { 100, "Osaka", "jp", "Japan" },
                    { 101, "Hiroshima", "jp", "Japan" },
                    { 102, "Yokohama", "jp", "Japan" },
                    { 103, "Istanbul", "tr", "Turkey" },
                    { 104, "Seoul", "kr", "South Korea" },
                    { 105, "Mumbai", "in", "India" },
                    { 106, "Delhi", "in", "India" },
                    { 107, "Lisbon", "pt", "Portugal" },
                    { 108, "Jakarta", "id", "Indonesia" },
                    { 109, "Singapore", "sg", "Singapore" },
                    { 110, "Havana", "cu", "Cuba" },
                    { 111, "Vienna", "at", "Austria" },
                    { 112, "Graz", "at", "Austria" },
                    { 113, "Linz", "at", "Austria" },
                    { 114, "Innsbruck", "at", "Austria" },
                    { 115, "Cape Town", "za", "South Africa" },
                    { 116, "Nuuk", "gl", "Greenland" },
                    { 117, "Vilnius", "lt", "Lithuania" },
                    { 118, "Minsk", "by", "Belarus" },
                    { 119, "Tallinn", "ee", "Estonia" },
                    { 120, "Amman", "jo", "Jordan" },
                    { 121, "Kingston", "jm", "Jamaica" },
                    { 122, "Port Antonio", "jm", "Jamaica" },
                    { 123, "Reykjavik", "is", "Islandia" },
                    { 124, "Moscow", "ru", "Russia" },
                    { 125, "Norilsk", "ru", "Russia" },
                    { 126, "Yakutsk", "ru", "Russia" },
                    { 127, "Kyiv", "ua", "ukraine" },
                    { 128, "Kharkiv", "ua", "ukraine" },
                    { 129, "Odesa", "ua", "Ukraine" },
                    { 130, "Riga", "lv", "Latvia" },
                    { 131, "Bucharest", "ro", "Romania" },
                    { 132, "Bern", "ch", "Switzerland" },
                    { 133, "Prague", "cz", "Czech Republic" },
                    { 134, "Sarajevo", "ba", "Bosnia and Herzegovina" },
                    { 135, "Budapest", "hu", "Hungary" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 129);

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
        }
    }
}
