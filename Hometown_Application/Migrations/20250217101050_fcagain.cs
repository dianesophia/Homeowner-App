using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class fcagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "FeedbackComplaints",
                newName: "Subject");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "FeedbackComplaints",
                newName: "Category");
        }
    }
}
