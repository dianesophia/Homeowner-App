using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class AWERW : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Posts",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3af2d3dc-cbe7-4e92-a6e9-e57e493c9024", "AQAAAAIAAYagAAAAEECr0wb7LIFkK9aRzH64J20dcLogA8Hidv5cb8AOBRd+TWXdAZkhCE/LVdPrP2yqWQ==", "0238c21c-18cf-44a8-b87c-e6fff7fd3aad" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18fcc0eb-595c-4378-b90a-47a2dba48ed3", "AQAAAAIAAYagAAAAELdtS/YE2w4NHmqF3MFcLtGA9+7KHtmhis2B4ur7ObVUwIavLaQeIC42muglpMwUEA==", "c77d357c-b988-4dd6-8e05-3be914bac488" });
        }
    }
}
