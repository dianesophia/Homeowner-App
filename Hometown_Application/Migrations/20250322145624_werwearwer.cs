using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class werwearwer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "VisitorGatepasses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b636167a-1bd9-435d-92d2-a14a9979d397", "AQAAAAIAAYagAAAAEIBDg/pqW3CtjxyLLoGxiCcaWMRiZSppM2+mig1bNur9DBBzmtWpPvJ0nzhbVmCg+w==", "f233744a-00a0-444c-a82d-205c1eb12829" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "VisitorGatepasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6124b3f6-12df-478a-8e3f-6257c0fb8a16", "AQAAAAIAAYagAAAAEODrO/IBI2mzAdNlqPylfmxW7UWRwQ+aQaZRxJT1XlB81l5XztPDq8Utc32ZwQLB1g==", "48a90d95-f86e-40f5-b644-23c3cf76fd82" });
        }
    }
}
