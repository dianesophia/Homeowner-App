using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class ViewModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminProfileModel_AspNetUsers_UserId",
                table: "AdminProfileModel");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AdminProfileModel_AdminProfilesAdminId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_StaffProfileModel_StaffProfilesStaffId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffProfileModel_AspNetUsers_UserId",
                table: "StaffProfileModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffProfileModel",
                table: "StaffProfileModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdminProfileModel",
                table: "AdminProfileModel");

            migrationBuilder.RenameTable(
                name: "StaffProfileModel",
                newName: "StaffProfiles");

            migrationBuilder.RenameTable(
                name: "AdminProfileModel",
                newName: "AdminProfiles");

            migrationBuilder.RenameIndex(
                name: "IX_StaffProfileModel_UserId",
                table: "StaffProfiles",
                newName: "IX_StaffProfiles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AdminProfileModel_UserId",
                table: "AdminProfiles",
                newName: "IX_AdminProfiles_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffProfiles",
                table: "StaffProfiles",
                column: "StaffId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdminProfiles",
                table: "AdminProfiles",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminProfiles_AspNetUsers_UserId",
                table: "AdminProfiles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AdminProfiles_AdminProfilesAdminId",
                table: "AspNetUsers",
                column: "AdminProfilesAdminId",
                principalTable: "AdminProfiles",
                principalColumn: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_StaffProfiles_StaffProfilesStaffId",
                table: "AspNetUsers",
                column: "StaffProfilesStaffId",
                principalTable: "StaffProfiles",
                principalColumn: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffProfiles_AspNetUsers_UserId",
                table: "StaffProfiles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminProfiles_AspNetUsers_UserId",
                table: "AdminProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AdminProfiles_AdminProfilesAdminId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_StaffProfiles_StaffProfilesStaffId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffProfiles_AspNetUsers_UserId",
                table: "StaffProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StaffProfiles",
                table: "StaffProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdminProfiles",
                table: "AdminProfiles");

            migrationBuilder.RenameTable(
                name: "StaffProfiles",
                newName: "StaffProfileModel");

            migrationBuilder.RenameTable(
                name: "AdminProfiles",
                newName: "AdminProfileModel");

            migrationBuilder.RenameIndex(
                name: "IX_StaffProfiles_UserId",
                table: "StaffProfileModel",
                newName: "IX_StaffProfileModel_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AdminProfiles_UserId",
                table: "AdminProfileModel",
                newName: "IX_AdminProfileModel_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StaffProfileModel",
                table: "StaffProfileModel",
                column: "StaffId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdminProfileModel",
                table: "AdminProfileModel",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminProfileModel_AspNetUsers_UserId",
                table: "AdminProfileModel",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AdminProfileModel_AdminProfilesAdminId",
                table: "AspNetUsers",
                column: "AdminProfilesAdminId",
                principalTable: "AdminProfileModel",
                principalColumn: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_StaffProfileModel_StaffProfilesStaffId",
                table: "AspNetUsers",
                column: "StaffProfilesStaffId",
                principalTable: "StaffProfileModel",
                principalColumn: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_StaffProfileModel_AspNetUsers_UserId",
                table: "StaffProfileModel",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
