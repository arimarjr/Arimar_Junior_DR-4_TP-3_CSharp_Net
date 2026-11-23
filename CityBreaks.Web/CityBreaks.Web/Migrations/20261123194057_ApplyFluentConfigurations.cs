using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityBreaks.Web.Migrations
{
    /// <inheritdoc />
    public partial class ApplyFluentConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PricePerNight",
                table: "Properties",
                newName: "Price_Per_Night");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Properties",
                newName: "Property_Name");

            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "Countries",
                newName: "Country_Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Property_Name",
                table: "Properties",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Price_Per_Night",
                table: "Properties",
                newName: "PricePerNight");

            migrationBuilder.RenameColumn(
                name: "Country_Name",
                table: "Countries",
                newName: "CountryName");
        }
    }
}
