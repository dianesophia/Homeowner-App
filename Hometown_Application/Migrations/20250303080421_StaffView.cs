using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class StaffView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountCreatedBy",
                table: "StaffProfiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AccountCreatedOn",
                table: "StaffProfiles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Department",
                table: "StaffProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "StaffProfiles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFired",
                table: "StaffProfiles",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "StaffProfiles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "StaffProfiles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsBanned",
                table: "HomeownerProfiles",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountCreatedBy",
                table: "StaffProfiles");

            migrationBuilder.DropColumn(
                name: "AccountCreatedOn",
                table: "StaffProfiles");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "StaffProfiles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "StaffProfiles");

            migrationBuilder.DropColumn(
                name: "IsFired",
                table: "StaffProfiles");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "StaffProfiles");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "StaffProfiles");

            migrationBuilder.DropColumn(
                name: "IsBanned",
                table: "HomeownerProfiles");
        }
    }
}
