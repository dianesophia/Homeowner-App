using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class AWRE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApprovalStatus",
                table: "VehicleGatepasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b22fe60-8482-4408-bcad-0aeb0e7144ec", "AQAAAAIAAYagAAAAEPsR0jaNHLAKt3UNbWheMQwxnfLY58vFzmtKCGXwUElrqCrsPJwrTIaDAONc3T637w==", "a09479be-2958-4503-a566-70f3ae19680d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovalStatus",
                table: "VehicleGatepasses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90f88048-643b-4a23-b551-0780da70b783", "AQAAAAIAAYagAAAAEJASqs91EU47Rn/bqo3CNZQxyLtcckOOnyZ+xHi2P4IxFvwIJZbWlYkSW8V+4Xzk+w==", "3b948c05-dd85-4e35-ad79-3cb32af960eb" });
        }
    }
}
