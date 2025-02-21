using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class statusid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackComplaints_Status_StatusId",
                table: "FeedbackComplaints");

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackComplaints_Status_StatusId",
                table: "FeedbackComplaints",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeedbackComplaints_Status_StatusId",
                table: "FeedbackComplaints");

            migrationBuilder.AddForeignKey(
                name: "FK_FeedbackComplaints_Status_StatusId",
                table: "FeedbackComplaints",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
