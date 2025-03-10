using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class AREWR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14ffc6db-9c2e-47c9-b96f-7e5f2792af0d", "AQAAAAIAAYagAAAAEPJNv3hx2kWBbIKJYlaRHAU3U04OipfsZrGGgKN9rPjTpQkfBEejVugH8tNH2jLR0Q==", "66106bc4-f382-4470-860e-ac5c66090601" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7768d339-c683-4525-a4a4-dacfabf793c8", "AQAAAAIAAYagAAAAEDEvGsNRnXCukJVFh6XLh4ipgW9R82jkUkPWQTZMxDxaYLCqFeew3BVomLGbD5/uTw==", "ac98bae0-3ba3-490f-bd10-23011ad15173" });
        }
    }
}
