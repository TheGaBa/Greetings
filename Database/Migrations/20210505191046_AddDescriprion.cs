using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class AddDescriprion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descriprion",
                table: "Places",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 1,
                column: "Descriprion",
                value: "asda sddd ddddd dddd dd dd dd dddddd dddddd");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 2,
                column: "Descriprion",
                value: "asda sddd ddddd dddd dd dd dd dddddd dddddd");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 3,
                column: "Descriprion",
                value: "asda sddd ddddd dddd dd dd dd dddddd dddddd");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 4,
                column: "Descriprion",
                value: "asda sddd ddddd dddd dd dd dd dddddd dddddd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descriprion",
                table: "Places");
        }
    }
}
