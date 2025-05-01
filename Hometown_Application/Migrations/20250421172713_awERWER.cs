using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class awERWER : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ExitDate",
                table: "VisitorGatepasses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c99afa1a-ac2f-4fe0-b606-19ad65f5ba91", "AQAAAAIAAYagAAAAEJCBiQTPDBaf2o3Kc3Y5ygg0UQ7r76tq0NX0kFt3NVkatwco8XGfSam+MkZOWOJxig==", "40ae58bc-59c8-41bf-9b65-e729bcee666e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06fed77d-0f95-44ab-a7e9-3abfba4ce5e0", "AQAAAAIAAYagAAAAEEuMd2vxTJJekMM3HWZXVeOTBvz3/EywfRcE9uVM48mzgnWmAHkPyuni34IEZIHMxA==", "0dacd6e9-c5b6-4246-b503-22b6759989cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5abaae8-e4e3-4616-a0e1-1982ffb52d3c", "AQAAAAIAAYagAAAAEIgeFloqlCurdXtXxNpr2rmnpzZdRPZmRSjdmdFI/wgzYRVTUbSyMtZiQ6zhPWQ92Q==", "05180134-f298-4054-9566-787bad199b0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ef09b92-3cf8-4088-89ac-8686979a1beb", "AQAAAAIAAYagAAAAEPcvySwWC36Tp6v3iL2Jy3QL00MbPux8iu1Yav0gDJ8zGDJxKj7icx2qX4se9Uwr2w==", "adf927ca-84b7-48ed-a60e-0218fb56fa53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ded7c19-817f-429f-9c83-0b645475cd44", "AQAAAAIAAYagAAAAEG19fOtsvOKVb1iP4g8NHZFesBSXj9tLDBC2KN0W3lQGBOQyBqtzeMwoEAyMY02tfg==", "3eeaba13-d558-4919-b1de-4fcfcddc542b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc1b6d4f-ad5b-400c-9a2b-c257ad23cb2a", "AQAAAAIAAYagAAAAEJfhq1AY4J3a95z6iI8coDYE5Cm4VphAisis8kxltWafAL5MgoGGV0dVgHcWsulvWQ==", "08e68bef-b97a-4723-9a18-007a944d1db1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c2ac445-9be7-4c3b-9f61-88a131b50b1a", "AQAAAAIAAYagAAAAEJTSv7cMQeu3I46HxVA176TYD+a2/msmwxxtGVoxGn6LeD3hiwRKfr+fnG9qZ8uRwQ==", "20de8eda-ee65-4f84-90ab-87e8998d7ae4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "040048dd-0d60-43b5-bfd1-ddb7ec76062d", "AQAAAAIAAYagAAAAEFKuFKL1JEqkd24SpQ91aJwrXjVaF+IDvdh/OVJ16Um+w6TcjpxeBk8uipvFVE8SXA==", "3b830a9f-fe3f-4675-a742-0d4ef5534f1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "408b80e2-3979-4ab4-b301-7c07081849c5", "AQAAAAIAAYagAAAAEEnMwBE0OG6Dzame2V7MDAJNuQEHY4k5yJQxyQ5rq+2ikjOmFAHK25CA1xPUnoqx5w==", "84887877-1d6b-4c50-b2c3-795099b3d212" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5117098d-aedb-4cfb-9c64-84b2f84ba6ed", "AQAAAAIAAYagAAAAEAzc0JE+ySW7rtv5zsPKLh7fM50f5m2KEqy3Tei3r7azcWsAfjBMorqZfRfG06/oeA==", "d55bb33a-116c-4864-afd4-438b3066c992" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fea902f-490b-47b8-8bde-b7f7b2298e02", "AQAAAAIAAYagAAAAEGZomKKJ1S08TzethtqG40EuTi29gEUHcl2g/PMlGfKqY9EnrMnHXTNPV7Nztb4HsQ==", "03c6cb28-98e2-424d-bcd8-b808a869a4d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06b3148e-3e99-49fa-973b-e8df377e74a7", "AQAAAAIAAYagAAAAEL31rftGXNTdZFgXvHlrk1o05mQ6o6ZqknMkDLdeNYbWXohvGnEgvyu4iWIX1mSeiQ==", "81dadba1-1026-4901-87fd-599f50463cd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "113",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2077a01-e3fb-44e5-90a1-2002b26c3806", "AQAAAAIAAYagAAAAEDdmqBKPcYq7eV172fwhBmAL052i5XD7AFXOeYAvqd7AoZGmZNbnknSsjXoN17QVlw==", "51494cb3-f8e5-4184-9af8-7780c582c885" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "114",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0190cf58-62de-40df-a61c-432366e6a34c", "AQAAAAIAAYagAAAAEG8WxC8wKu24h8o9cs4bxUc51kt0nR1EPmpC4Jilz7BKBZje+bXwBhDATmg7u/szFQ==", "78de8900-71e4-4780-8f9f-4df69ab1a923" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "115",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bf93ac4-dd61-4f7c-9268-2b6910e84304", "AQAAAAIAAYagAAAAEJTzMO0OAKZRP9Qdb3lfrLf0iWRLyXFuch8LNeEzII/9a4nOkqBfg3ItSjZ9ZbAH3A==", "0ebc4e99-3ba8-4e03-953e-6d2c9da2e1ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "116",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a5402b3-3b64-4b2a-8769-30304f5d7b12", "AQAAAAIAAYagAAAAEMT+2f0EyqircGQGySDyMY5FzxFtls9MwFKca7XEB0cJCFlYHs/4cWhYYHNVN1iHng==", "18bb47e0-9d44-4611-994d-045df93785b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "117",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9877a817-5d5d-43a3-a9b3-e555f7db905c", "AQAAAAIAAYagAAAAEJZgMyXGyRyhW6sY0nOocsPiAGYJMX6kPkkVurN8OP79PzEI979SxMkOGTIcBbt3zQ==", "d08acd0d-13a3-4b30-ae8e-6e1913cc908c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6f10820-8aa1-4fde-82e3-3ede32198067", "AQAAAAIAAYagAAAAEBYw47bHbZDYQQtUmkBw8gH0R/ebeNyAFlhYfZ0er9JtF0dZoMgPeYHcvQQdNn1R+g==", "7efcfcfc-fdc1-48e5-9394-aec34d1c56a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80463cad-1836-4e58-82a3-6d95a3bdaa77", "AQAAAAIAAYagAAAAEMpIB1PfmOpQgM1pfojyHiWub8IT/qR51b+5LeDS9/dbWSwsvz5mIaJmy9glmU5jEg==", "8bbcc2e6-9b09-4320-8cd5-a56b9a542a41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52a02d61-d2a8-4179-bdc9-a73a21a6e413", "AQAAAAIAAYagAAAAEPbNP9I/nWqRR+MZAunmIsfHvGWdbpBzpONAyn6Fmv657wvbI0oLQw/KDI7Mjm0T3A==", "dbd2b651-084a-4d08-830e-9cb401bd2b37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "121",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9014bc7b-8856-4673-8927-95da5e723102", "AQAAAAIAAYagAAAAECRZ5u+aZPZ9xDlYu9NlxynJQctmBLHdXA4wd/1y3zuabDOdxTdsndM78StI9dpbIg==", "b45c42fa-e738-4f67-afd0-811bfd3d2dcd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cec59bfa-98ce-4a33-93a1-05cb63ddfa4c", "AQAAAAIAAYagAAAAEEu+dSONfFLmyP1+S1dmXtPKfYmT3IvCEI1dnPN1fgiFFx51Bd2RUVKaezq/1/Mqyg==", "650042fc-247f-4820-bdfb-3dad2e6b9577" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48e877ef-8e39-4ab6-bbdf-eac6dfe5dacf", "AQAAAAIAAYagAAAAEAAHCELbItcWS2MYlRnC1vJASn+LKj3IJxx6EsrreEhBInJQsaQpNjG52kfqCojYvA==", "ecd49c52-6a66-489b-b2cd-c8584a5c9f24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "795198f0-6fc6-4f5b-94e2-2d74305f0655", "AQAAAAIAAYagAAAAELmKf4j1InSFr09EmMdkzOixw2MHkNqbFAA3Y87q4HEap+4uNJ7gJ1+GGzukOCjbSg==", "2c54dd67-12b6-4f07-af6c-dbc90a299ecd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "125",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c0577b8-0241-41f9-8a05-5cc2815caa50", "AQAAAAIAAYagAAAAEACaC/LH7233/C2qZNQcSa1Vog1ZVuw2zfFlPZE4CtgeBvT8gNgjc7WjQUwNfC9X/A==", "1931cfab-d6ae-44e6-bd65-69d35f6cf77f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "126",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7211fc00-0555-475c-8e01-98534c2cf7d9", "AQAAAAIAAYagAAAAEM56dHw3BB/0qJlF8oQH8Z/1OjqxgM1r17rXFLILV4xfBArR3CtMRObAJKwrMPyoPg==", "0f2b8f0e-5270-4990-8e14-4bf4a262ebc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9088406-8170-43c3-b5e8-6ef27a57e4c6", "AQAAAAIAAYagAAAAEFWIJleIXSkSEe7BMXneGxYWopGuWgU5x+QMeesgd5osWggbgm/L/ffgNN5G5IDXdw==", "1c1a8fa7-6d93-4c64-b6b7-a2a51900a777" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "128",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09b143e3-e9cf-4f07-ad71-cca070bce952", "AQAAAAIAAYagAAAAEHIvab9p8azwkCK3oObu1Ect4cpNcQga5q4SrXuiue0OOeBc6EvVL5I0HqYEjjSgCA==", "bae9382d-cee1-4653-a679-9656365aa230" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d5772a1-8bfa-4dc4-a8df-f9f6a1052aaf", "AQAAAAIAAYagAAAAENUkgHKUeG2cDhqnZElNOmIrvbIteCeq3jfsq5aPhcr7I5DT65rleQ5nYTDq0uPdFA==", "ff5141f5-25e7-4e1e-8a7e-53234c7f1f9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "130",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45ff5a39-846d-4c37-a100-8abb6f7c6df1", "AQAAAAIAAYagAAAAED+RxT5/dvZ2D8qvfjTSIxlmUdI8boSD0vab3YsLyTNgpx9jYuieJ1Sotexe97e/iw==", "3aadd33f-9741-4646-95ef-240c5acb6024" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "655963a4-9ee7-4fda-b1b1-10529535d621", "AQAAAAIAAYagAAAAEHsRuAWLmgQpOHMnkOZ1yngbKjSNMlhQBntZWpc8ofX/kvg4z4+Ot/KnYH6GZHN6HQ==", "81c28880-82b9-4261-83a1-7fcc2815af42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "132",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2abfd9f8-db60-4d77-8e50-67af251d7f05", "AQAAAAIAAYagAAAAEI1uU7LSiLK/rHBiJfjwYfNwz6NRf8gZyyy8L4SEq3egpDdFUTGYOynNmCPJju+wiA==", "8e849dcb-38f5-4f7c-8f93-6aa45601268f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "133",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfcb426a-2b87-4618-a24d-a928281a00fd", "AQAAAAIAAYagAAAAECDODfyJht11YsHxLf0biIv2V6gDKRRSU6/2IlkCNVjQ8iqCpJr38888f//5r2V2cQ==", "9336914c-e272-4e5a-9655-fe3624430607" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "708f82da-2b37-46f5-84a5-9dd6b89f7765", "AQAAAAIAAYagAAAAEOtQ+OKY+9MVj1psGB0VzLrwjzudFvu66nL3u4O2PnePPqp5RTKnjaFzUGuq6miVKA==", "b1d61bfd-1d1b-4e75-ba14-8a1139ef8d79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "135",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8970669-0d86-408a-bb82-9258ae957a52", "AQAAAAIAAYagAAAAEH3KJICJqXty1VsHusr1+0TXAHwhMFsGT0k8wdsQyWYGPfyvuZAu1CbyaL8+DMA+xg==", "35e42f4c-2fd9-4319-80d0-c33fa3a1b1ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "136",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6748959-7cc7-4eca-b01c-7dc338b4b127", "AQAAAAIAAYagAAAAEASyevBo5Zoq3Ndy1RDvq1gYS/0ZEUW6aLaeRzCB5EQ/IpBpKlvRZ4NHk/6dIyh53A==", "fd9fd296-5235-4303-94c6-07d064e80a97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "137",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f4db61c-819c-42d9-965e-0c7eca41145f", "AQAAAAIAAYagAAAAEMbvQMZK9ZE244+V/ptRVg13eGLZXNoEw1WaDYV+UbrrVxj4sBTsWCONOI6EHmTsDA==", "dc04a9ac-e57c-4666-badc-74c2c702c53d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "138",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76bf338b-a765-48c5-84f3-3dbc411c0335", "AQAAAAIAAYagAAAAEItKyTntuligr5w61OsTHp4dh4rt2lsjqn4NPSQGI79NuhnzBWKF3qu3I2XzRzsSRg==", "f844398d-1430-48ae-9bf5-abeacfa58c43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "139",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee361679-b7fd-485a-978a-a22abb5fe90f", "AQAAAAIAAYagAAAAELySgZws3Q5/zn7Cz0aVQ7YsQr7i2kPVF97bS0Tr383GJxmT/gs+oBzNXJ6/ExYYxQ==", "3f1fc5aa-4106-4b86-b14d-388c2cd722a5" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 9, 588, DateTimeKind.Utc).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 9, 588, DateTimeKind.Utc).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 9, 588, DateTimeKind.Utc).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 9, 588, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 9, 588, DateTimeKind.Utc).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 9, 588, DateTimeKind.Utc).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 9, 588, DateTimeKind.Utc).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 9, 588, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 9, 588, DateTimeKind.Utc).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 9, 588, DateTimeKind.Utc).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 1,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8253), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8252), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8252), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 2,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8257), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8256), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8257), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 3,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8259), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8258), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8259), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 4,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8262), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8261), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8261), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 5,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8264), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8263), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8263), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8264) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 6,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8266), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8265), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8266), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 7,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8268), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8267), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8268), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 8,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8271), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8269), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8270), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 9,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8273), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8272), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8272), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 10,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8275), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8274), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8274), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 11,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8277), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8276), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8276), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 12,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8279), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8278), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8279), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 13,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8281), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8280), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8281), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 14,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8284), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8283), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8283), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 15,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8286), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8285), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8285), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 16,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8288), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8287), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8287), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 17,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8290), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8289), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8290), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 18,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8292), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8291), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8292), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 19,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8294), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8293), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8294), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 20,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8297), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8296), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8296), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 21,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8299), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8298), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8298), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 22,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8301), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8300), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8301), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 23,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8303), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8302), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8303), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 24,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8305), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8304), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8305), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 25,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8308), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8307), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8307), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 26,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8310), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8309), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8309), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 27,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8312), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8311), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8311), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 28,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8314), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8313), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8314), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 29,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8317), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8315), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8316), new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 8,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 9,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 10,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 27, 11, 887, DateTimeKind.Utc).AddTicks(8186));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExitDate",
                table: "VisitorGatepasses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77d11754-2ead-422d-8718-f2d6ce10b4e5", "AQAAAAIAAYagAAAAEKX5PDwsROROxuD/Fh72s4JPNk7TDZv9GFvIq9EPQaE1ZujC8qP4a7lgDB/z4iyOHQ==", "3510ee1b-2848-4f47-afc7-bcbe5fd16325" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94cf88be-26ca-4e2a-a4b4-f73a5303f807", "AQAAAAIAAYagAAAAECaN29A09t7OeicxmrC6gUSBYlExdTPkwMMqOemepIdcAaDIrXmRZDWdIotLlK+QuQ==", "1525f330-a476-4411-ad0d-218f72af3d7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d22ad49-fb47-4b85-976a-6002f731495a", "AQAAAAIAAYagAAAAEAzaRXDzcspBL/7s8q9bQKoqWdjaoUqori6WTZlKD47ZuIX3ocu4DkGwAl2ZRp0AuA==", "9e361621-7947-4dd7-9f6e-ff79b833bc1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7efbc5c-62a2-4ceb-b1d5-4a3aa712d48d", "AQAAAAIAAYagAAAAEP1OGy7m1VEL9lxFoaZhs5fqVM9MfCf64HP2qlyILfwiZEgyeywURdkuOPdKko+TVQ==", "b041929a-9878-4e57-a65b-fe5e7e46ac53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc673dee-f070-4654-ab01-0dec66f6dad8", "AQAAAAIAAYagAAAAELe9Tc6nlSBKdDoWi7u7m8GrlLbKRYZuIvuccnfqMvuTTA8wkkZMDSPhD+6Uk9XJPw==", "c6ad6b21-2424-476e-ad04-09cad713a5d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9506bc59-dc86-43e5-82cf-865257aeec96", "AQAAAAIAAYagAAAAEKtBvT1g5w8/LskrtXbquGrgOV2DI0rdxNfhaGMKqJfJM2gdfm9QboNq0667vU2KZw==", "530900ba-8cad-4238-9869-6b9e67eb549c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5809c2a-b7e9-44c6-9560-2e3d138685b8", "AQAAAAIAAYagAAAAEGujov95UOBKMOe4iS5Efu8FL8+NUoj9WvlkWW4HgVYpT8XpsJijWwyODUaEhlHI4A==", "9eeb9e3b-d1ee-43b0-bf04-e2a2cfd9da62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a02e3683-0bd2-45f6-adfa-e67de7430880", "AQAAAAIAAYagAAAAEDPGcgXdqiPVRYssCOrq/rj/BA0c81n3SkJgTHLVRY1WFeVIgxfRUVR7g3fmUs+hxg==", "c7a7ca3e-38ea-4164-a371-673afd5ac391" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2126fa42-5f1c-4784-939b-673490b98eae", "AQAAAAIAAYagAAAAEC1wnt9GZH99hdvw5ESlRnw+RA2Tz64P3IbbOxKtXSlGmJxK5jP+Voq4TXmKsrQMig==", "675f9fc6-f6e2-47a9-8062-9b2c9f1cc4b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2d456a3-6dbc-4798-8d7b-fd08a0f41372", "AQAAAAIAAYagAAAAEL004UTb7kUMFkxOSssgmnpZ5nThhRnl+2Aurhp2IT2Um3KnaMw1RYAnF47gGv8nIQ==", "7f1c2e27-fab3-4034-85e8-6d8fdb2110aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "527d276c-f989-4a3e-883c-8715ce7413a6", "AQAAAAIAAYagAAAAEKEjSbs7sFB6Pcvhr/e/HikCnQPJZW2hnfvCC6PiOKqvaERzMPpAr+vYEHyugKJb6g==", "05ba8bd2-25c4-44d1-b2f9-149bc1fb4647" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "703aea15-87d0-4c61-a5e6-fcc8c8518153", "AQAAAAIAAYagAAAAEPph4ASFhiCXlBSM8YeZ/KXt0gz5TRPv4/aWN1S1zUIXNnesNF6S5eyfO7ZgcKR1kg==", "47cbe13c-192b-43f3-a5ce-4972e758c189" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "113",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ce44fe7-8d43-47a0-8fa4-0e074935ff69", "AQAAAAIAAYagAAAAEIk9AkECFL3l9M/XxHcBEBTL7D7JM+B5LkUtcWWWUPmNYFNiORJSb84FsSMmNg8oog==", "cfa1d56e-397f-4632-8c77-3bf040fe00a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "114",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "132dfdcb-16d0-4d7c-bb8d-871451adcb58", "AQAAAAIAAYagAAAAEOce0lc5+G8HCbiK8Uf9WL4K2Zp+i/SZoBP3Fw4HeoxhvDz/YyE2U1gg0P7mROnRQQ==", "bc664362-ccbf-4f99-a014-d804a73e1025" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "115",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86e1da97-4737-4e5b-9278-b54380d2316b", "AQAAAAIAAYagAAAAEFM3vhyP47T6wJSo/uF0NfE4xbPq0mv7RIYpdbQeQCeeEWX1W9FWrfZ25xHHdLWWqA==", "68156d13-7a18-40b4-98c3-3014eec40ef6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "116",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3600bf07-94a0-4a2f-abbb-6a3162d1ab82", "AQAAAAIAAYagAAAAEC55D5X4xW26JCzd5WovjQNAORfxElm9IuM6d/Y/fnkiXxjfP7a7l9C1h2CpOUhUdQ==", "c38be6ae-75e1-4364-a5d6-8649c2e99684" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "117",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7496d25f-4660-40b4-94b1-ab62900a341e", "AQAAAAIAAYagAAAAEEwL9ZoUidIIyv07Dy2QFzIQYBIrRK1YrcF6RXaop3Vf7nkLre2x+81i61gShFU+0w==", "4f928977-4f76-40e1-8cb6-c307ed1ee81c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14e5d476-4ef3-4424-8686-8d5a0682b1ba", "AQAAAAIAAYagAAAAELAWMFhORhtElR0EE9apTqUhDMkjeAqHK8hVFNkbfTgTNwT8G55vYUK8bUrARXzFLQ==", "fbe3f144-6287-4d72-b6a2-94c67210dd2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81c0cfd7-1bba-4b9c-a4e6-fa26e0f6ef6b", "AQAAAAIAAYagAAAAELac2lBN9kXNLCvq+BoJDuSOZM3cTeGdryR96EGgVUKGerU9c+AW5SYrUDKLmq7HqA==", "42751cc2-2531-4989-bcdf-ae77858adcfc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2766fd08-cfa5-4c21-9fc4-6d81e95a8e0d", "AQAAAAIAAYagAAAAEMMQRLthRUi/8PLAfpqTUJ+TJep9gAjDKWt+rJn11URiUWAGItsTUgSLcn22H8i+qg==", "f1a0a85e-25d1-4ae8-97bb-5915666dfeb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "121",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9db797a-bb9c-40ec-adce-61636fef9845", "AQAAAAIAAYagAAAAEOhCm06X4mKXkMsSKpyV6XJ2ltuKNC1Zj2jqZdt55vgbmUmj58tilMo+wVbd+jrnMQ==", "0273dd70-0db9-4292-a5ed-f5d957f6527b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce70318a-c8ef-48de-a0b5-96daa4e75d4a", "AQAAAAIAAYagAAAAEPiyUVM3l5uoh7sONGM6CV45l6rpDvBDuArE3j9sShidfrMv9wtyhMrUuhOQwds4Hw==", "e429b68e-ce2c-4d69-88d9-26a33a1bd922" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad0c8e6b-fef5-4fa2-93eb-32f3a62194c9", "AQAAAAIAAYagAAAAED0E/I+OGoodY4xSsRw7wdIao8gouymS/ErAWJZQQBUIcJrd0jO/7aXABgfijMw2Sw==", "1109244b-70f0-4605-8de3-2c6afe4b9632" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3c506f0-f4ed-41d9-a238-6607b46e55f3", "AQAAAAIAAYagAAAAEOIzM8v09uoMSjMRtanYORtLs4gUYi0Ub40vxh0jL7zAYUMcv47SORAZ2+y35OFcyA==", "ebd4d4c0-51ea-498c-8fd7-119bd2cb04d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "125",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a499c58b-a008-47f9-998b-b3f50bebda3c", "AQAAAAIAAYagAAAAEIkjUWCTNcZtONI687i7ieh2EgSdPRWkW3wjjJfLOhdL06qVa/mFbdqjK7r1d6PmWg==", "1da30907-9a0b-444e-9480-0eb93b5e8fa6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "126",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "508ed13f-3333-4add-acc2-bba7dd800866", "AQAAAAIAAYagAAAAEPe/YBRRYZ7A7nk8Ue1tM1ZDoNUQZT4+X5sJE3LGAV3nJlN3Q/HJ0Yj3++SvqVv1Ug==", "dc9d24d2-b42b-4a63-836f-7c82172baa6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9784f8ba-5749-4bb3-a51d-af170c172a25", "AQAAAAIAAYagAAAAEMKZ1PWgF+B4VHrToK1tl6dfJYHAx4NLTFFdXgEGY0yU0/DChbtREsO5CMFCQejkGQ==", "7108e3ed-adef-43da-be7c-ffcdf8a5dc9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "128",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94604078-c0ce-4fd2-8a59-cbaaa296a483", "AQAAAAIAAYagAAAAEJQz6KWITJLUQS7a1fPQcsasEJYW08gtPlau18oH/wFTXLXcbLF3FkpBRsdb+hPynw==", "ae175e38-71a7-46e0-8da8-7c68ed4450fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f721509-962d-4644-af8e-abc5414d1665", "AQAAAAIAAYagAAAAEJYv2+NECu3yaCdPkSTVrt7LqCZ0CBWGht4UuFXY+a+EB3dTWg5t9X+qO7mWMhnj+A==", "51997475-608e-46af-93aa-66fbd3c0c185" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "130",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "168b6484-33c8-4355-9991-65baa7f87e3f", "AQAAAAIAAYagAAAAEHwQ2rzAL4Xb93Y6kMKMwzVN/3smuNm7MYB9G40KkQsGfN1z357389z0zy4m/uqkuA==", "b6d6ccf2-101a-49a2-bc59-adf5a0782228" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "905f0f1c-3878-46ab-8dd3-fa7d75085051", "AQAAAAIAAYagAAAAELuI1IZv7SIW7on8UhED2/UqZzCvi+AhwCSWPVPMIetJH+dHS1MIbTwvtPP0sGKcpA==", "8bb15e7a-533a-4e58-b37a-50d33c3b6b2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "132",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41d72d78-c54d-478a-bd26-831b8f98bfad", "AQAAAAIAAYagAAAAEAebHz16moqyMHGEx/qg1pUE0oo7+Y39P5AHQEEl3ahN459wXq80QngmXQ3rI5g6sg==", "4a196be0-0cc9-49f0-a725-a01d3b159eb6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "133",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "410e12eb-0a16-4ea7-9c5b-464f161bdb50", "AQAAAAIAAYagAAAAEIAmpfSPsXkQ8NCcFjv4gK8ufTWFiRDjBYV3HZ8I4TMa5SIDwyhWX8N/8m5Pjryr8Q==", "69af97e5-6d8a-4337-ae13-56564666a7bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60f6ee41-8b13-4656-87e8-c6bed29ee1ca", "AQAAAAIAAYagAAAAEGvk3UZOYe2+7nc4R2wmC1kUlpGQGS8L6WulnNqC0YnB9xUrorBlmBDh7gZP9B9Uyw==", "4d89cc18-26c8-484d-ae96-111d46d65617" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "135",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2782a37b-ec12-4f9d-8b82-6f3fd31f97d7", "AQAAAAIAAYagAAAAEKvpf724lbrLoQCbZK6OKnxcDr8MqprXLyH5mAMUV/8BFgfOt47dcF7DffNDwGlKfw==", "1dad1406-53ce-4085-af14-d0accf88d3cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "136",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b4714cf-ae88-4496-aafb-797fbf9c2e3f", "AQAAAAIAAYagAAAAEIuK7Qw23hjlapqjwyeKkLyDLCFu3GNnZ3NZRQ76QB5So1Q4zvMnUzbtHrzclrCfMA==", "0a06acf1-7a3a-45fe-9b2c-86d43d7ca3ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "137",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "087ee58e-944c-4b75-83de-6a740c27f300", "AQAAAAIAAYagAAAAELKGtNsXQHD0cIWpzuSYbsak8RPP8QZMc+xGL8XPQpWj/UgzfAK90ie0291+MSAkJA==", "6e09f87f-772f-42b8-b8a3-14b4f2d5cc6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "138",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c73e153e-e443-4c77-8956-7e7f6d0c148d", "AQAAAAIAAYagAAAAENX2uvfoKlrk2rexsNByvFKShKbWGZt0/KVHpFUhnjwqQRMfd/KTxwWtCH1lGkMJkQ==", "56a6b6e0-bdc0-4fe1-8611-3311bf8522c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "139",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3235b6bd-0dc3-4907-b5d9-844aeacc6a06", "AQAAAAIAAYagAAAAEBEqI//hSAg7ZaqGy8Rdes/26puz4WqnHMJwHh7RFqElxDLOZivPWqku+KQnC/v7UA==", "71866c73-f331-4aa7-8d3e-f6d0f3525f38" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 43, 608, DateTimeKind.Utc).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 43, 608, DateTimeKind.Utc).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 43, 608, DateTimeKind.Utc).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 43, 608, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 43, 608, DateTimeKind.Utc).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 43, 608, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 43, 608, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 43, 608, DateTimeKind.Utc).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 43, 608, DateTimeKind.Utc).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 43, 608, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 1,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3231), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3230), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3230), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 2,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3236), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 3,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3248), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3238), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3247), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 4,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3250), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3249), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3249), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 5,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3256), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3254), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3255), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 6,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3259), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3257), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3258), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 7,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3261), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3260), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3260), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 8,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3264), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3262), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3263), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 9,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3266), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3265), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3266), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 10,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3269), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3268), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3268), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 11,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3271), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3270), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3270), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 12,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3274), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3272), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3273), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 13,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3276), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3275), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3275), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 14,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3279), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3277), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3278), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 15,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3281), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3280), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3280), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 16,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3282), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 17,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3286), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3285), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3285), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 18,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3288), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3287), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3288), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 19,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3291), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3290), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3290), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 20,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3293), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3292), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3293), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 21,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3296), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3295), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3295), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 22,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3298), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3297), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3297), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 23,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3301), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3299), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3300), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 24,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3303), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3302), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3302), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 25,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3306), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3304), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3305), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 26,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3308), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3307), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3307), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 27,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3310), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3309), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3310), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 28,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3313), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3312), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3312), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 29,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3315), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3314), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3315), new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 8,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 9,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 10,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 17, 6, 45, 913, DateTimeKind.Utc).AddTicks(3103));
        }
    }
}
