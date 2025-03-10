using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class CAEWR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fb2d39d-a805-47c5-adb9-ea983429e976", "AQAAAAIAAYagAAAAEO7p4DyNkx7zJRdZdjsfujUY8ZGGayWkhmwxAFb6u/mywa7N/zREsdxJB42+Hgzrjg==", "3a52681d-0b88-41fc-80fb-56ad5a454a38" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d045cebe-4110-4aa1-9052-c6d3fb794e36", "AQAAAAIAAYagAAAAEEqkxVZ19YDwGaLrBknKuc6KEGGNjg0Losw5kdQH5YSPDBxUsodiN13mBh1YZJRTsw==", "d660e383-71b2-4297-9db6-429927deb192" });
        }
    }
}
