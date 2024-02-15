using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherInTheCity.API.Migrations
{
    /// <inheritdoc />
    public partial class CityNamesCorrection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 85,
                column: "CityName",
                value: "Warszawa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 86,
                column: "CityName",
                value: "Gdańsk");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 87,
                column: "CityName",
                value: "Kraków");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 88,
                column: "CityName",
                value: "Wrocław");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 85,
                column: "CityName",
                value: "Warsaw");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 86,
                column: "CityName",
                value: "Gdansk");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 87,
                column: "CityName",
                value: "Cracow");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 88,
                column: "CityName",
                value: "Wroclaw");
        }
    }
}
