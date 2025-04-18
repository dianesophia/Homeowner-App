using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class DWTWERRD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillPayment_Bills_BillId",
                table: "BillPayment");

            migrationBuilder.DropTable(
                name: "BillDetail");

            migrationBuilder.DropTable(
                name: "BillTransactions");

            migrationBuilder.AddColumn<int>(
                name: "RatePerHour",
                table: "Facility",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BillId",
                table: "BillPayment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BillAssignmentId",
                table: "BillPayment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BillAssignmentModelBillAssignmentId",
                table: "BillPayment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BillModelBillId",
                table: "BillPayment",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c680321-d264-455d-a537-f04035008d4d", "AQAAAAIAAYagAAAAEH6OF7rvPTJ+CeJ4tUr8VOkD0F1g/CWgi8TRrsac63MnlsJh/WRNXGVuVN1bHShJYg==", "1b804c25-4be5-4e11-a993-00b9430c9cdf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b319eec5-9bd1-4fd5-846a-7e41c7415ac1", "AQAAAAIAAYagAAAAEPjZ+3qQqMJhPXnxORhFAoMA3P1r1LZ8sNe3mETz5c2b+goN7fX5WrXCoKtvuKMBnw==", "2e347273-7248-4be5-99d7-6158a6008b61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9927c9bf-6f16-474b-9369-d3352136df80", "AQAAAAIAAYagAAAAEOc7dgay1F2wWiFZnecNvRv5PN7S+kOjr1o0fKg7Ii4OcZ3zp3bjhdhwWoQrVDBUSQ==", "974ba5a4-880f-4de7-884e-421c4b1e0e14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d00b1ee7-172b-40df-b389-7e4dbd61551a", "AQAAAAIAAYagAAAAENrEA5Ytv5Dx6kV6fNVqmhSj7EBjrX1/uG3Kx9BtrALb28jiV/vI5/bdaWUpZ84nMw==", "2dff1d3f-5023-4464-853d-53948c4da861" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84e2c057-403f-4e7f-9458-27a8903c4f6a", "AQAAAAIAAYagAAAAED1CEz8zLYz7r47/yMYRWY4sx28gIWnUwG4OSmsagp2P/1bcVaQDI65SJJv7LbFoXw==", "aef6fe6f-4d47-4825-888d-7789775416af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e55ddcc7-ec36-4240-b691-db8f59fea676", "AQAAAAIAAYagAAAAEKEw5NgKiviTZ8OBorwTc0KnH2d/G+GTXxqdKpn5k3njsdmnee0WFZNlT8oQCeCEDA==", "eb01f848-7011-427c-bfde-59390e47d266" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7727d0f9-d65d-41ca-b1e9-7cab8576cd77", "AQAAAAIAAYagAAAAEPvz8sEFQuX51x/UrbhHEPLVm29Y7rOkeUtD9rmuOgQ/bkIeeHJ/WHfXEns1q4EGfQ==", "967b6cfa-f359-4d57-8415-677995ba67a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c85ce0e2-dab4-46a8-b64e-ade5edcde50e", "AQAAAAIAAYagAAAAEMiBpAxwarVHtbmRSsNOk1X8iqXKaxWd8nvXKfoGejKyzPotaLqdfPJ39vQlWZVAqA==", "3d18f23d-a4e3-40c5-a42f-11eaa8fbb469" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6c0ed48-bd53-4e03-aea6-a05e6b741a58", "AQAAAAIAAYagAAAAEAwgwZFtGyVHJ+2Uyc9h3FcaXp8cJOF//q5E0fy0fob3+c7SPNR9o3muWAgaGJuuQQ==", "6227292f-effa-49be-83a8-0286cc001ed2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50bf8a7b-ffe2-443b-aa98-a7e141d9ad04", "AQAAAAIAAYagAAAAEOiP3MJ7xIlFDndpkl6wEInLhTcSJ2mwIhfJnSumWV+gM6jTZ5FjqsD6VuXxZLxqdA==", "2863f7d4-b69b-4721-8f98-3f6130cfa708" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1ff0bb5-75a9-400d-a389-ce5523c43e63", "AQAAAAIAAYagAAAAEOVGrPIRymF73yMGS2nedXH3igi7NGqGdn0Z03ZoPXMrc3oSM92Xn0oGS+m+snBEOQ==", "84418be1-cca0-457e-9396-c7766b5c6223" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93abafd2-e296-4f88-9b2a-a76d8e9f91ce", "AQAAAAIAAYagAAAAECYf7Jn8VYbst6XzKjIv7C8OsyOuLRhB0DiFQVnUwsLnRX66w1WOima2nyhy3hTQhQ==", "251cd807-0eae-45f4-8a0b-257b4f431bdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "113",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f1e07b2-c716-4ac1-92bf-a610bd28e921", "AQAAAAIAAYagAAAAEAPTp5crHbp8IsK2hCfvSHVi1uPgB1vAoDakXdKzxjI2AZ/3DAFeHRr5UiwNV0tPlQ==", "de5ba598-66ff-413b-ab38-3d54b9cad142" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "114",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3242519c-2b55-4092-83e9-62c5d756469f", "AQAAAAIAAYagAAAAED++4Y6BwBYoKfcbDrrAp8Kwu7FLbeHt3SSVVAp29L/zneYZ7rueY0duXIYdkC5stA==", "217f4e3d-1013-4fd9-ba26-1269a5e75d61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "115",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02a515b5-d5d6-44f6-b698-ef0d49e744ea", "AQAAAAIAAYagAAAAEE37JCzmySs/hOqEcEc6P1Du0/r6oa35hI6H1iq4AQR3uGodDAERDRgh2MXiHcpnyA==", "fe88acd9-431c-4526-bcee-7a0f4c1b5bdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "116",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19074eec-58ea-4509-96ff-e113d597e6b8", "AQAAAAIAAYagAAAAEHS/lKHfhdqxhbnsixTcRgv7SnQliosBI5oFZREd+bOk8uWfbli/pmdQ/829aPVBng==", "79501196-6d70-4977-827b-fd5629dbdf7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "117",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04ba20ac-a325-4b9a-91a9-036706a888f5", "AQAAAAIAAYagAAAAEK7GqmgcoPr/9fPqd2GxFIanCWMjNSLcolhi6jozaspMIrkxowCXqDE+7vHFbr2asA==", "d29604df-d723-4a3a-82f9-ca2e26e1e116" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2aaeeeb5-b575-4424-8a33-ea94cbfb2aae", "AQAAAAIAAYagAAAAEMMC0X7qmTB4G3qg+J2kMw5yFwNsMvYQXIvpO5u/SOvW1EvhsB6uiLYdqddkbZfpkA==", "1812d7cd-0d2e-4e2c-a293-33eed69b3600" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "692177d8-32f9-47d6-bacd-2e06964795d3", "AQAAAAIAAYagAAAAEA7VQ72Wk3G1A+JULVj70EV3keEru4gsuzZiu3b6RIOsG2ziA0PWMTumpQVqUgvGNw==", "0f7b0782-84d3-4f43-8e2d-000d3983ebfc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f01bdea6-ec92-459e-8275-285cbc4f368e", "AQAAAAIAAYagAAAAEEnw+4o/e+Zd4W8uf4GTFpfYAAVv6/7NaijFF7yIhWP+iWfPrvIhv3ZMU9nhGMoLKg==", "93cb542e-743c-48fb-b50e-19019cfcae27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "121",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9680e0d-f47e-4764-80be-a1add81bd31f", "AQAAAAIAAYagAAAAEAJoEGHzeUvUVBjeUPBr00kj/M+RSkHWxL+anZxBSth31a34MRfbPH7aMl35Sse2xw==", "9a31266c-7924-484b-84f1-6e27d5ae6aa4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61955b0f-5167-41db-8c28-92cb0b956fef", "AQAAAAIAAYagAAAAEOaaagWZIQ6DKugfr5LRAwvlP8Nplk01LLGo849m/DZCA0OiBd7s2HblJVAvxtMeVA==", "614b85ce-63d0-4865-af7c-a7e7d63df4ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d00d27c7-fbab-4572-8357-a733ee4e40ab", "AQAAAAIAAYagAAAAEOa4dM0SEHh6oNrl8e9hZWpx9BygiZqO2cFHoBZPLS85iySRHPnthd4CDooyOD+O1A==", "d94a9484-61e4-4a0d-a5d1-8890271397d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a58cf788-edc4-4f4f-bd60-9d89fa4910a2", "AQAAAAIAAYagAAAAEH40gaHak21NQ3YaA1EKb592O2e1nMwGaPJpRNK8RnASyL9kaG3vqUXMz3Wda8lb0w==", "9f235e0e-77e8-4ebc-b3a2-354e95dbf461" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "125",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e236ddcc-e6b0-4602-8df1-0a7573d03ca8", "AQAAAAIAAYagAAAAEIXqKQQNks5zWVl9QI8tTmtQdHl9rlWU+B30mtSY0M1Uxs6QQoqLyCOMtPd70ZXp2w==", "05f8ea98-fa03-43a5-b0df-cb2ac5877c98" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "126",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d497f748-553b-433e-9a5f-3e49e58e48e0", "AQAAAAIAAYagAAAAEKmBkYkOjdjxR8M2FL3Mzd7zlRLHl36Zi/XnaxXMxZiAHxWfiv7enDmRD+hL5+aBBA==", "4e0a0f51-c0e5-49b2-8296-86c6c9afca15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e14c4e30-3e73-4fba-a19a-d58bab83d0f2", "AQAAAAIAAYagAAAAEOZcvjJygI8ovJmCwVWdQwfWUAkHKM7JBmywMOfka4G8r1X8ZcgIxxAB48CvZWe02A==", "ba009703-7f98-40fd-8136-b6957e6aa177" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "128",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93a535d5-2848-408f-850c-3173250bdcb7", "AQAAAAIAAYagAAAAEPU01xiClEOdCrZE6dhc0a0Y3fthX+6CgyJnfkfVaIMaPLdIhawBdR0Ryh0l4dLh6g==", "701c7dac-90cf-4341-8592-56fccf1a0ec5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ffffc86-0b3c-4e3c-95ba-bef542cd7570", "AQAAAAIAAYagAAAAEIxaob8scHb7/xbbdkxjQlMWzaHcfH6bHIz5hBeMYe4C4Mst29EWEMZZqvkRtI9BBw==", "2b3e1c66-92ea-42e0-896d-0a41b4585626" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "130",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbe78df6-f3f5-4ea4-91f6-61a246798218", "AQAAAAIAAYagAAAAELX4edsJl437P8JfvFuaxIM9K8k4B9XNczjR2b3MBwgQeOILUQEaE748WNvUk63uoQ==", "ba41d446-1272-479c-ac46-b77f98d4a44f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "302811e5-39d9-4341-9983-8efe643d119d", "AQAAAAIAAYagAAAAEGPIRydl2eidF4Sy2UyEdnCvcMKB5QNqvz5aLMAj94uRWXTZBkIXNJdjDeq4kMg5sA==", "cbc4d86f-22f5-426f-a78a-6c99b73df04b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "132",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efafe6c2-9588-4ebe-9f7a-dd6831dbc542", "AQAAAAIAAYagAAAAEOvFzT2ch8imGk1xQSPIC+MSAB256vf1R373WR2RBEUwpVBnz4dqx5H1SFNfEwiFeQ==", "b6936458-a593-4ef7-a006-54de01a342c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "133",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "680db8c4-02fa-4de9-af94-40734a09787c", "AQAAAAIAAYagAAAAEDZpOJaphe5bovV08wEQldPq70+rRbTJxviKmBfjTvCjNZ96UIYFNRyJJf/URHzU5w==", "8cbbd99b-c50c-4709-9744-ff6f2c77b009" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc20287a-2cdf-4fa5-8e84-cdc0018d4d0f", "AQAAAAIAAYagAAAAEG0Gf51T7WJBFubupcxs8ApNsJfuJq5V2I3o/eTY8i2ftb3B1QWYEcwiQ+MCvHJ/9g==", "1c49d08a-8180-4fd1-801b-cadffd3efc62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "135",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4495934-d8ad-4093-9649-ee1dd8e05fc9", "AQAAAAIAAYagAAAAEFf8Z+jrZySqCtZnvbkAYzzqo+4Xc4uIR3GNBSYHP2ZnAgMeuujS9mgtLboEaRK5vw==", "d5f3256a-5b07-4d8e-8a6d-06fbbbca7f88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "136",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04156213-e3b3-4ed2-91d8-f84913512731", "AQAAAAIAAYagAAAAELlat9h0e1JLpDkJM8gGlYnIvwDeD6XSM+UBiD6L33y71mUnbzjN7BPAkj7kDGiZ7g==", "d6d7bfaa-1e25-4351-a5f3-6d86fe0e8d8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "137",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fc5c292-b7aa-4c9d-b08b-ce2462145e46", "AQAAAAIAAYagAAAAENi0OtHFcgsh+BbqnYRzlEyijEMTVPBcuaqBfcdS8jblq7JNckrFLXprbO3xngbzRQ==", "e591c40e-e27e-46ea-88cb-249bdb1d7f3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "138",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8a07d50-7d1d-43c3-a472-7ff065511732", "AQAAAAIAAYagAAAAEGMMbMDKvYXzsqmk3HHSSzGjvGi7Dmzo4J06VsRsDPJ2LSCDwEEr8i5NcYRH/sAEJg==", "c13f7a9b-3a2b-4c00-ac6d-ae4826605698" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "139",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bff6364-166f-4d7d-9762-04cc766c97cf", "AQAAAAIAAYagAAAAEF8ggMjZUyemJYXmuMdOnlobIwZyMo2YJAO4XVO2t5zma1j0kyWwf0uXA0uig/Mcwg==", "4ed71a5a-ea8b-415b-a81f-24dc0a38ac38" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 6, 553, DateTimeKind.Utc).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 6, 553, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 6, 553, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 6, 553, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 6, 553, DateTimeKind.Utc).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 6, 553, DateTimeKind.Utc).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 6, 553, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 6, 553, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 6, 553, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 6, 553, DateTimeKind.Utc).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 1,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7640), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7638), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7639), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 2,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7649), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7648), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7648), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 3,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7655), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7654), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7654), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 4,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7660), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7658), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7659), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 5,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7663), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7661), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7662), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 6,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7667), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7665), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7666), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 7,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7672), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7670), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7671), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 8,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7760), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7758), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7759), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 9,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7764), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7762), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7763), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 10,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7767), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7766), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7766), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 11,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7772), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7771), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7771), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 12,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7776), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7774), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7775), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7777) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 13,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7779), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7778), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7778), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 14,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7783), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7781), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7782), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 15,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7786), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7785), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7786), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 16,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7790), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7788), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7789), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 17,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7794), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7792), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7793), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 18,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7797), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7795), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7796), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 19,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7802), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7800), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7801), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 20,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7805), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7804), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7804), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 21,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7809), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7807), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7808), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 22,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7813), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7811), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7812), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 23,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7817), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7816), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7816), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 24,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7821), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7819), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7820), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 25,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7824), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 26,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7828), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7826), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7827), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 27,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7833), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7831), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7832), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 28,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7836), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7835), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7835), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 29,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7840), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7838), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7839), new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 8,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 9,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 10,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 18, 3, 20, 10, 114, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.CreateIndex(
                name: "IX_BillPayment_BillAssignmentId",
                table: "BillPayment",
                column: "BillAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BillPayment_BillAssignmentModelBillAssignmentId",
                table: "BillPayment",
                column: "BillAssignmentModelBillAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BillPayment_BillModelBillId",
                table: "BillPayment",
                column: "BillModelBillId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillPayment_BillAssignment_BillAssignmentId",
                table: "BillPayment",
                column: "BillAssignmentId",
                principalTable: "BillAssignment",
                principalColumn: "BillAssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillPayment_BillAssignment_BillAssignmentModelBillAssignmentId",
                table: "BillPayment",
                column: "BillAssignmentModelBillAssignmentId",
                principalTable: "BillAssignment",
                principalColumn: "BillAssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillPayment_Bills_BillId",
                table: "BillPayment",
                column: "BillId",
                principalTable: "Bills",
                principalColumn: "BillId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillPayment_Bills_BillModelBillId",
                table: "BillPayment",
                column: "BillModelBillId",
                principalTable: "Bills",
                principalColumn: "BillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillPayment_BillAssignment_BillAssignmentId",
                table: "BillPayment");

            migrationBuilder.DropForeignKey(
                name: "FK_BillPayment_BillAssignment_BillAssignmentModelBillAssignmentId",
                table: "BillPayment");

            migrationBuilder.DropForeignKey(
                name: "FK_BillPayment_Bills_BillId",
                table: "BillPayment");

            migrationBuilder.DropForeignKey(
                name: "FK_BillPayment_Bills_BillModelBillId",
                table: "BillPayment");

            migrationBuilder.DropIndex(
                name: "IX_BillPayment_BillAssignmentId",
                table: "BillPayment");

            migrationBuilder.DropIndex(
                name: "IX_BillPayment_BillAssignmentModelBillAssignmentId",
                table: "BillPayment");

            migrationBuilder.DropIndex(
                name: "IX_BillPayment_BillModelBillId",
                table: "BillPayment");

            migrationBuilder.DropColumn(
                name: "RatePerHour",
                table: "Facility");

            migrationBuilder.DropColumn(
                name: "BillAssignmentId",
                table: "BillPayment");

            migrationBuilder.DropColumn(
                name: "BillAssignmentModelBillAssignmentId",
                table: "BillPayment");

            migrationBuilder.DropColumn(
                name: "BillModelBillId",
                table: "BillPayment");

            migrationBuilder.AlterColumn<int>(
                name: "BillId",
                table: "BillPayment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "BillDetail",
                columns: table => new
                {
                    BillDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillId = table.Column<int>(type: "int", nullable: false),
                    BillItemsID = table.Column<int>(type: "int", nullable: false),
                    ActualAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetail", x => x.BillDetailId);
                    table.ForeignKey(
                        name: "FK_BillDetail_BillItems_BillItemsID",
                        column: x => x.BillItemsID,
                        principalTable: "BillItems",
                        principalColumn: "BillItemsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetail_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "BillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillTransactions",
                columns: table => new
                {
                    BillTransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillItemsId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    PaidBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentReference = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillTransactions", x => x.BillTransactionId);
                    table.ForeignKey(
                        name: "FK_BillTransactions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BillTransactions_BillItems_BillItemsId",
                        column: x => x.BillItemsId,
                        principalTable: "BillItems",
                        principalColumn: "BillItemsID");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff658a99-3a23-4773-a032-386b11912c54", "AQAAAAIAAYagAAAAECnGCLDjmqOTnJPQpp0/O/Gyny45XaTjBIm66LAgwNsQEfDCemZ8f2Ln/zoB2DpljQ==", "294ac804-25c7-4caa-8ff3-de657dbf2d56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a210cd8-405f-41a7-8299-49a92459729f", "AQAAAAIAAYagAAAAENtpcv9mYgA5J/F03ce8TGLTcZKvG3mjAKKo3SgOpeGqJmVPeBIh4C+8iri0UQyD/Q==", "052e471f-9c23-4db3-9056-8ffc7614f89d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dc8ab63-6a83-4979-91ec-84dd54e4fb35", "AQAAAAIAAYagAAAAEMGN9dAYfRMcMMdOuZuHomSZLEnIQYzGM5+YmT48sweYGq1xXOq79mGiHveluv5ORg==", "68496b97-12d5-41a4-9de3-d84e8f76745e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "461073f7-8c17-451a-877d-e839a9959c17", "AQAAAAIAAYagAAAAEPwvPoFhWHekHP6/fCsp7krQKhw6uEtSUh5CNYUAHF2feAFbu6FH8vkt0FaDixEaZg==", "83b7d5b0-cc81-461b-b2a1-82bd1c190948" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52f52b43-d579-4227-a481-9cb9728aa49b", "AQAAAAIAAYagAAAAELRwtBfAz+Jf/NpRsvNFE+juC+fmoE+ldFTfqs+RYgCseSob6nPil6NG4L7Qv15hnA==", "4d883186-d652-46d2-8928-c2eab971d7de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6956af2e-7940-4f46-aac7-7da24b7172ce", "AQAAAAIAAYagAAAAEOxwN9uDikqOCNIuFTISeYKnxhS8jYYukRahtharyY3IzwbRgE18kM+1PH6HDOl/7w==", "9bbe784f-c0ff-4555-8549-cc767aa0699e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8115e98d-7225-4602-a204-3bc0c61f3bd2", "AQAAAAIAAYagAAAAEI5hGaYwX+8LSwbBdBVcMyRJBBbVTFAxXhZBEsm1EQxDdSWfxJ6roEH66wrpt3kxgQ==", "d1b7deac-6de8-4621-a286-73c13c2fb8b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6979b9ca-8b7a-479e-b043-0b6ba7d9ceee", "AQAAAAIAAYagAAAAEOZpaRi7sjpLi0Nbc218Gdzyd+WbmbdTwdQY8iSj90JiCrWi3aGR64IJ2/IxykUwBg==", "4eff3dd2-17aa-4ac2-a698-371b88580710" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c678756-4cf0-47fc-8146-516a7549c3fa", "AQAAAAIAAYagAAAAEL2i5TdxHKUzng0uRv1/Bn8BK534bG2blLFbSqoUy8DkRweDzjEQqa1BgsQZjGgiZQ==", "ca8ff27a-6e36-459f-89d5-8e6a6c20e1a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ebf8212-9296-439d-8b62-a973ccc4c56a", "AQAAAAIAAYagAAAAENUO9SEbtOeoctDn9SwbJxZ4/iIrutDluy/MAoTtKZnJACbdX+3N1j7UEdoUC93gaA==", "bb3f2bbb-a34a-464f-b267-8e375096bc9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e42a2b68-f589-4525-860c-41b31f3fc1d0", "AQAAAAIAAYagAAAAEJyafsE29p7+kCw35gVlF3vlrv0HEp3p/YRzWJ4y00LnuLH81RNkwFgmjy+qfOjBZQ==", "74948f2a-e557-42de-8cc0-b69b9af6291f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28c8a3f6-4df5-44dc-bb8b-bdfcb76f4756", "AQAAAAIAAYagAAAAEEzARWQVMA7DWpRCPcLGahf4Yt6g8DrKZdJ/2GLebxvAP9ol6rbKe8A7T6F2A7RBEw==", "719a2017-059d-43e1-8e09-8a840c8c7fbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "113",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a838af0-131a-43c5-9711-56f482b04b41", "AQAAAAIAAYagAAAAEMTw6MUWZdoQRkSZnNGTT+9upA2u/mkCvU9br7vUCiK0IHtEzsHxQmKeEP6wq0TPow==", "ea365ebd-8347-491a-aece-26eeb8687096" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "114",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49101067-37fd-4edf-ad19-39f287f0514b", "AQAAAAIAAYagAAAAELxglwvyeyqSYI5UfWYMa1GibfnopBU3NSPyzse77bM3AK/2CqBM07E6a4Xfhp0pPA==", "9e7ceec5-f5a7-4aab-a981-d30e31ef51c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "115",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b12f067-0823-412d-937f-b25e1f77ed60", "AQAAAAIAAYagAAAAEL2+dDE9BIJgJ8P7yHTZsYmFvhMidnor558d+ndH0D94dcp8c8DvCR45NxAeztBkZw==", "eb9f3954-376c-4262-83a5-b97e81f465e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "116",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7afaebc1-0b84-4afc-945d-325b34595fed", "AQAAAAIAAYagAAAAEN5qL08Xlit/hoKL4Njy/tdGm1LYV8EN6NUHMOuqBnFN8EpQatkpB9WKWsBfZH0uTw==", "d84b5a70-52f3-4f34-b42c-42e50eb48be4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "117",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b45d97e7-c318-4784-89fb-64bca060de4c", "AQAAAAIAAYagAAAAEB63rp4sFuIrSpCzUPFMd3apowT5I6Dt80FoDlEGt/pCOTtWiXlBF3yRv7coSkYKlw==", "5b0c0d13-2c4b-4bd4-8823-f13db229c9a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89248bdf-d369-4a19-afec-ae4e0bfb1fee", "AQAAAAIAAYagAAAAEL31mHX8pWcmyyRTOnn+IirJTBOqzDo1QfpJZ5cpGp8erUUyyjeRhLxp4JO41qVmMQ==", "5b9e28cd-dd76-46bf-b1e0-f3debf6c424d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4818fcbb-35e5-49cc-aaef-b9705bcb0a48", "AQAAAAIAAYagAAAAEFjFlBfwYky5jCtovlOw1aJcxMwxfmjl0gqklNSGPrVnHGaJ54xJuHf8u4bsEpjPoA==", "f7027f3a-e955-4ba4-a260-591898c469b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef2dabf8-ec8d-4cdb-ba92-87c34eddbd17", "AQAAAAIAAYagAAAAEK9B7kzb2+eWbxH7WXJBoF9x63RVqRQdKjSqU4tjfReZHDudIfAgOr7KMTbt/QiFjg==", "60f8b336-ca99-4736-bb9b-f36784222958" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "121",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20bb6c92-501e-455b-a584-b7282418a7a0", "AQAAAAIAAYagAAAAED4hMvjQtjep4+AW5wBbJCsm9xKlQqe7Ux4AsZC5OEQto5X+zL8tDbmuENNY3JTVCA==", "29661da3-2089-4bd5-b7cc-46ca369824df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "388ced3e-9ebe-4c3f-8573-02341bfdbc99", "AQAAAAIAAYagAAAAENniK1Wk6Dc42tI5Dyol6jivQWnDch/IYImqSNg8ipBRFP8DgbcUzWWtojuYNaP8QA==", "bd95e1ca-6cf9-40cd-889b-6e6bfff055c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a74c25fd-46c1-4e94-84e4-97d0151b68aa", "AQAAAAIAAYagAAAAECJTECebZnH9GanJumiMpUo2vul+wTQfBmg1A+8JT5cuuc5+nBB9OXYUF44ncxEEjA==", "9f28ad37-d460-4a24-be3f-aedc5397f510" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "146b74ca-71bc-49b1-970f-783885a382f8", "AQAAAAIAAYagAAAAEM7CkmAqoU4H47sCwwFI2+AVnNiuteYO4CWkwmfazuwfCXKOAeRxNiqj3pvXBV9/SQ==", "e3438ae0-ce9a-479a-a6e2-ffc599e2b47f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "125",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b6f7991-7459-4c19-be1d-0123ed970051", "AQAAAAIAAYagAAAAEOzAmmvvmPXBYsteGq0mNjCzkAtGsdDg6QuabTjAA9nMhx+LqabhTe5z8J7ObFozcg==", "903d6250-361f-44cc-aa0e-e7e95642bab5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "126",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81d4f7a3-2d82-41b5-8618-db8b89969417", "AQAAAAIAAYagAAAAEK8sJUZZyGXJ/5dTB49O11yFXyMKfnNj4zsZfzuz5KzYUpcs4FCTK3qC2FXHxCjWZg==", "03b4a197-772c-45ab-af8c-cb0d6546435f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22101db8-35df-4ae0-91d9-bbb475423d55", "AQAAAAIAAYagAAAAEFNuoUh4uuELvV2e9wuyK/mt+LAX5LTe3Aig78KYZxSMCerZWVOx/0TeGs5zDlshHA==", "f12729f5-2341-426f-a980-dd865a1b9c96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "128",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cb86445-a4d7-4c35-8a67-8fc26ddd8193", "AQAAAAIAAYagAAAAEAF3+2FZZ9WvXpbvGvZTtoaud1/0TmjMToidBcqOcbYVqIIHuqP0FXrStW1Omd5qtw==", "b80f3437-4952-40ba-a31a-262e9c980311" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b6110e7-356b-4f7f-98a5-9ce5beec6e04", "AQAAAAIAAYagAAAAENrc1iz/sajXPb7Rzwy3otwQbGjK3DpQAlo07O+TJOnMAvx9nd+ezMJp4l4Ve0bZpQ==", "4dd886eb-3b28-4dcb-9757-61bb9b1ce2e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "130",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48ca8a7a-228d-46eb-b6bb-77cf64a7aa4a", "AQAAAAIAAYagAAAAEFYBhCtFzoJTdZwdMzArsoHG2KBDoNMLLUsME5j/knw/FZPX12lMoHMuVUBO00keQQ==", "6d18f132-f7be-427d-8014-2f5ada8aa33f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "004b2524-c10b-4086-a1f6-d4929d837a63", "AQAAAAIAAYagAAAAENp1bws5UfWzmaYCIoRbqAVJjRDe5k3zFvUSXCGy96Mrb9YYutXlaq8Fp6/qt4+S4A==", "8c3836d6-50f9-4041-9d84-792f77e74c60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "132",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad1b7f93-108a-4eb3-85b4-dc416a0805f1", "AQAAAAIAAYagAAAAEGC3Je69GSquY7miiT9uIQ3Ytn2o/VxxfquTOiRiQgt0w7i6HBJy+gDj8/Q8Io4kRQ==", "b3543d28-b81a-4700-805d-34683197547e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "133",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ceee9b4-1d42-4f1f-8041-d218b047b212", "AQAAAAIAAYagAAAAEHyjKAftNrCBy7QOo33Xa5eLNfiroJXuPgI8fS0yQUkmndRcrAf4TesKnRAlpvideQ==", "8d89a8a8-5f91-4215-acbd-6f4c3e8540f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32a110ee-9109-4ae9-84e8-f111c0f75fd0", "AQAAAAIAAYagAAAAEH2r+HIjdbnW7RLVKO0BNQRARSAVlGoIm9h5wgwzQkRGFH45MgVhvM2kfHpX8BG8XA==", "911b85b4-7899-495f-8221-d877739455e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "135",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09697d77-a368-4305-a386-59c4296339ae", "AQAAAAIAAYagAAAAED+Z6UAFTKXWMnxH2+MLv2bRpQCPDktqQjK+3NV3APFWadz+y4JneHLLh3SPsNlgfw==", "59f8fb77-6050-4e49-8851-b979270567b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "136",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77e32033-891b-4d21-8d9f-e59930d2dc31", "AQAAAAIAAYagAAAAENFubnml8nk3vnYZ8OvMpzG6LGb3A/BK04WDbWgRsUkHCustdUHbpS2xvVSaeLz9uw==", "269ef71f-edc3-42df-92fb-2aa85f86558d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "137",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b65bfcdc-84b9-49d8-9a4b-4c28f380092f", "AQAAAAIAAYagAAAAEEv6jYVMd4tJpyGDR/IIEKYj2hwR2wOq2GS73SoHR0fIdb2+yiEmGkS0LK8lCM7T1A==", "5ed40220-85d0-4c56-bfa3-bfc9bc8ddd20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "138",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a645495-ee28-4ea3-9dda-d1a62510a4bc", "AQAAAAIAAYagAAAAEHPYZUC8RjtGLxMvLW9g5EuaktCqb2H6cObvwPzHxTDa/iH0JWrNDCcMs2hYFhXo2A==", "01275fb5-3f4c-42c3-bd4f-733d4661b346" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "139",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1643973f-875e-4faa-b594-5d9b73d1936a", "AQAAAAIAAYagAAAAEDmoX9tCZKpEUOmar6D2Nv4gOfV00pqa0jue6jMISDKgPM3wbtIoSmE2Pza0zMeWlg==", "e1a8a32f-82e5-4d47-afe4-2d0416b7dc60" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 37, 554, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 37, 554, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 37, 554, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 37, 554, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 37, 554, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 37, 554, DateTimeKind.Utc).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 37, 554, DateTimeKind.Utc).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 37, 554, DateTimeKind.Utc).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 37, 554, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 37, 554, DateTimeKind.Utc).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 1,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8587), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8585), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8586), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 2,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8592), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8591), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8592), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 3,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8606), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8594), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8605), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 4,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8608), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8607), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8607), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 5,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8610), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8610), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 6,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8612), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8611), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8612), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 7,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8614), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8613), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8613), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 8,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8616), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8615), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8615), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 9,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8618), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8617), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8617), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 10,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8620), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8619), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8619), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 11,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8622), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8621), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8621), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 12,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8624), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8623), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8623), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 13,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8625), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8625), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8625), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 14,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8627), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8626), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8627), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 15,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8629), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8628), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8629), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 16,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8671), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8670), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8671), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 17,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8674), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8673), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8673), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 18,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8675), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8675), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8675), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 19,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8677), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8676), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8677), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 20,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8679), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8678), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8679), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 21,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8681), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8680), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8681), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 22,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8683), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8682), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8682), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 23,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8685), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8684), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8684), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 24,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8687), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8686), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8686), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 25,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8689), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8688), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8688), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 26,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8691), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8690), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8690), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 27,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8693), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8692), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8692), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 28,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8694), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8694), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8694), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8695) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 29,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8696), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8695), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8696), new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 8,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 9,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 10,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 13, 46, 39, 289, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.CreateIndex(
                name: "IX_BillDetail_BillId",
                table: "BillDetail",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetail_BillItemsID",
                table: "BillDetail",
                column: "BillItemsID");

            migrationBuilder.CreateIndex(
                name: "IX_BillTransactions_BillItemsId",
                table: "BillTransactions",
                column: "BillItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_BillTransactions_UserId",
                table: "BillTransactions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillPayment_Bills_BillId",
                table: "BillPayment",
                column: "BillId",
                principalTable: "Bills",
                principalColumn: "BillId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
