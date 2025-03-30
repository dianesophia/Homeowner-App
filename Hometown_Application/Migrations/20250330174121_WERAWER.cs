using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class WERAWER : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "999" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "999");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "deba6601-9744-4606-88ab-632b5518fea6", "AQAAAAIAAYagAAAAEBwQXVEIKXrdUErWoywYsHdIggeIzT8JyXOd5ZhfKh/TAhIceAMHZaJSe6DrxNK/3g==", "9d4b52b6-b2e5-4b20-aad2-6d4c67ee0440" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38bda470-535b-4acf-ac76-f468d8f2a1f6", "AQAAAAIAAYagAAAAENPNT3naSXsTW7DdRD6mX+bUlIoYZzV/1cmUitbghBntRxNjKHNm51BZWdQR92gjyw==", "4128ed25-15b8-498f-a570-bb429e73342f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51fd2cfd-c464-4714-95ea-db4a98056ba5", "AQAAAAIAAYagAAAAEAsEkfSuWvwKhJktKcwg8fncZ2AezXl97CSWIdFhnsnANWXVErXR8UEk55kr+wRyQw==", "7db15d77-feab-4fe7-a438-199e3f1898f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bf8d2f5-0f0f-4891-aeb0-e296c983c977", "AQAAAAIAAYagAAAAEHPgJ9/pXDdheWhNjjXBoR0Ey1Z+nvJHWoXAXrjWSPLEv7sbjsGGELjYVYy4a1Qq/Q==", "acdd3280-bb60-4141-be55-83475ba93f16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fc948bf-6316-46bc-bb82-20cb2618e1dc", "AQAAAAIAAYagAAAAEOMhInQi91zToxaNPGHhNaxF/vSFQ3AUfioPBqs8MzUr9YKuoo/GTHnMRPdCqZvXWw==", "81279247-f0ec-4193-8075-7c8cb3488ec9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5df7c6bc-4315-4a3c-a957-34104a497888", "AQAAAAIAAYagAAAAEEar79W5+SCYQoTIrh9qc+mj6LO4uCGMGQmfMHg2WKTRtCOEbDRxHiJKtSfQ3Z2+vA==", "8f77f846-11e6-4e49-92e4-e62ad29d23e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daecae19-60ae-434e-9dcb-feceb8cdd4ab", "AQAAAAIAAYagAAAAEDYAlTHsvxQldsG34kUT5bg8069G4oWmlNRVo4PJcjDnbezyS4xMNhj56O/PfE102A==", "30c8ea81-33c6-421e-8f25-d312283cb90a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49bd7c6f-02f7-44ab-b863-ac049feaab8a", "AQAAAAIAAYagAAAAEG+Jo5ltnEDv0qSIk3FLcht5IRipU1cyuEvrLjHEzjDARpiPYhu4xG07AzOClvj0Og==", "618a80b1-2135-46a4-b460-42af7c5a2c19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "421fed23-c81c-4d30-a8e5-7a62b520d105", "AQAAAAIAAYagAAAAEGVX2a9TQ0fHKqarF102Gc2oWaJBfkRYaojmPGOHesB1mL9olIVVX2PbT8uakkH3Bg==", "18e1c7b9-60d3-4d47-8c86-2878771318ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "068df65a-e894-4636-8373-703d11a86e53", "AQAAAAIAAYagAAAAEGVQ39tSn45u0uG+fHeCGJjbtH6SID/RTOXwvd4pEOWIilxkwoQcw7Rw7qnfclTwZA==", "be558662-87ea-4490-9c8c-29f03124105c" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 17, 386, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 17, 386, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 17, 386, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 17, 386, DateTimeKind.Utc).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 17, 386, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 17, 386, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 17, 386, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 17, 386, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 17, 386, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 17, 386, DateTimeKind.Utc).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 17, 386, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 18, 459, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 18, 459, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 18, 459, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 18, 459, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 18, 459, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 18, 459, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 17, 41, 18, 459, DateTimeKind.Utc).AddTicks(7264));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dae3e8e-f032-49b1-aba3-ec15c4b6deaa", "AQAAAAIAAYagAAAAEC6bM0UsVLeNjpRS3MiIhwD1gDpV9U/M2me9nd73IDVZowRYgshMw2LiPrhtgxdaRw==", "e14c7059-e4c8-46e9-bcf1-3194d13a4984" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e1bff29-94de-4e12-ba84-386d11d6a82b", "AQAAAAIAAYagAAAAEEf7xDagiblNDI2iaDz9GF1rQcVALy5S/SsCmsC2HqTlRPIATvqxO+6yWGGoF/rAkg==", "14834ee1-f5bf-42d7-a717-83db15ba14c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "434d2735-e32c-4350-8d01-ae8c4740ef07", "AQAAAAIAAYagAAAAEGABfjy/PEQEnuz8kLJ4JRhLOtMjVhNqAMN1w1JrL+6UFF719vRwuJqtIwlBMZPcpg==", "3ab12dcc-f080-4268-b33b-c3dfede07ae1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c8b234e-446b-43e9-a228-a487f88edfa3", "AQAAAAIAAYagAAAAEPolQZGVKdulcTUYfY5ko47IaEvieeKV08zdKoqDW3pkfvQbmSBb3PQ78tTSuqSTHw==", "5c50e357-0fc5-4202-818a-cb22267e247e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b80c9852-f20e-423e-874c-e99d80cdc601", "AQAAAAIAAYagAAAAEGhsI6OnJiipTGHzhRTWjMPI4Loa6TgaOS1L7Se1HfnKTrIVYut4jh2IA2TBC8vDbQ==", "0f8f6280-e9e6-4c7e-9ff3-cb7ceef83793" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9fa362c-57c1-421b-bfef-cafb12945692", "AQAAAAIAAYagAAAAEBO0Wuu6EtnXQU1D+ChcrBzTAMxofFrbCWjSj4csRTzlcSGNK7Aphtjj2SOy4DB5Sg==", "74133f6f-9f19-44b8-9af0-ca7db1348dde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee708f43-e3a0-49a4-9e0c-7e1fafc0079a", "AQAAAAIAAYagAAAAEK27heW+6pvChQ7Qe7cvVRUpSx1SaDSmRk8LjEBIejXNYl3UlDtYfEH0kwyPWyMtSA==", "df613cb7-fa09-49c1-b532-c9c5af6c260a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac8395a8-3a8a-411a-b7b4-153fd70fe708", "AQAAAAIAAYagAAAAEPUlgRRwl7m5rrp5GGpIAC/46jRWqdzrqqh0njeAxg2IPo3Fubzb4OlYX2HcevUWQw==", "b9361fa4-941c-4639-ad6c-5d4d4759c1ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc8d95d1-6956-4c48-98cb-cb3083520814", "AQAAAAIAAYagAAAAECODDEh76LC1ktgmEsIQ+PH2h3Hx3/lVdCNKTIU+0noZjcfnCu0VXU4zMo+8XA3dgg==", "2396b356-0bcc-4f14-977b-7d6068754851" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01aa9df1-ecaa-49ab-b2a5-36ca10924433", "AQAAAAIAAYagAAAAEKmqW95nXx1KOGiSoJMxhGQjXjSZExjgcU5TD/FbLVvTZAlxcvGOmhvVS+8aar/4vQ==", "9f00bc24-43a9-4d3c-8e15-387fb7af3684" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdminProfilesAdminId", "Bio", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FacebookProfile", "FirstName", "Gender", "HomeownerProfilesHomeownerId", "IsActiveUser", "IsApproved", "IsBirthdayPublic", "IsGenderPublic", "LastName", "LinkedInProfile", "LockoutEnabled", "LockoutEnd", "MakeFacebookPublic", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "StaffProfilesStaffId", "TwitterProfile", "TwoFactorEnabled", "UserName" },
                values: new object[] { "999", 0, null, null, "9a318035-5f7b-4075-8b3e-b9d7727eb579", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@example.com", true, null, "System", null, null, true, false, false, false, "Admin", null, false, null, false, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEM95WSqolXaAXANY6tPO8SVrtBt+xQqLqSgC4DwlWzyxnosTESm3oul1Syq4t85t7w==", null, false, null, "5e6f8bf1-3c91-4e84-b2e6-2f2080406c18", null, null, false, "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 15, 694, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 15, 694, DateTimeKind.Utc).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 15, 694, DateTimeKind.Utc).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 15, 694, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 15, 694, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 15, 694, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 15, 694, DateTimeKind.Utc).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 15, 694, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 15, 694, DateTimeKind.Utc).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 15, 694, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 15, 694, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 16, 359, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 16, 359, DateTimeKind.Utc).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 16, 359, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 16, 359, DateTimeKind.Utc).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 16, 359, DateTimeKind.Utc).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 16, 359, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 30, 17, 25, 16, 359, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "999" });
        }
    }
}
