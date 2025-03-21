using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class HGAESRW : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsApproved",
                table: "VehicleGatepasses",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "IsRejected",
                table: "VehicleGatepasses",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03d8ad29-26f0-43fe-b5d9-bc11e561c5e7", "AQAAAAIAAYagAAAAENDZDzP1lydfUyVziHtVwhavZYjMdGXeiG4kC5E3hwet1HNXmE1VZ12+JprL0gkXaw==", "06eba2bb-1fb9-4bb1-9c52-7979fa068f57" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRejected",
                table: "VehicleGatepasses");

            migrationBuilder.AlterColumn<bool>(
                name: "IsApproved",
                table: "VehicleGatepasses",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b22fe60-8482-4408-bcad-0aeb0e7144ec", "AQAAAAIAAYagAAAAEPsR0jaNHLAKt3UNbWheMQwxnfLY58vFzmtKCGXwUElrqCrsPJwrTIaDAONc3T637w==", "a09479be-2958-4503-a566-70f3ae19680d" });
        }
    }
}
