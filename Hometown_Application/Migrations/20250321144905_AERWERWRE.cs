using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class AERWERWRE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bd60e1d-bfa8-4861-88ee-2fbb7f2812fb", "AQAAAAIAAYagAAAAEOzD0oT7N/LCFKpOh/jjff25/jgQsDJFY5YM5YyIqP98WO7M2ITWl5qAyNXqO/yamg==", "317b79bd-f826-41ea-b4ee-6b09016b33b1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "030fffd6-7c15-469d-9042-e3e68d32790c", "AQAAAAIAAYagAAAAED1sMwuH79dQgfqq34CAmx+rT3WDQ9eVFfbuw0+zhw9BsexxwwgagiNHlmSvYE2enA==", "78336188-eca4-4b3d-923b-ebf2765d9121" });
        }
    }
}
