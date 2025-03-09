using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class Staff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "ServiceRequests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_StaffId",
                table: "ServiceRequests",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRequests_StaffProfiles_StaffId",
                table: "ServiceRequests",
                column: "StaffId",
                principalTable: "StaffProfiles",
                principalColumn: "StaffId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRequests_StaffProfiles_StaffId",
                table: "ServiceRequests");

            migrationBuilder.DropIndex(
                name: "IX_ServiceRequests_StaffId",
                table: "ServiceRequests");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "ServiceRequests");
        }
    }
}
