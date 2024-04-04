using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherInTheCity.API.Migrations
{
    /// <inheritdoc />
    public partial class GameFlowsModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "GameFlows");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "GameFlows",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
