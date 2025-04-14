using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class AWERAWERAWERAWER : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "BillPayment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1527f97e-dced-4f55-a704-8811e4dfab25", "AQAAAAIAAYagAAAAELT9qHkSh2uLUMA3Fxo0rGya8RiJRWHBJJI4GQSllG4+DMcaNJLagSIjgH0xm9gUlQ==", "74546132-356b-4613-98a7-b5c5e805179f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58151c73-e141-4b2f-bfb3-3f5f4540ff85", "AQAAAAIAAYagAAAAEMQwvKSnYwdSInc5lNJmAstHktLaxnLW4ZnDVucaMd0iYr3wvMkKt+USZAY1dMa9Bw==", "94faa501-7d95-447e-a735-8fc277a4c65f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c2f9a7b-4953-484d-a4ce-0eee1284ae89", "AQAAAAIAAYagAAAAEHV5AJr374hxCeDyOuk/+KZDx3kaaQoqJFuQKtMGc4liisaaEiuEQUTN+xEU1jcwyg==", "21aa9ad4-a6fa-4673-bf25-5420fba6e280" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cf95609-b5cf-4929-994a-3b602012052e", "AQAAAAIAAYagAAAAECv/pEGhLZbsAJwEpB3IUOH9OavRRZoTPItbRcfJ0T0OLT/WgWnqxJINVJLalaZCfQ==", "c2fe3598-ab9d-45a1-a41a-7824453b5b58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa93ec4f-1488-471e-a68a-3fa28279ee0e", "AQAAAAIAAYagAAAAEILH4VU9wRSWCketLIDSVC7WgSbruwOt26KjnY04PkOYtsS01jTwRD7gHjk4Ki/UWw==", "7c1c7b53-49b9-4b53-889b-93b15525b58d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9eba9bb4-573c-4b67-b2af-30fa4757e75b", "AQAAAAIAAYagAAAAEMrs+aHizdrquci+gE4y2aI4AXn9L7lSDY24Bg6Rubg4yUNTAS3AddNsrLKKSAri8A==", "a0400c80-84cf-4791-bbd3-c7123040d0c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a21cfdfd-416d-4bf8-a0d1-2ff04b78ecfb", "AQAAAAIAAYagAAAAELm5AQXxJfycWeN13MNfou5o/WnsWwvV0SALfZwjNRjAT2VvCbxtnVqODR9x9IJXkQ==", "ba8fb12c-4b09-4c23-b3cf-a75360ddf715" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4af11cdc-f1fe-4e20-86ef-89aecc91674b", "AQAAAAIAAYagAAAAEG1E81nV4jTdhPRsH5szh4PzD5m+gGxtB8DkakMgpolx3x9ooTNNaQjZtq8Y9Ozscw==", "6f6be82c-539d-45bb-b2ed-ff257f55ea3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b62268e-7875-4816-9f5f-ec944192cbf7", "AQAAAAIAAYagAAAAEOmMqsEzqROaoBA3lqYzKFD8TcaG2+eX1wc8/tp6+E8SPISjl3I05Nt0bpBeQeFfJg==", "aeec610d-26eb-4c50-8473-d726d853925a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72e28fc4-02a1-4523-a876-db3578c23a5e", "AQAAAAIAAYagAAAAEPHT9tv7QnAxO7uloTf/wbnJZo+G8kAMamKckbZaN37Cim4JLfwMoSTsWja84TqMSQ==", "846932f6-0c63-4858-bedf-c1301cf85073" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "862bd979-8bf0-4802-9263-0c4df331dd12", "AQAAAAIAAYagAAAAEF74sC0TQUJnkFGNZARwV+gtRJUlhzfJUrUz2Gq0Egjb1Ytk3XgTgWmREYKoImTsoA==", "3d4bd024-ef6a-4295-95f8-a315af23f236" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfac0505-e461-4d5d-b43d-a1edc52e2e22", "AQAAAAIAAYagAAAAECYSO7vs/BcYZ6vj2kAbOepkt4E83diVP4pX3B0qxkHoOymT/c7adf3ESWVcWWbm3A==", "3764a0c9-920f-46ab-a41d-e58347d71433" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "113",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db1dd93d-0a42-42e3-9107-7e37bbde8269", "AQAAAAIAAYagAAAAEDQLHY6hKXWh7n2jsh80OtanzoYP827gBdfSU5zie7bjeDvLqWInpbLVoXpJYv+exQ==", "11e2c64d-8dd8-44c8-8407-c3ef23b856f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "114",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8fa3317-611e-4545-8182-fe34ddd58e6c", "AQAAAAIAAYagAAAAEG6axUhjNW3PJjfoqBoHJT6KoX52ssJEofT1Qx+3UlQSdJ/vuTSJP1ueDfKm+jb21g==", "61e76650-203b-4017-8765-6af7086f8465" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "115",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4930f0f-68ad-4e49-aeac-5998d2ef0efd", "AQAAAAIAAYagAAAAEAFYe63Ek1rLRcK0ApgP/JMWjZGy9ArdcmRpsvd4D9whzVmi4RM//Pyt3JuX8ax2Cg==", "f7cfed58-f7da-48ae-9dda-db17a3af847a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "116",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9d4a0ae-00ea-4f81-b922-60a99fec1be2", "AQAAAAIAAYagAAAAELBFUxAct0gEBxlwnrXYthwzfzH75bsmw+56WWeiuaxSVc0mYH2BkLV4k2OmQhK+1Q==", "53389ab2-75c6-4b59-b787-2435b60d628a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "117",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2128f5fe-9d9b-42c3-adfb-f4517026ba49", "AQAAAAIAAYagAAAAEB06rXdGnU1i6PJU1/yfZOkU3+JXSQglEiq94+vLcbL39agQ9XTUwJGqcn7MpwQV3A==", "675f2402-5608-4c06-8b72-7e7f8a5f196a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c67b22d2-2376-4089-922d-62eef4c17a68", "AQAAAAIAAYagAAAAENtRrD07f4TlzfozwzGzQtH2DTk/LmYDfnidCrAkROVCu+5R0al4123gvRnRJYbL/A==", "e4ca2c9a-2c5c-4f11-b384-61671a90f1d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec7ba6b9-e613-4a14-a067-d42bf281ad05", "AQAAAAIAAYagAAAAEH4lnxOZcEwErEiBogWy6CY0oAxbrSxgX7ZNdxn7S9CBHGn1BTfWOmXIqPHPdV0kLQ==", "e22e68a0-9e07-470f-89bb-0041cb27d6d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f1dd080-23ff-45c8-8292-4b53eb8498e4", "AQAAAAIAAYagAAAAEDA23UihD0CVQAOphG3RLr41Bm0pPxqYAGDqP6ePePBVK6vc1QkoAlm7nTAS1wiV+Q==", "817dc796-a4c1-40af-bd67-9de8d0bd7ad1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "121",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6607c20f-930c-4d22-8155-685342de6a79", "AQAAAAIAAYagAAAAEK7YZMHoQS2opS8U3O1oLPOwx1vijfQPSNFjriY2uaIBAwPZH8gj3I9t9rC5HGTrHw==", "eda5e868-0b40-4f8b-856e-6d8a865f774e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ddabcb0b-0c1a-4830-bf21-f9e377242f05", "AQAAAAIAAYagAAAAEOQSYhNbDs8lRsqvhiEkqOjO+/2Tl3srOTcFqO+7VdFcK986XX4q3CYGXzn4ZmWA8A==", "6c0d9e25-308c-488d-8ebc-f39493ad5110" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "400b1aaa-8766-47c0-976d-ce056544861b", "AQAAAAIAAYagAAAAEBqAbB8ci3+/35+N6etmAqDwJVY7jTBrKhTG8CJXh/bVv2vFDHjQH4gt9Q5mFAnZFA==", "6866eb49-c271-4903-8e85-3dfc8be8f83b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be8eb819-1637-4d0c-8fe2-68d38e3de647", "AQAAAAIAAYagAAAAEIixPclOgK/ooygPc0Mbeno3kJJgt8ynXBs7JFc0ZFg6VXpf6RWRRCLLtKUAOQVSsg==", "dc7d0a7a-e1ac-4fd8-82e6-d8f513499bab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "125",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77c1506b-d3b6-4b50-8546-428dda0eddcf", "AQAAAAIAAYagAAAAEKg62bCLDOErRQMndOkyT49hqH8xxh7s6mgZEXN/dQ2vnZx1iyDmnuGk04oUNh9Lhw==", "81429bee-3109-4d45-aeb4-2f12a52430f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "126",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "691906e2-cbd8-42ce-bc8d-78884c2ed8dd", "AQAAAAIAAYagAAAAECbZich0m/H0uTS4P2yVhdkVoNdLNeNaEyjtGhZ0EJX3+sYb3fYqMTr2rGcaIKXytw==", "12087d8b-c989-4f30-970a-9984918f5c02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "826b4c8a-5b50-4535-90b2-dae3484d95f7", "AQAAAAIAAYagAAAAEHbUps0+/psJ5WGU73eZTWKO43jVf1e741SieCZ8mKu1aQts6axQ0Gbp+udop4Zgng==", "27327a39-c391-4011-9d4f-1dcb08759719" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "128",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79b5d515-8443-4080-b450-7a037e54f7cb", "AQAAAAIAAYagAAAAEOsb2dHEMYKARM4IKcNZ5RgJwZxRQQZW/r09yinddQyio1jwwvGC9WPNsyyEF5++Zg==", "94f102ad-3a0d-4f2c-a03d-53b410f13473" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c984819-f5c4-4366-9c69-071079730c3c", "AQAAAAIAAYagAAAAEPIw2Hpaa/fHNQpXII9B7vHN7G2Qt3ct1FbPito4niSVEduHuNAGJPvthN7F8mce7Q==", "7803d5ff-2425-481f-8416-1796c79e6f28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "130",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05b78eb5-6c0b-4a77-bc96-d13b78436766", "AQAAAAIAAYagAAAAEMKsVC+/1ZmSJ1oJyBeScC/iSs6YXhcQOhENnrdtjg7ih3un+U0cC3HWddSUgEfPvw==", "64997a0a-d757-4b86-a14e-be320d04b1ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71f0779a-4ad1-4fdc-9e72-fe5727aba106", "AQAAAAIAAYagAAAAEH1nIUaADiJgbLj+Hm/uB34I7ByKbKbx7sAEB3qqXOyCSCwBcTJPgyEzvrRCWEC07w==", "4f24fa20-6923-4c3e-ad49-f55587666fcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "132",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ada1fb7-6800-4496-a4e0-877e2bcd5754", "AQAAAAIAAYagAAAAEOsddD2EaSgJc3NRf8VMkgHRmStnE606O8NzaU6Ju758Tf7scF4Q7pLlLVc1BrKAkA==", "3cd9fcf1-d894-4904-ab41-8cfd1e6ab24d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "133",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52ea385e-1836-47ee-9b24-7c4afe1b6979", "AQAAAAIAAYagAAAAEKGCHB7hwoEYbnPqYiSPh/7yKRRPTZa49zdA+aBVINxYn6NOH8EieO9ruhUUhhZNXg==", "07d4a0ce-ca1f-4dec-be5e-0ae934d488aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70127068-647b-448b-b749-ec547b1f8f20", "AQAAAAIAAYagAAAAEDt3cQk02smA8WET7xTWJPoR1KQxhdAARglGwbZ3gYlvq7hQmUC/jcyf9Me0aKvGbQ==", "359945ea-3078-4eb7-bc34-28f0c2d97b36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "135",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a660a7ad-db65-4a6c-ae66-5f9742f7dd78", "AQAAAAIAAYagAAAAENLYn/xWNkG1IeVUEwn4jcKyKl+d+Iwpb9EYcNvQx/MMd+QsWOiBz7I40ied85Yyeg==", "c04b1470-a28f-4f6b-8298-743e2f142e18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "136",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f44d75b-76da-49a5-acaf-fbebf7cead35", "AQAAAAIAAYagAAAAEJLx3tiTcigpxC3wiENfiBpkJ1uMLa0g/VEXY5+I3wF8NrPs1bahKb7oNSWm3WXNSg==", "d4192aa0-d290-4412-8cae-a23e29d5ef2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "137",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d60e7d7-a6fd-45ba-93b8-7b6e0e0afefb", "AQAAAAIAAYagAAAAEEmgi1GwzMpoVFJilG3aMyPhDQRrmqTaHfctDY04rU87FQDMb7nlAaP57kq2vd1UVQ==", "0dd536e7-87aa-492c-97e7-dc663068e61d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "138",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "038ccd9a-d0ba-43c4-a932-eab1fba1b40c", "AQAAAAIAAYagAAAAEC08tUqjeGyv7xCArOV7QvrjlrBDBF19x9N2WpeJABZCmeFKyTjyWcubHCeIfD3waw==", "38d19844-1060-4011-8fc5-f44a3108b078" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "139",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78614e02-6ef3-4bb5-bdee-fe916c58525b", "AQAAAAIAAYagAAAAELTAvIOxcjbld4LjU/mb0PgQHXQQicD4SAqMkNjcOuqzU2Sc+Yhwoh+0ClaUih8Rbg==", "690eb729-ac14-4596-92ad-12b26c0a6bd5" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 13, 214, DateTimeKind.Utc).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 13, 214, DateTimeKind.Utc).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 13, 214, DateTimeKind.Utc).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 13, 214, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 13, 214, DateTimeKind.Utc).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 13, 214, DateTimeKind.Utc).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 13, 214, DateTimeKind.Utc).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 13, 214, DateTimeKind.Utc).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 13, 214, DateTimeKind.Utc).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 13, 214, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 13, 214, DateTimeKind.Utc).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 1,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7102), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7100), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7101), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 2,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7111), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7109), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7110), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 3,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7115), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7113), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7114), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 4,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7120), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7118), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7119), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 5,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7124), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7122), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7123), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7125) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 6,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7128), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7126), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7127), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 7,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7132), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7130), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7131), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 8,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7136), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7134), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7135), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 9,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7140), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7138), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7139), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 10,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7144), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7142), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7143), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 11,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7249), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7247), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7248), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 12,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7254), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7252), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7253), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 13,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7258), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7256), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7257), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 14,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7262), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7260), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7261), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 15,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7266), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7264), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7265), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 16,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7270), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7268), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7269), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 17,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7274), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7272), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7273), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 18,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7278), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7276), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7277), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 19,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7282), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7280), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7281), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 20,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7286), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7284), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7285), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 21,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7292), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7290), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7291), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 22,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7297), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7295), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7296), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 23,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7301), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7299), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7300), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 24,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7305), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7303), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7304), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 25,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7308), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7307), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7307), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 26,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7312), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7311), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7311), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 27,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7316), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7315), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7315), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 28,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7320), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7318), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7319), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 29,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7324), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7322), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7323), new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 8,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 9,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 10,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 47, 16, 900, DateTimeKind.Utc).AddTicks(6935));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "BillPayment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95d1f026-f9e8-4e71-a9de-71d0ef33e939", "AQAAAAIAAYagAAAAEEI7P7mQyxXIb6+Cg93vH106YfsQug2+26a/xDPi+at5HD3YNL8smHE2ijC/XzEeeA==", "6e306008-8844-43c5-a206-966d1bd6ba25" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40f84934-9355-4669-a62b-b483678a6001", "AQAAAAIAAYagAAAAEJqM0Yr5E7zWHqs/cLco3TNK01bfhc/OWCR4UDxRUayQnb8k1pqP8MBiAz981Q4csg==", "3cff7e12-db70-4832-9d15-b707b75f1fae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "443ea1a1-9ed4-4b10-987f-ce3e56ed70d3", "AQAAAAIAAYagAAAAEAohEX92w20VB3kzMpUNpKgYkh1JZ4pqJpcJdRjm9Nd4mrJXWE7UtXpwwL93WLCBng==", "8cb9656d-1077-451f-8d2c-bb01b81d9860" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c804aeb-df5a-4488-a4b6-08f4a6c37ae5", "AQAAAAIAAYagAAAAEHPod1hKXNNIfCMJp6FQIOUe4JvcP6henyg+zg8ImH8kl6O7FC2nE5oHcrIlhHzzbQ==", "f9edf658-122d-4416-a5d8-3d82ad0f95ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65cd9531-50db-403f-b0e9-260faf030d60", "AQAAAAIAAYagAAAAEBX9OVlhY4LZS7TS8GVvmaFWuc4n3i5f4J20twJp+7l2I/zMV5mSStpBr242J1OQNw==", "03f562fc-ebf1-47f7-9571-b0802bb69099" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ab4db7c-58b8-44c2-ae15-7acc00698800", "AQAAAAIAAYagAAAAEK4MWAyt8axn4Tx+oB2ba93J9gnhyEHNT2JD57CUUXe+lZp+RKhEU+YoLC8k/GTtPg==", "0679ad36-5ef8-472b-b657-7fd9e2cb6863" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bc9abb9-635a-4b9f-94a0-d370a86055eb", "AQAAAAIAAYagAAAAEKrGpserlqkskHqDpI6Vp1FHXl2e0qlRfRWcHu3BR82kXyw8aqypJrlIRZ0uxwYY1Q==", "4c080126-9dfe-4626-af8c-a10c24962729" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4592b2c5-c873-49d7-a9fd-c2f1dc179f10", "AQAAAAIAAYagAAAAEH0H2mLPuf+d+U4Zr8vuJooQyb+I8kMLCzlq1VAO+fqu0vbUAbRma/xkixV1LwGLyw==", "72392c64-319c-4936-859e-9f27d51811b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b875d02-7365-4308-84df-662e80f32bac", "AQAAAAIAAYagAAAAELSRm3+ddZTf9ncrecXpxC/ukH7lxY+6OR/FeKoCQjSZfCj0x3NB3TXdNoUr/eucMA==", "e749b1f5-45f5-4731-b33c-1a95681a5f60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18d76045-29d2-4288-b513-792ceb2cef88", "AQAAAAIAAYagAAAAEJYhVbzUXTz5g+7q45pGet5iBncsCmvxjtjcblXriMLGYZRUWeKhf/8qnYz+5zYwPA==", "ea44530b-2647-4fd1-a784-800510bd3fed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e76348e-b5ea-41f7-8ffe-4b0b5c88fa02", "AQAAAAIAAYagAAAAEAYJAE1TlHrSElaFZ6DQUbwMHMKP4OeanDTB+xqgfQqNIWFZS2vsc4jOl+MmEL1Fmg==", "a41e044c-df18-431c-8df8-8c9098332367" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18d77c0d-a0f4-46a4-9968-85ede862b88d", "AQAAAAIAAYagAAAAECiPJxioP9z4wGm3MlRQMV8/opD/0PRQw5LZgzAQkjk20M/Ctr+guxgGSOXzv2j7jw==", "52cb671f-60b4-4f28-aad1-89112926a965" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "113",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d99b653c-cd4f-4d5a-97ec-9e1f3db3aead", "AQAAAAIAAYagAAAAEIDgCtOSosxsygby7UnJQwMdZsTnUjHFYh7Wx2+jqO0o1KGlgJ8B5RxaVeR7eRG/8g==", "74de51c7-3009-42be-8bd9-d257e47cfd3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "114",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "987ff812-5a84-4b09-bba8-9ea5c980b933", "AQAAAAIAAYagAAAAEBeZD/T2n/BZ928spAUKomWe+zSdLH0fvdpDrQ5QzbDQL5Zv0QmSgo44Efz3rO5REA==", "f42348b1-b4b7-4630-9a57-f412f4f0f4c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "115",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2130e480-bfcf-43f5-9ac3-151c02eec093", "AQAAAAIAAYagAAAAEGYreXVx9PVgtxKSNlz/bRiGbEl0qDJIeMpJmVkfFmYFZS8EZwcNgxi94QoKHjZuQw==", "5163cf08-8845-4f2d-ae1d-2c9084e6d208" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "116",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2422bf6f-88d5-4bff-a65a-a55eaace8c83", "AQAAAAIAAYagAAAAEOxc0QVpSswClXWCDGXVUJgl9qoaaZHatKqgr1k1a3IyA5cCrVvNj3iIMA6Q6O7WqA==", "56210cd6-e37c-4c50-99e3-a07b65828640" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "117",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f773c73b-d550-46ba-ad9a-aad07fa5a3d4", "AQAAAAIAAYagAAAAECMrhUC3c3lgxD+ZJaVzX0fgQ4q6thmOa9uq+XblQ7z3z2Bl8LT+jBxu8oKojd9W6w==", "d28d988e-8035-4a6c-a013-7a18a861d8f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba869e1a-ce6e-4ee4-b55a-27b4644dcd0d", "AQAAAAIAAYagAAAAEJ0zeNAdU45yDn7PiNMTLpm7jcc7t21aEirLtB8Ur3o8I6TF8Ct0qmjjC3UHN3Cn0A==", "8a23eee5-2e22-44ef-9b5e-bb3d10d1f3f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6957e117-2895-4e82-9647-2c5116875a1e", "AQAAAAIAAYagAAAAEKOfP0LYTdoW7KGSZsCUUHjwwXZYIsiYokm7/7S3E4nm0O5L5da7mEa+3PKsypZGXQ==", "15857d90-0fbd-4c9c-9115-613cc1c51b85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "febdb1c6-f62a-4c40-ac5b-b62f0e9c630e", "AQAAAAIAAYagAAAAECGn2sbg+lxP63+G9JGgBc9slWRnNAf80eDkwdjp+Ryo8yo4Rdl6/UPSsMIkPoL26Q==", "be3055c1-a1ce-459f-a8b2-1c118e64d3e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "121",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b122f91a-548f-4073-be4c-92b77ccb9edb", "AQAAAAIAAYagAAAAEJMQsalUhYHqAsAhXDLOyrMv/suEuMIh72eVA0w+K72mD7ruyHWRg1MHqi1v9RotiA==", "bd60ece0-1e80-4f9c-a8e5-c8c413be2b86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6744515f-6be1-4066-82ae-5e2e93a247f2", "AQAAAAIAAYagAAAAELWZwlAq9pWyuItkjcOahItFnIVJXdtuO+otvzIPfW1DtnJg+UU9lwkxn3WK4p7GRw==", "0bf5dfb0-ec94-462e-b3e6-733677b74003" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84f45780-22d9-4dfc-8c9b-8e802e2a1111", "AQAAAAIAAYagAAAAEII35Xxg/k3FB71TCHT3r3jB3qZ/eT0EzvEdTdLHusu/RRtm468jiIuROeAVZb+Tjw==", "12bf4466-89a3-4a18-8a62-85107b372df9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4d23f64-563c-479d-9a8e-288ff6eee196", "AQAAAAIAAYagAAAAECOrEGZ3z2dQQIaUf2pCH5Bka82qq59qA3oSEn8OBw9wx/cXXe7L86yeJg0Knb2x6A==", "3f0c54cf-6e68-4e5a-9576-d1fb40f4e483" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "125",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a01ea1b8-978f-4356-84b5-fdb554251d76", "AQAAAAIAAYagAAAAEO5OJQOZo2VoCAWpyqJUcv+eE1XDODL0zr0efPT7QICJpWSRub8w14p31vp4+qF09Q==", "706fe745-a7e3-48ab-8deb-cb9a4ce04a34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "126",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b372452-65e3-497a-b43e-ebab96feb678", "AQAAAAIAAYagAAAAEMosBXhn2LtsKFSKFN2zSEbNXmmS8/oO2ValMpZy6GFah4iLdTZ/IdQKG2LL7xRpdg==", "8887f762-93c3-4bf1-9a48-6c68935af3ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2246494-0e2c-4e73-a432-7fd67aa31560", "AQAAAAIAAYagAAAAEEaiHFpz4wVIZWuHbKsuZrA+bAc0oPTNcWB2u8TmXzcNJlVtEGLLlCfVW9jT7msmig==", "ff30ea0c-6c4f-43c9-9034-f110c962bd55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "128",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7b9f92e-4de3-451a-91f9-25f982756baf", "AQAAAAIAAYagAAAAEBSy5l2H+1ubScGPwgLhOTRC1JSZiP0twWe7q+9ObTPOw9+80i4HDw5wD/hH3/gjDg==", "8fec1cbc-02d5-46e0-b603-03f9cf3e9c22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b462ef51-dfb3-44b3-a380-f17db197b1d9", "AQAAAAIAAYagAAAAECLvcYTtnyEAZwbt/W1e9qMaEDOeuvRqEaQQoqaGW925LM+NEVcFT4dvQV3gYOWEOQ==", "03c192ab-66a7-4375-89fa-e587c887215f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "130",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc84ca56-a8ae-4d0a-add8-77564878867a", "AQAAAAIAAYagAAAAEBHxmpX+blz/sH7VYUvKuTkQvLiGtTSywqAU6TQZEi921jfIhaqj8eeo2+hsVwBdBw==", "26de7a0d-c703-4fc3-b93d-d264817a7a97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47ba055c-505f-4629-9f96-fa14b73b591b", "AQAAAAIAAYagAAAAEOsQamTKUD3eGVSbXKdEckJHchTIzRUbxH5ilWKI9CLSbDD5Ne8K1OYcJOFWkd7Vuw==", "186b0d42-68f1-4610-a7b7-0fa8082ef5b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "132",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fe57201-1538-49eb-b8d3-437d16943999", "AQAAAAIAAYagAAAAEDJI5q/A79dDsb0YUcMb1S12+iwchSDgfcaxRgzIvLLLd8O4j1luLs5Qfozngr3tkg==", "9ca7edd4-cff3-4c3f-bf80-2c7a15ce2193" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "133",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0cddc77-b46f-4bc1-8e04-ae08c7ddbfe8", "AQAAAAIAAYagAAAAELSwS3wfcCbEAZjGwt7kD2rah+mS/zQolaM6GNhXJoTaeDnKEtyWkNWGhBqvMLnxPQ==", "e61ec30a-7e39-48ea-a6a4-4c1af57d7497" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c644aea9-a2e7-4760-b390-98c547251dbc", "AQAAAAIAAYagAAAAECiyfl80A3pPilfgUS43hT12tI19VEN5ZxFkvNR0v4lrX784PrzQtOVDuSEIlIxWBg==", "4b3aac45-a296-4f5b-9280-7910ceec4dd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "135",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8becbf51-1a91-429f-b02f-1e395c56a21d", "AQAAAAIAAYagAAAAEI46XL5e53CeIvbYoI64oCVigCd/VkU20xfVjT4OXLIS+RUBsOOMTtzHUTYbvVyK8g==", "ac5259d7-7992-4c68-9955-5a7c4b781ec6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "136",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca300fc9-63ba-4ef9-a8bf-2584ae6af989", "AQAAAAIAAYagAAAAEIJ4lwzCJxskAbZiYvyLM+IGrMPCIj7uMeHIpOZSXXfVmpKoH7rvAd3TvKBvzS/Y/w==", "df6f986e-ce34-4354-823e-0b07b5d0799c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "137",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91d9b3e6-0411-43d9-88a5-1838deabf4dc", "AQAAAAIAAYagAAAAEH9qMH/O0TWzJDC7lAwqJKM1TEUlrbICaazNJqCukW7lOVfReXIZ/PI0J0BC1vUM9g==", "e72b41b6-4cb8-479f-a55b-d2798ffbcd55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "138",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43eeb361-de25-45be-8965-2d4aad02ea72", "AQAAAAIAAYagAAAAECHcmVKhHw+HpKASkgJxkb2Shz2c4UaPYpPeFvwPvIV4CllhpV6A4H+qCNPkkNylIA==", "0eab57c3-e8c1-4a44-8952-a5078bb9e822" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "139",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f47556b-9c87-438c-bdfb-d8ef81c3a147", "AQAAAAIAAYagAAAAEPjSfuLTjfKFudNSqYgQv8fhKa/0BFKgeTFUxPPPafx5bR96NePb4iz+so2CmzH60Q==", "47001e8c-5fde-4adc-91a1-ecfb1fd58b37" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 1,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(777), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(775), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(776), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 2,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(781), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(780), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(781), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 3,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(793), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(783), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(792), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 4,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(796), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(795), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(796), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(797) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 5,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(799), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(798), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(798), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 6,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(801), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(800), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(801), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 7,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(804), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(803), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(803), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 8,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(806), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(805), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(806), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 9,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(809), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(808), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(808), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 10,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(811), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(810), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(811), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 11,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(814), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(813), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(813), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 12,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(816), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(815), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(815), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 13,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(819), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(818), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(818), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 14,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(821), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(820), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(821), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 15,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(824), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(823), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(823), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 16,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(826), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(825), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(825), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 17,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(828), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(827), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(828), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 18,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(831), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(830), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(830), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 19,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(833), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(832), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(833), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 20,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(836), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(835), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(835), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 21,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(839), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(837), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(838), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 22,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(841), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(840), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(840), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 23,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(843), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(842), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(843), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 24,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(846), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(845), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(845), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 25,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(848), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(847), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(848), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 26,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(851), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(850), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(850), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 27,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(853), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(852), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(852), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(854) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 28,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(856), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(855), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(855), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 29,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(859), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(858), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(859), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 8,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 9,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 10,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(630));
        }
    }
}
