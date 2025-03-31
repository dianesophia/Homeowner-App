using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class HGFFGRE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BillModelBillId",
                table: "BillItems",
                type: "int",
                nullable: true);

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
                columns: new[] { "AddedOn", "BillModelBillId" },
                values: new object[] { new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1260), null });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                columns: new[] { "AddedOn", "BillModelBillId" },
                values: new object[] { new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1272), null });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 3,
                columns: new[] { "AddedOn", "BillModelBillId" },
                values: new object[] { new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1273), null });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                columns: new[] { "AddedOn", "BillModelBillId" },
                values: new object[] { new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1275), null });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                columns: new[] { "AddedOn", "BillModelBillId" },
                values: new object[] { new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1276), null });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                columns: new[] { "AddedOn", "BillModelBillId" },
                values: new object[] { new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1278), null });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                columns: new[] { "AddedOn", "BillModelBillId" },
                values: new object[] { new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1280), null });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                columns: new[] { "AddedOn", "BillModelBillId" },
                values: new object[] { new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1282), null });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                columns: new[] { "AddedOn", "BillModelBillId" },
                values: new object[] { new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1286), null });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                columns: new[] { "AddedOn", "BillModelBillId" },
                values: new object[] { new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1288), null });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                columns: new[] { "AddedOn", "BillModelBillId" },
                values: new object[] { new DateTime(2025, 3, 31, 3, 51, 6, 116, DateTimeKind.Utc).AddTicks(1289), null });

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

            migrationBuilder.CreateIndex(
                name: "IX_BillItems_BillModelBillId",
                table: "BillItems",
                column: "BillModelBillId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillItems_Bills_BillModelBillId",
                table: "BillItems",
                column: "BillModelBillId",
                principalTable: "Bills",
                principalColumn: "BillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillItems_Bills_BillModelBillId",
                table: "BillItems");

            migrationBuilder.DropIndex(
                name: "IX_BillItems_BillModelBillId",
                table: "BillItems");

            migrationBuilder.DropColumn(
                name: "BillModelBillId",
                table: "BillItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e218362-4e8e-4ea4-ba0e-35474a414cb5", "AQAAAAIAAYagAAAAENO5XOodSAb1Et1CofDgmJccdFNUycWLArW5sWPxHVoj+PZDxp1hJ4m1kheKOPKJGw==", "31ae6f24-9fd8-442c-9d81-f5ae703c7bb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0c269ba-6306-4c86-bd62-990a51578b74", "AQAAAAIAAYagAAAAEKejs6xpFQlymImgihJdVwOYo7X2q2ZMM3qTATyPzLonmeNpTucM2eoI1XU6YK5A5g==", "ee9b009d-0329-490f-bb34-5a6f3ab9206e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a74695e-f031-4ee6-b1b9-1545e671e1a5", "AQAAAAIAAYagAAAAEDNKqCt4M8uoGZ3H89PBMaUNtry/wPxJvTH+eQ0/h/JCtC7HSiZOkPDogPa629v2Yg==", "9356cfd5-6c20-4f97-8066-03350f48a3fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31a81d4b-7ab0-4f9c-92a8-f75042134479", "AQAAAAIAAYagAAAAEPTlLHb0ioKC29MEybTWKepCeSRsGs/ZIMGomOUoiVR2TEhktq1WAMzzMgw2Ul4dKA==", "1cede40a-2626-421e-af08-dfda36625ee5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "440b2152-680e-445b-aecd-ada348c6b3b0", "AQAAAAIAAYagAAAAEEgme8dGz+kIsOWXimQJ5Ecwhdl+oYh6bSNnG5qN9ugQGtag9t2+dGgFBA+GlciKBw==", "5e6becd2-a543-4087-b019-15ab480398db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4cc9c0d-18bf-485d-918e-40f28fd29fa3", "AQAAAAIAAYagAAAAEGY0kQqH2TO6pMNGcPqRZlTUQiLXKrxyvpb7RJ61ncTylWPaxUT/J6dQ7MCG/CKTDg==", "376815fd-ba9f-4f76-8ad0-901338335001" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d393c0dc-250c-4c3e-a91a-4a19c9dfd63c", "AQAAAAIAAYagAAAAEBQGSiU2s7wlIZQvyL6UqRi/DL4rQJTexhwz0URZ9um+URf0nS8aPvtMa+9tpn6E5g==", "26d46e4e-e602-4b22-9309-b3cf5b8d96cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f837187-c49e-432e-816d-7d2ead634b23", "AQAAAAIAAYagAAAAEARlxJdz9fkU6JqnsTy1X+MlYsLXPZkeyX8VU0jdNqlVphxglys9m+IAjsse9Hmq9Q==", "e964a2f1-7ff9-4ab2-965c-e7fd8fbc0042" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2614d67b-bb52-462b-b16e-dc4619e94f1e", "AQAAAAIAAYagAAAAEMN1BqODOcdiUTO0h1YgzW6piRnDT4nnZY+77XsZOU+KNAVi+/dR/WBreyU3uaw6rg==", "9618d4b7-1651-4690-8f55-6008ed7cd1e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d23d2f6-9079-4e0e-9842-9779e4748900", "AQAAAAIAAYagAAAAEKZl5JB0GmrOCzLZoXzIaNiuT2SYwWqg4uLMiQzRMyxvy0QGHguHWO3tPibYJ5RysA==", "af6ec6a9-374c-49b2-a296-b38874dc959a" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 284, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 284, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 284, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 284, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 284, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 284, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 284, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 284, DateTimeKind.Utc).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 284, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 284, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 284, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 947, DateTimeKind.Utc).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 947, DateTimeKind.Utc).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 947, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 947, DateTimeKind.Utc).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 947, DateTimeKind.Utc).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 947, DateTimeKind.Utc).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 18, 56, 58, 947, DateTimeKind.Utc).AddTicks(5361));
        }
    }
}
