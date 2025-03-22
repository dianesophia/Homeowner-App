using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class ASDAWER : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpirationDate",
                table: "VisitorGatepasses",
                newName: "GatePassIssuedDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "GatePassExpiryDate",
                table: "VisitorGatepasses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32aa269c-5c8f-4959-a306-d9dffea0f329", "AQAAAAIAAYagAAAAECWjMCkcUF9IU/ucEekBG5SAl/cWphXbuDE+M0DWCKl7ntdDpXGTNFpk82MA72PXHQ==", "ca3cf0fe-52d0-4de5-b3a7-0e5dc7da62e8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GatePassExpiryDate",
                table: "VisitorGatepasses");

            migrationBuilder.RenameColumn(
                name: "GatePassIssuedDate",
                table: "VisitorGatepasses",
                newName: "ExpirationDate");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b636167a-1bd9-435d-92d2-a14a9979d397", "AQAAAAIAAYagAAAAEIBDg/pqW3CtjxyLLoGxiCcaWMRiZSppM2+mig1bNur9DBBzmtWpPvJ0nzhbVmCg+w==", "f233744a-00a0-444c-a82d-205c1eb12829" });
        }
    }
}
