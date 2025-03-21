using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class WRE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e71e1c9-f942-4426-8ff5-399b269c2683", "AQAAAAIAAYagAAAAEOYsEOEcnEWEX+HMC1QDKHnKG72R+W0PrNdJoUxpF2qxg4BRaQQ1b2AI43YgA1QUKw==", "35858f0f-5b48-47ce-9810-27c6fd91e5e6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03d8ad29-26f0-43fe-b5d9-bc11e561c5e7", "AQAAAAIAAYagAAAAENDZDzP1lydfUyVziHtVwhavZYjMdGXeiG4kC5E3hwet1HNXmE1VZ12+JprL0gkXaw==", "06eba2bb-1fb9-4bb1-9c52-7979fa068f57" });
        }
    }
}
