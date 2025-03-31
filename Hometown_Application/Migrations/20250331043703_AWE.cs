using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class AWE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "RemainingBalance",
                table: "BillItems",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "TransactionHistory",
                columns: table => new
                {
                    TransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillItemsID = table.Column<int>(type: "int", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaidBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaymentReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionHistory", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_TransactionHistory_BillItems_BillItemsID",
                        column: x => x.BillItemsID,
                        principalTable: "BillItems",
                        principalColumn: "BillItemsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62dfd66b-212b-4599-94cd-7f2a58fa711f", "AQAAAAIAAYagAAAAECopee79/mmH4qC0N7vognPd7JHjt4oinuRlon6jUd62xlzC+otiITjchzIpQJc+Cw==", "177a9186-87d8-4a4b-b700-61154eab8f6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb633617-577a-4c0f-9aa2-45a35ab37d10", "AQAAAAIAAYagAAAAEI/s+tIEKQ2u66vp59x+exn5PWi7h1UjLjiF9sCssixLP6Nz0IU8+F9biUkkZlkctQ==", "419a1cf0-367f-4e4c-89f2-8be855502159" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70b7941d-250d-48dc-b783-c787e1f3a119", "AQAAAAIAAYagAAAAEGD4MT4CvmXtvZfTjtBNu6ruTWK+M8CEfhbb+xbFHLJqBHFAA4abMgsbc05VGu1U8w==", "c26ed56e-3a97-4c23-8d93-115786cbd580" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "814b83b6-3261-40d0-9ac5-f4e5a5da0d8c", "AQAAAAIAAYagAAAAEGuqCUdND823kRKva/Cu8CN55u5HKaaPlzFMu+TqSre9oYgb51RUpyuJ2D9nHGh9FQ==", "0dcc84ae-91ba-48cb-b85d-d0837eda4d95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67777d97-3228-45a9-84fc-af7827003e20", "AQAAAAIAAYagAAAAEO7kKUoZ1/ID+Cb3y4h2nmj43f83GvtY3xobE7loYvM42IJoLS8cx+XtTmBTpaPHHw==", "f1418f6e-34ea-4946-9be4-4daf76927a24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0c409be-dc33-4286-b0f8-bdd366dc9abe", "AQAAAAIAAYagAAAAEBroM6nPHVX6JY1AyVkrKeb0fmIIPErufyxgLd9Pvtrf3K31F75CIIm3VRmK9TtSqA==", "6f6ceaf7-9b94-41fd-b2a5-71f0e999d3e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bd4d2ed-293e-4f58-8199-8fe7dc2fbeed", "AQAAAAIAAYagAAAAENcKVIox1TU4bNv1fuQ3r9ochHgznztNY8s2JjNWtop5xoki8Vd6hj1A3mkANKhHoQ==", "faf6a0af-a03d-4ca7-8e23-0ff7faf0b66d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5da272b9-8477-4406-9f64-00eb45228876", "AQAAAAIAAYagAAAAECoCRGm1vrKbZiy96qZwE6InHDFcQnp8T6yv/JXcvS7K34yJc28trxQ6eE4uWX8MyA==", "0a31ea88-c424-47c0-9e20-7fa5c80bde7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f99446dd-a789-4df7-bb5d-a385830c749d", "AQAAAAIAAYagAAAAECE30uh0pw9bQ6nrURys3XfPzyW6x+SV1/4h8rBOAlh3//FHnbTmFFs+hQ9iYz+0ng==", "1970732a-9559-429d-86bc-5181db14f0c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f58317f8-96a0-41a4-b36c-ca755fe809f9", "AQAAAAIAAYagAAAAECyj1Qftpn8pzGLjbeyQfYgaTGCY/4k2BNO4tsIA1xewKQiFNroFB2rj5FlwXdnnEQ==", "ac0e00de-2446-460e-8388-7c9138e71e6f" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                columns: new[] { "AddedOn", "RemainingBalance" },
                values: new object[] { new DateTime(2025, 3, 31, 4, 37, 1, 605, DateTimeKind.Utc).AddTicks(3328), 0m });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                columns: new[] { "AddedOn", "RemainingBalance" },
                values: new object[] { new DateTime(2025, 3, 31, 4, 37, 1, 605, DateTimeKind.Utc).AddTicks(3337), 0m });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 3,
                columns: new[] { "AddedOn", "RemainingBalance" },
                values: new object[] { new DateTime(2025, 3, 31, 4, 37, 1, 605, DateTimeKind.Utc).AddTicks(3339), 0m });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                columns: new[] { "AddedOn", "RemainingBalance" },
                values: new object[] { new DateTime(2025, 3, 31, 4, 37, 1, 605, DateTimeKind.Utc).AddTicks(3340), 0m });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                columns: new[] { "AddedOn", "RemainingBalance" },
                values: new object[] { new DateTime(2025, 3, 31, 4, 37, 1, 605, DateTimeKind.Utc).AddTicks(3341), 0m });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                columns: new[] { "AddedOn", "RemainingBalance" },
                values: new object[] { new DateTime(2025, 3, 31, 4, 37, 1, 605, DateTimeKind.Utc).AddTicks(3342), 0m });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                columns: new[] { "AddedOn", "RemainingBalance" },
                values: new object[] { new DateTime(2025, 3, 31, 4, 37, 1, 605, DateTimeKind.Utc).AddTicks(3344), 0m });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                columns: new[] { "AddedOn", "RemainingBalance" },
                values: new object[] { new DateTime(2025, 3, 31, 4, 37, 1, 605, DateTimeKind.Utc).AddTicks(3345), 0m });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                columns: new[] { "AddedOn", "RemainingBalance" },
                values: new object[] { new DateTime(2025, 3, 31, 4, 37, 1, 605, DateTimeKind.Utc).AddTicks(3346), 0m });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                columns: new[] { "AddedOn", "RemainingBalance" },
                values: new object[] { new DateTime(2025, 3, 31, 4, 37, 1, 605, DateTimeKind.Utc).AddTicks(3348), 0m });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                columns: new[] { "AddedOn", "RemainingBalance" },
                values: new object[] { new DateTime(2025, 3, 31, 4, 37, 1, 605, DateTimeKind.Utc).AddTicks(3349), 0m });

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 4, 37, 2, 196, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 4, 37, 2, 196, DateTimeKind.Utc).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 4, 37, 2, 196, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 4, 37, 2, 196, DateTimeKind.Utc).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 4, 37, 2, 196, DateTimeKind.Utc).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 4, 37, 2, 196, DateTimeKind.Utc).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 4, 37, 2, 196, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.CreateIndex(
                name: "IX_TransactionHistory_BillItemsID",
                table: "TransactionHistory",
                column: "BillItemsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionHistory");

            migrationBuilder.DropColumn(
                name: "RemainingBalance",
                table: "BillItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2eff439-02f6-4232-856b-425d9e4fb397", "AQAAAAIAAYagAAAAEJ9Ydg70q5peK1M/7fjg03oXbVNE3hNFoNQPyVlSLdKkQT5Mb3lizUAzQ8kgm72zMg==", "32cc0a5e-0dd1-4fa8-b5a3-48146aa925e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fdcb3ec-82e4-4ac4-9501-6ce19e4d3e52", "AQAAAAIAAYagAAAAEGbazmRIZ7WMf0MVv8x+/NFG7YOzOEYbu3ivPZMpJkaUH2cwntBo+EFjWLcBy9QSCg==", "d8ba99f2-9d1d-4e65-a3b5-773cdbfe73ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9176def7-aedd-4852-b2d0-6d78cff41bec", "AQAAAAIAAYagAAAAEMp0k0vSUWVJSGOu8FKrwFrN8UVZf7iAzR/0sbAQGNANz2SgNWuZM0IY9L/lKBpgGA==", "56fdea3f-2858-475d-b23e-a62b85fad7a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26016545-371b-4909-a586-37e0ebd3412f", "AQAAAAIAAYagAAAAEPp7k5xQnlGqGNdoVnkrC516JN36mXO5lE4bADcSBi0ln65AyvLjgstFXvcARQLsFA==", "35490810-9a17-4df4-8efa-f85f5f18a7fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f01b13f5-765a-477a-a115-033a07fcb16a", "AQAAAAIAAYagAAAAEHpuj8byhYitEyZRzHXMdlpS0IxpoHWx8p9e1Pa5EaQxK+PjahUfqmjE1MbyBMDBXA==", "528b95d0-2622-4dc6-99ab-bccfe4c7e50f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "187c067c-e22c-460a-acf6-686d176ea164", "AQAAAAIAAYagAAAAEI409IcEYbLeCrb0dd2sY32/48Xo6wlrNs0rPM3svqTmcR7BSMpJIkQxH+pOzSw89g==", "3e19a78c-05c2-445c-8993-bc84b5cc817e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0be5584-25bd-4b4d-8b2c-a2127f8b8696", "AQAAAAIAAYagAAAAENH5i/3R9bZaCOUcXs98ugbEjHz7aB+XkezhxnptZa5jASxxEpaQ+YV4hSz8J5F3rQ==", "bb052afc-6a2b-4e9a-9348-d381b7a3ca9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af9edbc1-f9fe-4a02-a55c-e900f895389f", "AQAAAAIAAYagAAAAEDOW9oXIg0wtXNhURT0JLO0mtq0DzkpjS+NMWZQHbK+xDiuZK8Za+4oBtncDCzcfZg==", "fd6f87ac-29ac-473f-952a-36e68cf7a7ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "867a8987-cb14-4c86-a3df-2b4d937f27cd", "AQAAAAIAAYagAAAAEC3skCcmlFWGYytHwct2msm0AwJMAKgt0rqfMlOmpjM2/Znfm2O1K2KsCn0aRGjo4w==", "8f887e5f-fd58-4bf9-9d15-3902df699dde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0282651a-a0ef-4bd0-a469-286cb195a262", "AQAAAAIAAYagAAAAENp4b4TjTlZS0HDLUnRIZONmWqZ1fLSqRX5deA/h6yMakI4UAoPtHORTGcnl8lgXOg==", "3e28a045-cdff-4f37-959a-1134aeda0685" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 940, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 940, DateTimeKind.Utc).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 940, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 940, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 940, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 940, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 3, 51, 6, 940, DateTimeKind.Utc).AddTicks(4345));
        }
    }
}
