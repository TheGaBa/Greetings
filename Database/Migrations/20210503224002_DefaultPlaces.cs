using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class DefaultPlaces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "Image" },
                values: new object[] { 1, "Los Angeles", null });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "Image" },
                values: new object[] { 2, "Zp", null });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "PlaceId", "CityId", "Cost", "PlaceName", "Street", "Time" },
                values: new object[] { 1, 1, 300.0, "Santa Monica Beach", "None", 99999 });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "PlaceId", "CityId", "Cost", "PlaceName", "Street", "Time" },
                values: new object[] { 2, 1, 300.0, "Hollywood", "None", 99999 });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "PlaceId", "CityId", "Cost", "PlaceName", "Street", "Time" },
                values: new object[] { 3, 2, 300.0, "Baburka", "None", 0 });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "PlaceId", "CityId", "Cost", "PlaceName", "Street", "Time" },
                values: new object[] { 4, 2, 300.0, "Center", "None", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2);
        }
    }
}
