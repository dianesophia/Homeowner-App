using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class ARWERWER : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ArrivalDate",
                table: "VisitorGatepasses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsExited",
                table: "VisitorGatepasses",
                type: "bit",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivalDate",
                table: "VisitorGatepasses");

            migrationBuilder.DropColumn(
                name: "IsExited",
                table: "VisitorGatepasses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0f25705-3432-4d03-8724-df82da615643", "AQAAAAIAAYagAAAAEBgbUh8KglMHfuyoh9dfgBKXV+olAAEHxPdBiOEClHxpXW46SneAXwdn3JL8uwupCw==", "d944236e-c890-48bb-a7ea-4536e00ddb4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e998b0f4-a706-48b8-9b24-02d217362c86", "AQAAAAIAAYagAAAAEE4bREvXI+B/g8H6kpMZMlXHDDWlCryBRBKb8JgMVgoGufqxOi/zV6D3KYyzg47taA==", "61f1546a-1278-412c-a8d8-1f7bf4cfe70d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbe02b9d-3077-41af-bb89-6e5e06ab6588", "AQAAAAIAAYagAAAAEOJdS05GNlHkKOWQqClc5MWjHN/eu3o1rxJLjjyQ03DJab2XhHp3HGIjfAgmXXD9qA==", "a53ff15e-d9d1-424e-8a46-009a650fc64c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7dffee2-190e-49a7-a36f-06bdc3657a5f", "AQAAAAIAAYagAAAAEE2ZlSWYrdn0MzwDLRcPlBMIXM23Gfapq50GwZHFXf9nINXR1+59HulONagkx/6y7A==", "e3283a68-0fc9-4131-b46f-169db55401c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3ace966-b337-43ce-802c-e709df5751ca", "AQAAAAIAAYagAAAAEFLx9mxOFEEYjjMx6Z6M8AxLSDpYCGhz/QjZWIXXHLdbTmqqbQAkxApHDlZe7n+uIw==", "60932443-1161-4e7c-ae89-c42a95a16136" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17c98685-b2f2-404d-83b4-55991b74c1cd", "AQAAAAIAAYagAAAAEDcxTjh4m3SfNow/4+I1O8gXCfkYYBR06fqvgpCmEtsX7HlcO+IhhWGoo1lWddlDjw==", "a4c64847-2660-4106-8e41-a8cc70ce1e6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3143198-285f-4741-80ec-4d168dd03366", "AQAAAAIAAYagAAAAEClvMHE7ok5lU/FKKV6kLwvx0OpMZRLolN51Hr6VHv2oY76niet8LSDwGofRUg/jLw==", "3557680a-2a70-427e-bf6d-3a25693e0700" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb680370-41e9-463c-b5b3-78164b1b2ca3", "AQAAAAIAAYagAAAAEPByb21KGqJoznxFZ5vXbGxYhG9QfGnUCQTcH+f6NpKVgRE/wRdnFQBR/xJSmc0z/w==", "db6d83cc-19d9-4a75-86ba-532909fae15b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03f614b6-72b9-4f31-89f9-44b032e264a8", "AQAAAAIAAYagAAAAEB4BmnOh683A3SthUi0suPsuxXF5nnaGzI5OQ8Ek3dyuoNN4UWUpjSmEr9VZHVSrAA==", "4020fe4e-9011-43f3-b97a-46abd1fdcccf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e11ce2ec-9f81-4c99-9982-f88d134640a3", "AQAAAAIAAYagAAAAEIodk8FK0hN0ACJY4qYHJ8+hZJZ3gXJTWdbEGnYt0CfwQBOV2IDzWzpvI1WZGBlgqA==", "f19833f9-40e2-4cc9-a498-6a5a94c4621d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31268d4f-2935-48ae-8e93-ba830e5714e1", "AQAAAAIAAYagAAAAEOAIL/oeiZZIYGi7uPFwRYqTjqQztI8fmD3qPyoBcYdNUwKyHf3YSYdj43MK49Cgvg==", "98d13673-ea7b-408e-984b-099d3481b624" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "548a4e66-c63d-4ddd-a883-673e71fef29b", "AQAAAAIAAYagAAAAEKVnc9DIc7owGoLysxQI5T8MGMXqnhsih3cQnYCUqYY8M5h7LpvqUvumxOREkTE/Rw==", "cd17f073-c335-4167-817f-f4dbdcf09579" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "113",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e872cc95-33b3-4ccc-8e4b-eddbe5040799", "AQAAAAIAAYagAAAAEGeScklWwR7ttiPaypgksjtGSmaYMaTgxnDPaUdBOurAgQoLLMZ778/FWeCr0GAypQ==", "d2742354-a63e-44e3-be9d-9a330371f351" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "114",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f504818e-3831-4622-81e6-01f20467ddc7", "AQAAAAIAAYagAAAAEI+qlWIpBZSFrHeuYGek3jkEMOre0hO7zvoIb7Ms+k6gKp1pgsjPV5eQKAKstO7B9g==", "c9071e70-1683-478d-8b0c-1af6e69e0b60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "115",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dd18a35-8b22-40ee-beb2-92116ce545a6", "AQAAAAIAAYagAAAAEGidNL1sb+w8lA+IkbDREBl6OYth07bcLuHy6gcDuY/4aY/06BGsWuIIORv51WTu2w==", "8fc20c74-c6d1-414c-ac01-74c7471900c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "116",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b8c19fb-5f9e-4e74-b65b-55149f117cf0", "AQAAAAIAAYagAAAAENcYyHBYREKH2Gu1+vtSSHQPLGanZbHDXdXk8vwBVPhG0km5wqxXy9X5CmiJZdS6yA==", "a298c6a7-d238-4de3-8563-3c856de65708" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "117",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9be848d-15a9-49cd-86c9-d5d2bb978dd8", "AQAAAAIAAYagAAAAECxDyTfkTkDqBTRH3ZDC+EWCn7PlYhOzhWxhuaYgJgF6TGlaX6+jQz/Fw2zKwCIABg==", "2e53d531-12a0-44c3-ba7b-56a3bde1a645" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a95b2c9-4078-430d-a724-4c2fb61c2089", "AQAAAAIAAYagAAAAECWGpXNVe7+zPJHi1IeFiBOqemAAuFjeNS/zZV0VGUNgb6gD65OsfEUI/kptbh2oIQ==", "7ed01fac-8e13-40dd-93d3-70eec42f09a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a796ada8-0d68-43a0-98f9-968ab81a3629", "AQAAAAIAAYagAAAAEBKkZJMLBgaRzgaX/2885MnwX8VygfqX3XBiotG0hMyYVpySRBiTvtyShtHA3Lm1CQ==", "d7ca235a-da9b-4eb6-aa34-d3949d390930" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffcb1c2a-dbdd-4527-85e2-9d1b1af88415", "AQAAAAIAAYagAAAAEP2JYvNq1gb64YpiT16cbw/uP5awN9OqM1bfWU3zRsnRH16RwSqmt6cokwBLBJqjTQ==", "dc1e0087-6d6c-4d60-90c2-cdcd61be1e7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "121",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6050e87c-56b1-4f41-8e2d-92d796a193ff", "AQAAAAIAAYagAAAAEEUlrHvxsEd503iEXr+BNYDKppDgRvOxjgOonukJSBO/s+0ykapQUJGT3Tvsng6GYA==", "7049eb29-4e7b-44ca-b9e8-f068ca250620" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba546930-3af8-4523-a393-5367c2f23448", "AQAAAAIAAYagAAAAEJChSNTDvp08LRerfbSjjFHu/V3UHhvbBndc30/Ye+YI2CsS7Nhmf41YY5FnNoDwXw==", "36f0751a-fe5c-4c4e-82c8-cf521cb885e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba3e1b5b-13fa-44d9-b1e0-cbb7b46b3ea8", "AQAAAAIAAYagAAAAEJmXsjRagAXHUeP+thc0StnkE47C/pa7G0uSA0dZeeTrrIFcOF+hhXKFnJ97i3PZmQ==", "4fd72789-25c7-40bd-9e7f-e471c0caf423" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2abc2a0a-f08f-4695-ab11-3342acf44381", "AQAAAAIAAYagAAAAELEsHE1PmXlhqFIEFpj3wIZkVD5EJ7IUEo1xPEc3mkWxTJpu7vO6HWYsd71POCLODg==", "983c4e63-3f32-4f1d-ad07-c2153747f1f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "125",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1f09868-8309-48a1-8c9b-a14927b32a51", "AQAAAAIAAYagAAAAENfhqrsoQC7NHfC8kWnSJlOz1rtdHiTprI1ZgvCCMAz4Oe5NkXlYJT8ZLuVrtSuy3w==", "35e25b27-2737-4bc9-b8af-036e1a8f41f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "126",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6ab6bdd-3a50-4ab0-9783-b253e7035381", "AQAAAAIAAYagAAAAEMRhblIaKSix6woRLH4XNMRt7h6+khiar4REIIU8aR8z+N4IepXaegk5Vfn/vyjNoA==", "ce43ad65-5563-4a95-bb58-b07a15fc6d92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fa4e989-dc04-4765-b819-f56852c66197", "AQAAAAIAAYagAAAAEJy8ju6sN0kCIbbhuVjAQHTbNhZcpN/XOXgSRg+YpKnNGXd1a+GE7z5WJsqiyg1mPw==", "447a421a-6b54-41ac-9b23-bcd3e58a59f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "128",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93ad5bba-dd94-428a-9f95-b6e032bacb47", "AQAAAAIAAYagAAAAEGcOxr25LFlmsx9gO63cjwMBIfbDFK20qvnDgJ2jJ9aRJejvO5ueIsIR59YVLGfesA==", "9bb11b8f-4822-46c4-9ca5-4471168e2dfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a33fdf0-b55c-4bf0-b4dd-9928668d1935", "AQAAAAIAAYagAAAAEM30nEcKAd9bzfHx/QyTtegAWMBzS66RQ5crQaE+vzHIPNWen0KctjoRLNdOU/NVBQ==", "8be403ee-b451-4a96-b3bb-b19367f6ed13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "130",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "707b332a-9497-4502-9005-074c20a16da8", "AQAAAAIAAYagAAAAEPCo2/nkMn9ANt+/tQbIhQ7MfGYEE6rSfnRPdK6Em1TeiDuGB8lBSX+0GGXfP0R56w==", "614a2c91-c4b5-474c-baa9-6b9cc1272188" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02b7c486-4c3f-4262-bb3d-f9f867cd6bed", "AQAAAAIAAYagAAAAEGS98bECzrTVJv1Fbvy0Rb4Oa4HH7L9JaqZHCSnwzW7zntycO3etZTxbY6MFGZWCFg==", "3b05db16-b4f3-4749-aa79-4008423fa0d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "132",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e414aee4-d7cc-40c3-adf3-87b1ac7c0605", "AQAAAAIAAYagAAAAEFoNH0jNj4bfnRBgmAmeltFwRNrgyzbQMCVOZWEyb00GZYKZyAd6zvg9nQnkCkuu3Q==", "44c750be-976f-4e4c-9fbb-5daa8f7ecc0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "133",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73347cba-2891-46a8-b3d7-6f8b8ecdfab9", "AQAAAAIAAYagAAAAEAvBUc/YBCuZbCpzUcx6iZLTA0KhsQkEUgNPn5rFCRJQWRCtKVu0WeoKLdUEr3teyQ==", "177c7343-8fe4-4424-b1be-3d4613ebbe4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1e150fc-1dae-4a71-b465-d497766ebbb2", "AQAAAAIAAYagAAAAELiUTfL1lJEMFlDeFwcDlN41xjUg424GM80xyCvkXbGhwUc9olVsTqcnAdIkyTJlHA==", "dc426f4c-8ed7-43b9-b354-423b6780d2d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "135",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b57c4391-2764-4b24-b891-1d43d604b370", "AQAAAAIAAYagAAAAENpGnV6xhuxj8yfDraAoZYB5QuLpOSwdEaCKJHiAhjwDAmZhy/oXfgxxL1WQLO5uVw==", "153f0bb8-2240-451e-8544-b16b9890b88e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "136",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "836bde73-063f-4ca5-83b4-2794b9eeb281", "AQAAAAIAAYagAAAAEIkxVYYdYP9ndN37btZPhm0Kz3FYyPGMNlvFm3eH9TAezP2vJsARgxV4O+jPr/tRLg==", "5e5e85ed-c087-4868-a1d4-efd8a69d7fc1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "137",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "126921e2-7b9f-499b-a4d7-1f1d748caac9", "AQAAAAIAAYagAAAAECN6BxQtnpaRNc/4JOtw+erzmbQNuPy0IXbuAH9qVzEjhP6e1jMNnAgyKY0pSSwwZw==", "9d0a8eee-34f7-408f-b278-5ac40e0e7be2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "138",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab772721-31ed-40df-9ae6-58b346ebf248", "AQAAAAIAAYagAAAAEEIDrswghCzBM5M5YTb8SEEvCipr4zRsybONW/JyOVb/6oOaGyaXZWymTzi3uwZ/aw==", "20c4f15a-b8bb-4baf-b49d-975e6f2ea7aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "139",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bf81c6a-5c64-4c40-9422-40c8368b47c6", "AQAAAAIAAYagAAAAEMhknGbN9gCei9MWA8EYfeAU/Hk+JSvORdExZeLBZtj6wVpD0NxU9ESbPXwsdy2DqQ==", "48850d8f-8c1b-4077-bcbf-3d04145dd04d" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 44, 431, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 44, 431, DateTimeKind.Utc).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 44, 431, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 44, 431, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 44, 431, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 44, 431, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 44, 431, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 44, 431, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 44, 431, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 44, 431, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 1,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4118), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4116), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4117), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 2,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4124), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4122), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4123), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 3,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4139), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4128), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4138), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 4,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4143), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4141), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4142), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 5,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4147), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4145), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4146), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 6,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4151), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4149), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4150), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 7,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4155), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4153), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4154), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 8,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4159), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4157), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4158), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4159) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 9,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4162), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4161), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4161), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 10,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4166), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4164), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4165), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 11,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4170), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4168), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4169), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 12,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4174), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4172), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4173), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 13,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4178), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4176), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4177), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 14,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4181), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4180), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4180), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 15,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4185), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4183), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4184), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 16,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4189), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4187), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4188), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 17,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4193), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4191), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4192), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 18,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4197), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4195), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4196), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 19,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4200), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4199), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4199), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 20,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4204), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4202), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4203), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 21,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4208), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4206), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4207), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 22,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4212), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4210), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4211), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 23,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4216), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4214), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4215), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 24,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4219), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4218), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4218), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 25,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4223), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4221), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4222), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 26,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4227), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4225), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4226), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 27,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4231), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4229), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4230), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 28,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4235), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4233), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4234), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 29,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4238), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4237), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4237), new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(4239) });

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 8,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 9,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 10,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 21, 16, 42, 46, 698, DateTimeKind.Utc).AddTicks(3974));
        }
    }
}
