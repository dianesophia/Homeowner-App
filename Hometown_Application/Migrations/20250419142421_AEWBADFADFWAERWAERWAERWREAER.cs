using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class AEWBADFADFWAERWAERWAERWREAER : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BillFee",
                columns: table => new
                {
                    BillFeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillAssignmentId = table.Column<int>(type: "int", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillFee", x => x.BillFeeID);
                    table.ForeignKey(
                        name: "FK_BillFee_BillAssignment_BillAssignmentId",
                        column: x => x.BillAssignmentId,
                        principalTable: "BillAssignment",
                        principalColumn: "BillAssignmentId");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "618cdbde-a5eb-4ef9-9e70-66ff6c77e721", "AQAAAAIAAYagAAAAEAHcP53WOuEaodvKs6HS+4UNdNdFaE1VazGiTu8+S12ow7CAeCG6ERW0Giu5q6cDUA==", "d2d50354-2a1c-4ebc-b43b-a551ce637ebd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "374592ce-bf4f-4500-b494-a93cdd3d2578", "AQAAAAIAAYagAAAAELJR8CVEVEBjdfctLQQgL9A0G0j2rmPTsIQc/pUoRfXyj1R/Rq1lcIq5kFXuvghqyw==", "8785801b-c7aa-4346-94f1-d99ce9417f48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf181a4f-5e2b-4bab-af4d-92497d63ea08", "AQAAAAIAAYagAAAAEOF/m9NpBlKAcn8nZerwouxxi5Bc/1AbheZm9yN/0PMMfcwy460LqVGXgbPdXuoxew==", "cc565096-52a5-468c-ab49-df6700dbc824" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90d9f75d-afd3-4b73-bcf7-4bf968862ba1", "AQAAAAIAAYagAAAAEKsGEdjRNorb/wlcsfbxMBK5JFnQOqxnQ7u9WTe7C0EORfG0fw+JyuVujvw1D5fKNw==", "12ce1ccb-2d4a-48ce-a50f-b9434efae029" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "262ccdac-a9d4-40ac-9130-bba82a77ac0b", "AQAAAAIAAYagAAAAEMXQEcZTBgFB9PLiHPZ3dChbs3DpF5Jw1iUeTa+F3UHNEfEVJN2cfjhvDoMk6oUdgg==", "59de2998-ca98-4ed8-8bb8-f0c2493ddcce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c59f657-547d-4bcc-bb24-f7e23a909cbb", "AQAAAAIAAYagAAAAEAxSIqRBTTThoZuZRQqXHMP8u1tWNB+T7AiZDkT0FAz11nem8BmNLrMAT662AMmlmQ==", "8b9006e7-4c28-40f5-aa7f-4475420c6338" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f86bc4c5-1457-433e-bddc-34a125c782ca", "AQAAAAIAAYagAAAAEObSWppl4aSumygYivHRL0D0xB8xtK0Miou7FsAToa7XJr5hhgqt96qs9+3hkdu2pA==", "57567711-6b29-4f7b-9d15-bbdc6be5e3a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15c6be35-1f6d-40c2-aed1-34b2612be4af", "AQAAAAIAAYagAAAAEOgeERxqF6YqUYPiXAua63e9xoT5B0XftigEnth5bWy+Rm7UUyXxGUp+xiiqZx+NmQ==", "ae10b220-11db-442f-9e5f-0a7b5cb73e45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7703ec10-aed6-4d9a-b258-d6805f32a071", "AQAAAAIAAYagAAAAEA4kOrCZ6tmddepByTqUljPo4oxTQqlnRV9qR+lMwKUS/Ni3sGrmnCb+aDaUEJI9cQ==", "e33e2c6b-de44-4c02-a2eb-61cc2818a8f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "079c51bf-f195-48ae-9e61-19ec7adfc9d2", "AQAAAAIAAYagAAAAECDMXThi0NJYhug69o3MqZfNH2X71r4SRxArdPRsnXLiTme1mpj99skHU/4X0o4p7Q==", "a9b8a530-410e-411a-aa47-fbc47b98ce34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e145c68-da8c-474d-90a4-553827225738", "AQAAAAIAAYagAAAAEGbvNzIMDOhp3nztU+aCjR9d6n9yFBsD/eYHN+IKyU0O9aA8Z1jzfDmIAEXQwSobHw==", "1da98810-882f-4082-91c7-6177c95a3861" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "336f0b7e-b503-42ad-a37d-b47fe66680e8", "AQAAAAIAAYagAAAAEIpjeaDGi43VS3KjETJVh0bfS3OnvD4D0uKPq01Loh1XnUHNv3cYdlUwTVr2BfWA6Q==", "a5fd6837-da0e-4512-b29a-b6b00dc6e524" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "113",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83296a0b-83ff-475a-a0ed-5941f1aee17b", "AQAAAAIAAYagAAAAEBFmKvWAKA3zRSZSKxpEjZ1Zjy4D555TYTfk1caucy0vdDBR7N+sTZbhv4tVktOS5g==", "efdd860f-3ab6-4b0c-be45-2c6ffe94911b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "114",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dee569c-7613-4ff1-8845-121b4f53f442", "AQAAAAIAAYagAAAAEHL9U6l0eLhcUFEOwF14er8n5apkSvE4Tqofr9k7v8ALsoatRAs4ekJf2ksJqY3SqA==", "96d62f55-04bd-4641-9c78-3a4fcaab5079" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "115",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56d00844-8c4c-4139-a9ad-c0a0c0c02531", "AQAAAAIAAYagAAAAEHKmbWkZzENNkpLab7ogX+fDqUHyYlsjiI0vtxp4yefXZUnen9/qn8DyQmLzipWCHQ==", "51f328fb-364d-4a8b-9142-96ed31a89a03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "116",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b90dbb75-0793-4ebd-90a2-e0476fc1f672", "AQAAAAIAAYagAAAAEMJcIiNHWV8k0WsC4NrE8y+iIS5m/jEcSoIoAdRqCaCnVnZ1++0tJGBq+Md41N+ZaQ==", "a5522952-b769-48f6-98a7-cd6d6e0f77c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "117",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1b33bbe-bacc-40cb-acab-349c2cfba0ef", "AQAAAAIAAYagAAAAEEtGhFBLSN8oiXTA7JS3HFqssBQpEEmMtKkmj/h+U97bmOqSDr87XH4v+psxVTCPOQ==", "b8003512-436a-4aff-9502-e60345929c8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b4d9952-855b-4952-b19b-5e3ee1cbc105", "AQAAAAIAAYagAAAAEAXa9wt+Cl/yeRj3hH7Fu9xbzCZCx5KbaJ0ksyzWgWoozOcSQFmFZAXfSlIzahqccw==", "cb67373d-ce0d-4064-90d6-d019293ac8c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e8613f7-77d6-4414-aad9-fe31a4fbbff0", "AQAAAAIAAYagAAAAEG0WkAZSTVnCAeM3uq6ePzrRGjemEAj4e/bprcc+JE1j4qWSz8/0FR30/SwYAQyBTA==", "f990f391-b611-490e-99aa-fffb40ba11f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "369081d9-520c-4e8b-b263-66b1b2710110", "AQAAAAIAAYagAAAAEF3kFgO4D70EZPhylcAEjf3Ym1EsPCiiJMQ8GfQ644FK9BBByFmKfpx8CWR0pLV+iQ==", "d7e0835e-d1d0-4933-b037-5c4afe3a4762" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "121",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4996c661-3470-4a4b-8dc5-3de5fb91b630", "AQAAAAIAAYagAAAAEIQG+M/I4rVGk3jvePM/XziOSjmk9EuPG3i5WVShjZgNabKm7FJLKsthfIQL1z2I3w==", "365cf36a-ab1e-430e-bb21-aafaafeb5beb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7a3a7b8-1089-41b2-8246-c79b5b6b4956", "AQAAAAIAAYagAAAAEJoZUu+/SE0uuftoFdyJz7Ouxl8LLoU6IbUizD5ShU6C/0zwJrsE4UKpC1sVr0l1iQ==", "920cde80-94b7-42ce-a06a-58e367c3031e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "980f5cc7-8401-4d63-a3fe-07eafc8caeb7", "AQAAAAIAAYagAAAAEPAsO8fnuFveramibVOQbnwSj/FpQk3fbwdXPNh9YoRe8UIk0vUIzF1xEHr2vziYew==", "56aaec22-5222-4160-960a-157094814daf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbee5781-4c8b-497f-af84-1cf62c03d4f4", "AQAAAAIAAYagAAAAEOojnsXr07IpESk/BVCl9wI8S3ERmjcl56aFWaJNC1rTNyF/CZ60MpCmt9Qfe4r0/g==", "72522148-192e-4489-8e1c-83f245bccdb1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "125",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2af08b6e-d020-41a0-86b2-045d19072801", "AQAAAAIAAYagAAAAECjG2PrDYSqODKIKCgSe3RAYeL1jV+njeF4MXDUGSPIz0KIMTo7X6RQToeMxyv5ohQ==", "2530c571-cf0e-47ce-ae74-31b0375bb861" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "126",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1aa87887-4973-419f-ba97-bbea2a198934", "AQAAAAIAAYagAAAAEFX83sGmjNmWrw//WAIF/NeYMDCMIBg0oCvGgbfYlclwri8KpgSab+uvuayINfrMBw==", "7bd5d1af-ee26-4190-b92e-16ef8dee43d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af4ab2bb-9e98-4d28-b499-22801dfea937", "AQAAAAIAAYagAAAAEAal3Dhrwz8vfMOp/IYSKGqbEUaAy7vFmJJNOyIc65a+lRHCGw4/37fwnxtEeBvx+Q==", "0e4451cf-331e-49ac-8661-bf3e13aca799" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "128",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f7c433e-b175-4ec3-8c24-348acfd3df7c", "AQAAAAIAAYagAAAAEJId8LQxBzVufri0TqRIzMY8+fkGROXkgFxxQe+Cr7ys7GxnD2KnCppwOGwWQ1Yurw==", "a1c6ba7f-2a95-4d73-b46a-f820aa45da20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab7bef79-a2ee-4317-8e5f-a968daa74739", "AQAAAAIAAYagAAAAEK2TRXa1BwlHXCqsHKBThfe2W5HQurJj5cA8dlDtf/XMeiV6KudRA2GVBvQdQLXpjg==", "d1759cf8-62a9-47e6-9e89-8040d713267c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "130",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dbdb8e0-8623-41c2-b843-6adbaca4bbd9", "AQAAAAIAAYagAAAAEGb3gWBxvcRRekD6LOzFF8dWwj3St+LSuuCVa1tB0B+MMO2ZORKVSw6jkEjcZuU/AA==", "2237ccaf-138f-4a5b-bf7c-956c90e07dcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db064593-2e03-4e79-9158-45232885047c", "AQAAAAIAAYagAAAAENsAUOOSgE38blXKBMLDC2fDgyWiWRBIa0CjNtP1jkZM+QbS38T6mmuzxmLvg6tOhQ==", "79d98bd3-47aa-4254-afc9-0fdba15b1229" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "132",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e3aab12-6f5e-4c75-8aad-b387965862fb", "AQAAAAIAAYagAAAAEI1/eG1qv4aX5wjdVtw6eEmU4aqHZa6HtP7IjVXlW7f7jP/MzbqTaM/sUnJ4gnNv2g==", "6a2fb49f-b316-4aef-9fba-4d6679bdc0cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "133",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cbc493a-4faf-481a-a108-514f6b0ea02a", "AQAAAAIAAYagAAAAEIM21B2bl/6fwpg4cfWMMg1S+oT/xGbp98aKnPqWNU5Drc8fdf0KgdYqgo6QMuWCmQ==", "3b9bc013-0a1b-4162-8be7-7fc6c6c8313b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0547f7f1-1bac-4cd1-b586-3db3ce0fbbe7", "AQAAAAIAAYagAAAAEJ6jxngZbv9hTOymMFnrX1RPdtfARxQld6TxeaAo7g7E8EVMLV4Bok1sMz9vs4A4Qw==", "b474f43f-82b9-4c4a-9c58-1d061fdddcc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "135",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e18c1526-0b94-4127-8b11-ed51a2a0dcc7", "AQAAAAIAAYagAAAAEOj6eGG9PX7w9W7wF6TxkIu9RS5gZHDcornGqfxeTsVkkv1GSZeW+SMT8y6cZ4bxsQ==", "8fe8a3a0-191f-4a35-b31d-ee07961d44c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "136",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69c47e9b-0ef0-4bd4-b498-401589a1ccf8", "AQAAAAIAAYagAAAAEJnbiUWG5kAlviHT7HT8d9OZ8hhT8EP5r02WmaScE0zREFCA+CZwv+8Hvc9xlO89IA==", "f7aa5b3d-a9f6-4379-9f93-3302f449bb83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "137",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3100fb7b-95e6-4ce2-a474-470c25251726", "AQAAAAIAAYagAAAAELd6I9Pv5BXD4YUdmjT+5T4Oc6MdF9m3tXwSIgPBi9jPCOsTV+wxxlsP1/QSDXF5/w==", "471550e0-68f4-401a-8218-a57b5c10b07a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "138",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64b3fe0a-01f3-409e-af0a-f6e55b3ea2bc", "AQAAAAIAAYagAAAAEC3FcnGCIb6aO+vXUOFL/HKJkKjuhOM3gOL0ts9w30+JBK3C8uJzoHDI6P1ef6QV/A==", "25877b92-512c-40bf-94cd-5fe7b4c81fc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "139",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11711c39-a272-4369-88d3-b47e83bbd7de", "AQAAAAIAAYagAAAAEDPHsEtyUH57JOonJUQxWdTCOvUSbpJ5L5vbwHplaAgHxzb/JRbdVw4Wofv7Gi8ZCw==", "85f4fccd-e444-4499-8477-a611fdb30bc7" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 16, 441, DateTimeKind.Utc).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 16, 441, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 16, 441, DateTimeKind.Utc).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 16, 441, DateTimeKind.Utc).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 16, 441, DateTimeKind.Utc).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 16, 441, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 16, 441, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 16, 441, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 16, 441, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 16, 441, DateTimeKind.Utc).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 1,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(608), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(607), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(608), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 2,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(614), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(613), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(613), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 3,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(616), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(615), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(616), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 4,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(619), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(618), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(618), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 5,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(621), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(620), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(620), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 6,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(696), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(695), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(695), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 7,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(698), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(697), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(698), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 8,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(700), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(699), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(700), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 9,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(703), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(702), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(702), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 10,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(705), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(704), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(704), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 11,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(707), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(706), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(706), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 12,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(710), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(709), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(710), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(711) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 13,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(712), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(711), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(712), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 14,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(714), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(713), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(714), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 15,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(717), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(716), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(716), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 16,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(719), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(718), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(718), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 17,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(721), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(720), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(720), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 18,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(723), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(722), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(723), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 19,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(725), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(724), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(725), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 20,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(727), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(726), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(727), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 21,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(730), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(729), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(729), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 22,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(732), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(731), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(731), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 23,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(734), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(733), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(733), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 24,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(736), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(735), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(736), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 25,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(740), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(739), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(740), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 26,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(742), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(741), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(742), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 27,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(745), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(744), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(744), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 28,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(750), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(749), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(749), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 29,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(752), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(751), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(751), new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 8,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 9,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 10,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 14, 24, 18, 842, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.CreateIndex(
                name: "IX_BillFee_BillAssignmentId",
                table: "BillFee",
                column: "BillAssignmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillFee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6402c88f-6976-44a0-a277-6b99fab3786b", "AQAAAAIAAYagAAAAEBuksObrNs9Wvv60HRvIF277c5vVFwLtAMYDMmq9HRpBpZkaDas17nV9Tb5zjlIhmw==", "1340f653-8319-41d6-b7b1-63e6b056adda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "060e9c7a-eddb-408e-87b7-5e558f088dc2", "AQAAAAIAAYagAAAAEFGVF9Gt9nHopXcc5DJGteIEb+FH7pvDbu2VglRqGpxXKrTfIebLxE3+R7yV4/LqxQ==", "6a9a4b1d-3a1f-4298-aede-5976279673c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f34ab57d-7018-4ecc-b21a-c1c410c1c5fe", "AQAAAAIAAYagAAAAEEn1VPp18SHnAI7p860BxxsQCPWcwtM49pKQbw7ZVU3ZYVx+p6ZxpoRbuxbuFcqGpQ==", "0bbf7c96-66f7-4e47-bd69-2e1aebe1f6c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b606c88-11a9-45ab-b902-70a1d8a83563", "AQAAAAIAAYagAAAAEGy39OcZZ1cKo2ijkj1YyleXuLgFaOaNwV5V4edjA6X3CWBaLLYoXUne0hOCoyi9NA==", "b5879c07-fee6-48bf-bccf-af4e50d7f3f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36a8c0a1-a230-4928-9146-e634d7d3d72d", "AQAAAAIAAYagAAAAEHAvp82Cz88ebvm7eHX7T8NKwMEeyKmGgUNqS4cOeTctNo8oooaNBuVAp0OsLl1xng==", "b1a9835b-df2f-40dd-8176-ecfbb3219e2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6acbced5-e394-4d33-948a-d366543d8518", "AQAAAAIAAYagAAAAEMdbqpqnxBaZ7BYhtry6ssHDFFGRUKxL0yZgSOOQc3NRW9R3GcGihfmiclz3xO716g==", "a57ba433-c57c-4c85-9f70-dd896c483a36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b86021b1-1fb3-4b88-a85c-eabf85066774", "AQAAAAIAAYagAAAAEAPUuiqCobZohGFkUvBv1SR2VHdNArHYiZ5viEfVl2OxOpgVh8MVmXZ+IBHf8kDE/A==", "0792187c-0d2d-42e6-907f-38c37fda875f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f6ca456-ff79-49c2-96ca-10fac751080e", "AQAAAAIAAYagAAAAEGIrxZiF+xLPuYy3SRpKHYY3yeWKP5J2ItbSre4FYD0NwqJF7X0X2MHyrf9wzR3reA==", "9bee13d9-e8bb-46a5-9ff9-5bdc23eaa9a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67edf8b6-ba1b-4198-965d-e0612782dc9a", "AQAAAAIAAYagAAAAEJNIZAtllESiMwYzy3855evoTcQG9lzvImSDzvD81uqRcGTT2y3FF+SVfLjPx5+dgw==", "4cae2c3e-d32a-44e6-8dcd-198a19c093b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf110349-33e1-40ea-8e91-40875cfe4f91", "AQAAAAIAAYagAAAAELMLzmRYqaGnoZ7mBFDKVpzrgBOyHhx4wzrH9ahHQFy4b+p25/ehUOnSUHntqU1tpA==", "68669bbe-cdab-44fa-beb9-378c734eeef9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2eac87bc-cae9-4bb7-91f7-5735d5c3a4ae", "AQAAAAIAAYagAAAAECh7Xj0/Gga6Lq0lcEIUy0P3utdvoaLx8q5PorNXwH5uPnJ7XGaCzJ/1W/+SE6S+iA==", "27f58344-1f09-4a02-942d-a4aa84db9d2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b27134d-daf9-40e1-8d77-872d1c41b12e", "AQAAAAIAAYagAAAAEHyatggnxQiGUuYABqXTvovthIf8G7YmSHlx7MSlaA106ncTaQvORIf4YSZNilQwqg==", "0ecd2041-dd3b-4cb5-b3cd-2b9d73471188" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "113",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d1fbbb8-7cbd-4877-9676-86bdfeb9eae9", "AQAAAAIAAYagAAAAEPzBjOtED4wMxiHDzqvwNzAKEtFOL1qgxZ1o9gsPfFZ6bw+ilERrJnrYJARmUDZKBQ==", "45f58ffd-09b6-4961-a996-db9dad770b9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "114",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61b97a76-e1a8-45bd-82a4-04e04f1ccf9d", "AQAAAAIAAYagAAAAEEjVz2VgcRWlsEOAhWLhLjzKjIcslrUoKW6KtDCQ7RUr6XnuuDMtIVZAPlO/n5MkKw==", "bd79e73a-7182-4739-9d02-872b4e6ed013" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "115",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0cc08d3-85d6-44f6-b37d-b7bfa459a2d9", "AQAAAAIAAYagAAAAEJdBN0THBY7EOeb6nmmLJoFl8CPCXObSXNGO/kpdFFu91fwOWR1Th7Fsvu6ztmBoxw==", "e1ea2f9e-ceb1-4ce3-9e69-6afa8e0653d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "116",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a18eadf9-9043-44b6-a4ce-6d23efd95ba9", "AQAAAAIAAYagAAAAEK6dwtJ4RU2dGPr/fNXoV+h3NpN3y9w08/QEOxSztowq7eX8Pe6EWZAnHlkiTf22vQ==", "219072e9-c8be-4c92-a206-39a31c0cb5e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "117",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9700a439-a9a0-4625-ad1e-a49ceb4bd91b", "AQAAAAIAAYagAAAAEDFppVfgONzgRinXZY7eD+smCD5XB39cpwdG8t1Etqoj/vqcSwL8fO30sh+NNjsOEw==", "3735ad1c-fec0-48ce-a488-5c2c29a517da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b70c22d-1c2b-42de-b526-6727cff285cb", "AQAAAAIAAYagAAAAEGsJZPWCfJ7Y32iMF1vkeji5nKJWhk8HyM0xMTZELwRhmnU2YyUZozwLVyY8nsvswQ==", "1d2644d6-e709-4289-8e0c-2b6e502a923b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ebe9e09-9e2c-4fbe-abc2-64e83cb16e40", "AQAAAAIAAYagAAAAEPa0/Ky4pLDME9GPVe/DYnTwmPSRnqGMCUnPjTg0LRf4xVvk6e3ZRRVahZVcsx32sQ==", "6ee64b38-4d63-4032-8b95-d55d040ab21e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42313b55-8a5c-4883-aed5-d3babb82e30c", "AQAAAAIAAYagAAAAEO7oMusWKA8m/auuItwTq8K/ZLgKrwKPCugvbT1CwugC7RLo3kskYVj4l9hvKR7iBQ==", "c759eae9-1bd1-46a8-8a2e-7fc8add0e5d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "121",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a9c8d71-b9e2-4ea2-bde6-4a02fb9fdf99", "AQAAAAIAAYagAAAAEDz5682hyUefh8Sf23ewljw6jOGRR4tGbsz6hah8Ha+XkXaQtwD04+o9aX/I4UJgfQ==", "094a8ce7-8924-4e14-a90f-fd9d6b331ab7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "797e9ed4-7d76-4c2b-8bc4-1feb149771b0", "AQAAAAIAAYagAAAAEFtP2c7J0sTrltIqNQw/62mFuHi12Vj2casQctFcVxjXV78fJTRBiIU6Itwh4uTzGw==", "2e23dd1d-bb3c-4aaf-81aa-06ecf1124283" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a759d962-c0c3-40ad-8435-b5767a25088b", "AQAAAAIAAYagAAAAEMHUIR0I5LLLf4ezqKM3yXw1kw6/40LdtscrcFRmKJLHIUourAtN1xVIDku/7HII8w==", "fe69e5a9-4688-4fdf-b153-8a2e696ad454" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6705e141-beb0-4c34-9d05-017259b4634d", "AQAAAAIAAYagAAAAEN2/B0iPZ+FV8vbN4O5E45/qwqNHvjvxtVVEPUWERA53rwC887gYYTQJmsSN1QBqXw==", "3891bb44-6976-47c4-9e09-319363f73e04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "125",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74a5b36a-4d04-4d65-a121-722238a51339", "AQAAAAIAAYagAAAAECY5OtbdeYCae9po/yvHqK1my/o0ROunY+ulpzvSZUVZ/fmuAxfodumuSBuTJkf0dQ==", "e6c3f253-69fe-407d-9fbe-b8c8c6a3974e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "126",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "423a4363-0b3f-428c-bc03-fa7b6095df05", "AQAAAAIAAYagAAAAECpgQpuA51t2duL8aV5hfNDIlp4EgxGsMSC0ioo0x3AidzMX4hGd/MYxqqmwrMVpCQ==", "65eb5694-acdc-4571-94e5-18ec845a45a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3c978e0-d8c6-4203-9e41-13d4733fc98f", "AQAAAAIAAYagAAAAEH2AmCt9YphPJAhd3iYBKvOFGD0ZaC6LOaVbIip0dqdrt8p8qLCxLXG78p8LQJE4ew==", "3dee0a2d-edeb-4f88-ac4d-6b1fd6d83c49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "128",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "765f7ed7-7d90-4492-a72d-a9fc9db5182c", "AQAAAAIAAYagAAAAEP2PQNZm9TeuTajScoizGlY4x+Pk66RgGoGJrvWIMzs65IeDBAJ6dM8+2v+fR8yw6g==", "f0e4cb08-80ad-46de-b440-e8ad7faeb749" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c9d2275-8a4b-404d-87db-67fcee529795", "AQAAAAIAAYagAAAAEF84a5Uhh3b62OtF7QuMFTc+yEtKkMehAop7qFJHJM+2u55/b+b5D5CJ7I4R95uH/A==", "fc9f8829-7493-4f6f-b805-2eb93e21de37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "130",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36177973-071e-4ade-9932-5b355ad24fee", "AQAAAAIAAYagAAAAEDbGFPMGskokOCNwGvcfjMgjw/YLYEwKbmgE42YLXrGqWjlLFCFA3AYq975hW2I6EQ==", "7c211f86-a640-48ff-86b4-b5471b8f9e9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c04a1612-f6b8-44e3-b259-9e71e128d1ee", "AQAAAAIAAYagAAAAEJC21nLb1m9xIvjmrIh/i25XdcYoUV5G+GZEqEzAzktRmFSUCmcBsgmrvKilIqkgRQ==", "96f7360b-1be9-485c-9622-e0effe29f0e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "132",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5bf05b5-e966-4e8c-82de-55e650deca53", "AQAAAAIAAYagAAAAEFsNwiTgWPxG64qX39T8uwPSfCADMKo8JXFmjk6B/AVk2ta+qXQBqim+iVUYzGk10Q==", "d8eee299-aa83-427b-8ecf-f453ea71c1a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "133",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb6ba597-5b73-4701-854d-7d4f563f8c3b", "AQAAAAIAAYagAAAAENH5Uozl9Wd9/zEgcLjC57Ovkb1zUficup//LWdtGMbb3d1cCPVCCtgDfXTLAIYnmA==", "91879f2d-d15f-40dd-963b-fc797ffc6d73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65b5c0a3-8f5a-4544-86dd-9c95ab34d20f", "AQAAAAIAAYagAAAAEE+/qw65DkX5MtxpgBDP9r6Qxfrbx6QOQd+fKKoMBnA9B7a9rTYGewGFSJ1C1Y1t4w==", "0366ef9d-5676-4135-b624-ce79938d5098" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "135",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3004970a-bd26-43a3-beda-34002cc37ad8", "AQAAAAIAAYagAAAAEMEldomNc84JTalsiRif7H6BI5ejz3vGRcCpRVCT02Ej3JzrQUcZLVJHNXGqoM02bA==", "a079826e-1196-49e2-88dd-7b8054d5d5bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "136",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10e0096c-6c6d-4b3f-b1c0-a72785d9b45d", "AQAAAAIAAYagAAAAEMa98LJdIS05hcoOFDWsur++IAO1/sl4bNfYAYvfXq1l7UpVORXpWx+bZ+16nXzqZQ==", "b3c80965-af23-4aa3-a2b7-8156cafa060d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "137",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e42189a-80d1-4a61-be6e-e56deff6f07e", "AQAAAAIAAYagAAAAELNUPbY5IqYpMD8mLww4tfN4gEE3e8jyOPVLJY7Qv8LFcP1XEMar9+bEVBhvFaKmEA==", "a1328c1b-1fc6-4872-a624-19e211fda161" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "138",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "951778c6-d1ff-4ffb-98df-38d9b2dbd532", "AQAAAAIAAYagAAAAEEQbaAXj2gjy352PK21mZM2tI8ouMMrPm7aT0wsClLfL7OFoeaQ6jtMp877Vul00OA==", "33d0f66a-cbd9-4420-b42c-740f52a73a32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "139",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2a54ea3-d890-4fba-95d2-3e8f58646ac6", "AQAAAAIAAYagAAAAEJtAGChkEH05yPMtROA+Rdx09FK5LRHil59nhV85HXkK0rO3dYU8H5fmw3wEuWGrLQ==", "bd602930-2701-4601-8c4f-d2153a45add7" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 17, 211, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 17, 211, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 17, 211, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 17, 211, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 17, 211, DateTimeKind.Utc).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 17, 211, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 17, 211, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 17, 211, DateTimeKind.Utc).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 17, 211, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 17, 211, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 1,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(970), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(969), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(969), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 2,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(975), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(974), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(975), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 3,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(984), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(976), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(983), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 4,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(986), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(985), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(985), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 5,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(988), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(987), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(987), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 6,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(990), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(989), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(989), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 7,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(991), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(991), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(991), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 8,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(993), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(992), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(993), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 9,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(995), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(994), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(995), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 10,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(997), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(996), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(997), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 11,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(999), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(998), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(998), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 12,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1001), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1000), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1000), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 13,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1003), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1002), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1002), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 14,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1005), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1004), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1004), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 15,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1006), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1006), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1006), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 16,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1008), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1007), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1008), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 17,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1010), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1009), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1010), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 18,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1012), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1011), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1012), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 19,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1014), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1013), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1014), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 20,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1016), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1015), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1015), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 21,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1018), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1017), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1017), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 22,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1020), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1019), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1019), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 23,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1022), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1021), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1021), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 24,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1023), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1023), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1023), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 25,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1025), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1024), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1025), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 26,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1027), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1026), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1027), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 27,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1029), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1028), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1029), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 28,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1031), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1030), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1030), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1031) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 29,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1033), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1032), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1032), new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 8,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 9,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 10,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 12, 48, 18, 957, DateTimeKind.Utc).AddTicks(875));
        }
    }
}
