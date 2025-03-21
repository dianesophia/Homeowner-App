using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class AEWRAWR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddedBy",
                table: "VehicleGatepasses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedOn",
                table: "VehicleGatepasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovalDate",
                table: "VehicleGatepasses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GatePassDocument",
                table: "VehicleGatepasses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GatePassExpiryDate",
                table: "VehicleGatepasses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GatePassIssuedDate",
                table: "VehicleGatepasses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "VehicleGatepasses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "QRCode",
                table: "VehicleGatepasses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RejectionReason",
                table: "VehicleGatepasses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "VehicleGatepasses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "VehicleGatepasses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleImage",
                table: "VehicleGatepasses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90f88048-643b-4a23-b551-0780da70b783", "AQAAAAIAAYagAAAAEJASqs91EU47Rn/bqo3CNZQxyLtcckOOnyZ+xHi2P4IxFvwIJZbWlYkSW8V+4Xzk+w==", "3b948c05-dd85-4e35-ad79-3cb32af960eb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "VehicleGatepasses");

            migrationBuilder.DropColumn(
                name: "AddedOn",
                table: "VehicleGatepasses");

            migrationBuilder.DropColumn(
                name: "ApprovalDate",
                table: "VehicleGatepasses");

            migrationBuilder.DropColumn(
                name: "GatePassDocument",
                table: "VehicleGatepasses");

            migrationBuilder.DropColumn(
                name: "GatePassExpiryDate",
                table: "VehicleGatepasses");

            migrationBuilder.DropColumn(
                name: "GatePassIssuedDate",
                table: "VehicleGatepasses");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "VehicleGatepasses");

            migrationBuilder.DropColumn(
                name: "QRCode",
                table: "VehicleGatepasses");

            migrationBuilder.DropColumn(
                name: "RejectionReason",
                table: "VehicleGatepasses");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "VehicleGatepasses");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "VehicleGatepasses");

            migrationBuilder.DropColumn(
                name: "VehicleImage",
                table: "VehicleGatepasses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bd60e1d-bfa8-4861-88ee-2fbb7f2812fb", "AQAAAAIAAYagAAAAEOzD0oT7N/LCFKpOh/jjff25/jgQsDJFY5YM5YyIqP98WO7M2ITWl5qAyNXqO/yamg==", "317b79bd-f826-41ea-b4ee-6b09016b33b1" });
        }
    }
}
