using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class WERER : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VisitorVehicleDetails",
                table: "VisitorGatepasses");

            migrationBuilder.AddColumn<string>(
                name: "VehicleColor",
                table: "VisitorGatepasses",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehiclePlateNumber",
                table: "VisitorGatepasses",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleType",
                table: "VisitorGatepasses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7a7f707-bb40-40a6-9be7-97bdeed5d89e", "AQAAAAIAAYagAAAAEHcHp2KxydElBA2iiDURkxnEFHAImLDZyElsibeaWM2S9mlfWi+otI3FG7KRyN4QqQ==", "886a8e88-ace6-4aea-9c24-64fad5d034b4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleColor",
                table: "VisitorGatepasses");

            migrationBuilder.DropColumn(
                name: "VehiclePlateNumber",
                table: "VisitorGatepasses");

            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "VisitorGatepasses");

            migrationBuilder.AddColumn<string>(
                name: "VisitorVehicleDetails",
                table: "VisitorGatepasses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32aa269c-5c8f-4959-a306-d9dffea0f329", "AQAAAAIAAYagAAAAECWjMCkcUF9IU/ucEekBG5SAl/cWphXbuDE+M0DWCKl7ntdDpXGTNFpk82MA72PXHQ==", "ca3cf0fe-52d0-4de5-b3a7-0e5dc7da62e8" });
        }
    }
}
