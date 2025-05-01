using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class ADFWRWERWER : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BillAssignModelBillAssignId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BillAssign",
                columns: table => new
                {
                    BillAssignId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BillName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IssuedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    PaidDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillAssign", x => x.BillAssignId);
                    table.ForeignKey(
                        name: "FK_BillAssign_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "6402c88f-6976-44a0-a277-6b99fab3786b", "AQAAAAIAAYagAAAAEBuksObrNs9Wvv60HRvIF277c5vVFwLtAMYDMmq9HRpBpZkaDas17nV9Tb5zjlIhmw==", "1340f653-8319-41d6-b7b1-63e6b056adda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "060e9c7a-eddb-408e-87b7-5e558f088dc2", "AQAAAAIAAYagAAAAEFGVF9Gt9nHopXcc5DJGteIEb+FH7pvDbu2VglRqGpxXKrTfIebLxE3+R7yV4/LqxQ==", "6a9a4b1d-3a1f-4298-aede-5976279673c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "f34ab57d-7018-4ecc-b21a-c1c410c1c5fe", "AQAAAAIAAYagAAAAEEn1VPp18SHnAI7p860BxxsQCPWcwtM49pKQbw7ZVU3ZYVx+p6ZxpoRbuxbuFcqGpQ==", "0bbf7c96-66f7-4e47-bd69-2e1aebe1f6c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "0b606c88-11a9-45ab-b902-70a1d8a83563", "AQAAAAIAAYagAAAAEGy39OcZZ1cKo2ijkj1YyleXuLgFaOaNwV5V4edjA6X3CWBaLLYoXUne0hOCoyi9NA==", "b5879c07-fee6-48bf-bccf-af4e50d7f3f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "36a8c0a1-a230-4928-9146-e634d7d3d72d", "AQAAAAIAAYagAAAAEHAvp82Cz88ebvm7eHX7T8NKwMEeyKmGgUNqS4cOeTctNo8oooaNBuVAp0OsLl1xng==", "b1a9835b-df2f-40dd-8176-ecfbb3219e2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "6acbced5-e394-4d33-948a-d366543d8518", "AQAAAAIAAYagAAAAEMdbqpqnxBaZ7BYhtry6ssHDFFGRUKxL0yZgSOOQc3NRW9R3GcGihfmiclz3xO716g==", "a57ba433-c57c-4c85-9f70-dd896c483a36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "b86021b1-1fb3-4b88-a85c-eabf85066774", "AQAAAAIAAYagAAAAEAPUuiqCobZohGFkUvBv1SR2VHdNArHYiZ5viEfVl2OxOpgVh8MVmXZ+IBHf8kDE/A==", "0792187c-0d2d-42e6-907f-38c37fda875f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "0f6ca456-ff79-49c2-96ca-10fac751080e", "AQAAAAIAAYagAAAAEGIrxZiF+xLPuYy3SRpKHYY3yeWKP5J2ItbSre4FYD0NwqJF7X0X2MHyrf9wzR3reA==", "9bee13d9-e8bb-46a5-9ff9-5bdc23eaa9a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "67edf8b6-ba1b-4198-965d-e0612782dc9a", "AQAAAAIAAYagAAAAEJNIZAtllESiMwYzy3855evoTcQG9lzvImSDzvD81uqRcGTT2y3FF+SVfLjPx5+dgw==", "4cae2c3e-d32a-44e6-8dcd-198a19c093b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "cf110349-33e1-40ea-8e91-40875cfe4f91", "AQAAAAIAAYagAAAAELMLzmRYqaGnoZ7mBFDKVpzrgBOyHhx4wzrH9ahHQFy4b+p25/ehUOnSUHntqU1tpA==", "68669bbe-cdab-44fa-beb9-378c734eeef9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "2eac87bc-cae9-4bb7-91f7-5735d5c3a4ae", "AQAAAAIAAYagAAAAECh7Xj0/Gga6Lq0lcEIUy0P3utdvoaLx8q5PorNXwH5uPnJ7XGaCzJ/1W/+SE6S+iA==", "27f58344-1f09-4a02-942d-a4aa84db9d2a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "4b27134d-daf9-40e1-8d77-872d1c41b12e", "AQAAAAIAAYagAAAAEHyatggnxQiGUuYABqXTvovthIf8G7YmSHlx7MSlaA106ncTaQvORIf4YSZNilQwqg==", "0ecd2041-dd3b-4cb5-b3cd-2b9d73471188" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "113",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "0d1fbbb8-7cbd-4877-9676-86bdfeb9eae9", "AQAAAAIAAYagAAAAEPzBjOtED4wMxiHDzqvwNzAKEtFOL1qgxZ1o9gsPfFZ6bw+ilERrJnrYJARmUDZKBQ==", "45f58ffd-09b6-4961-a996-db9dad770b9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "114",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "61b97a76-e1a8-45bd-82a4-04e04f1ccf9d", "AQAAAAIAAYagAAAAEEjVz2VgcRWlsEOAhWLhLjzKjIcslrUoKW6KtDCQ7RUr6XnuuDMtIVZAPlO/n5MkKw==", "bd79e73a-7182-4739-9d02-872b4e6ed013" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "115",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "b0cc08d3-85d6-44f6-b37d-b7bfa459a2d9", "AQAAAAIAAYagAAAAEJdBN0THBY7EOeb6nmmLJoFl8CPCXObSXNGO/kpdFFu91fwOWR1Th7Fsvu6ztmBoxw==", "e1ea2f9e-ceb1-4ce3-9e69-6afa8e0653d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "116",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "a18eadf9-9043-44b6-a4ce-6d23efd95ba9", "AQAAAAIAAYagAAAAEK6dwtJ4RU2dGPr/fNXoV+h3NpN3y9w08/QEOxSztowq7eX8Pe6EWZAnHlkiTf22vQ==", "219072e9-c8be-4c92-a206-39a31c0cb5e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "117",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "9700a439-a9a0-4625-ad1e-a49ceb4bd91b", "AQAAAAIAAYagAAAAEDFppVfgONzgRinXZY7eD+smCD5XB39cpwdG8t1Etqoj/vqcSwL8fO30sh+NNjsOEw==", "3735ad1c-fec0-48ce-a488-5c2c29a517da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "8b70c22d-1c2b-42de-b526-6727cff285cb", "AQAAAAIAAYagAAAAEGsJZPWCfJ7Y32iMF1vkeji5nKJWhk8HyM0xMTZELwRhmnU2YyUZozwLVyY8nsvswQ==", "1d2644d6-e709-4289-8e0c-2b6e502a923b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "7ebe9e09-9e2c-4fbe-abc2-64e83cb16e40", "AQAAAAIAAYagAAAAEPa0/Ky4pLDME9GPVe/DYnTwmPSRnqGMCUnPjTg0LRf4xVvk6e3ZRRVahZVcsx32sQ==", "6ee64b38-4d63-4032-8b95-d55d040ab21e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "42313b55-8a5c-4883-aed5-d3babb82e30c", "AQAAAAIAAYagAAAAEO7oMusWKA8m/auuItwTq8K/ZLgKrwKPCugvbT1CwugC7RLo3kskYVj4l9hvKR7iBQ==", "c759eae9-1bd1-46a8-8a2e-7fc8add0e5d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "121",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "6a9c8d71-b9e2-4ea2-bde6-4a02fb9fdf99", "AQAAAAIAAYagAAAAEDz5682hyUefh8Sf23ewljw6jOGRR4tGbsz6hah8Ha+XkXaQtwD04+o9aX/I4UJgfQ==", "094a8ce7-8924-4e14-a90f-fd9d6b331ab7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "122",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "797e9ed4-7d76-4c2b-8bc4-1feb149771b0", "AQAAAAIAAYagAAAAEFtP2c7J0sTrltIqNQw/62mFuHi12Vj2casQctFcVxjXV78fJTRBiIU6Itwh4uTzGw==", "2e23dd1d-bb3c-4aaf-81aa-06ecf1124283" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "a759d962-c0c3-40ad-8435-b5767a25088b", "AQAAAAIAAYagAAAAEMHUIR0I5LLLf4ezqKM3yXw1kw6/40LdtscrcFRmKJLHIUourAtN1xVIDku/7HII8w==", "fe69e5a9-4688-4fdf-b153-8a2e696ad454" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "124",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "6705e141-beb0-4c34-9d05-017259b4634d", "AQAAAAIAAYagAAAAEN2/B0iPZ+FV8vbN4O5E45/qwqNHvjvxtVVEPUWERA53rwC887gYYTQJmsSN1QBqXw==", "3891bb44-6976-47c4-9e09-319363f73e04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "125",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "74a5b36a-4d04-4d65-a121-722238a51339", "AQAAAAIAAYagAAAAECY5OtbdeYCae9po/yvHqK1my/o0ROunY+ulpzvSZUVZ/fmuAxfodumuSBuTJkf0dQ==", "e6c3f253-69fe-407d-9fbe-b8c8c6a3974e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "126",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "423a4363-0b3f-428c-bc03-fa7b6095df05", "AQAAAAIAAYagAAAAECpgQpuA51t2duL8aV5hfNDIlp4EgxGsMSC0ioo0x3AidzMX4hGd/MYxqqmwrMVpCQ==", "65eb5694-acdc-4571-94e5-18ec845a45a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "127",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "a3c978e0-d8c6-4203-9e41-13d4733fc98f", "AQAAAAIAAYagAAAAEH2AmCt9YphPJAhd3iYBKvOFGD0ZaC6LOaVbIip0dqdrt8p8qLCxLXG78p8LQJE4ew==", "3dee0a2d-edeb-4f88-ac4d-6b1fd6d83c49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "128",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "765f7ed7-7d90-4492-a72d-a9fc9db5182c", "AQAAAAIAAYagAAAAEP2PQNZm9TeuTajScoizGlY4x+Pk66RgGoGJrvWIMzs65IeDBAJ6dM8+2v+fR8yw6g==", "f0e4cb08-80ad-46de-b440-e8ad7faeb749" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "129",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "9c9d2275-8a4b-404d-87db-67fcee529795", "AQAAAAIAAYagAAAAEF84a5Uhh3b62OtF7QuMFTc+yEtKkMehAop7qFJHJM+2u55/b+b5D5CJ7I4R95uH/A==", "fc9f8829-7493-4f6f-b805-2eb93e21de37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "130",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "36177973-071e-4ade-9932-5b355ad24fee", "AQAAAAIAAYagAAAAEDbGFPMGskokOCNwGvcfjMgjw/YLYEwKbmgE42YLXrGqWjlLFCFA3AYq975hW2I6EQ==", "7c211f86-a640-48ff-86b4-b5471b8f9e9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "131",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "c04a1612-f6b8-44e3-b259-9e71e128d1ee", "AQAAAAIAAYagAAAAEJC21nLb1m9xIvjmrIh/i25XdcYoUV5G+GZEqEzAzktRmFSUCmcBsgmrvKilIqkgRQ==", "96f7360b-1be9-485c-9622-e0effe29f0e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "132",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "f5bf05b5-e966-4e8c-82de-55e650deca53", "AQAAAAIAAYagAAAAEFsNwiTgWPxG64qX39T8uwPSfCADMKo8JXFmjk6B/AVk2ta+qXQBqim+iVUYzGk10Q==", "d8eee299-aa83-427b-8ecf-f453ea71c1a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "133",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "eb6ba597-5b73-4701-854d-7d4f563f8c3b", "AQAAAAIAAYagAAAAENH5Uozl9Wd9/zEgcLjC57Ovkb1zUficup//LWdtGMbb3d1cCPVCCtgDfXTLAIYnmA==", "91879f2d-d15f-40dd-963b-fc797ffc6d73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "65b5c0a3-8f5a-4544-86dd-9c95ab34d20f", "AQAAAAIAAYagAAAAEE+/qw65DkX5MtxpgBDP9r6Qxfrbx6QOQd+fKKoMBnA9B7a9rTYGewGFSJ1C1Y1t4w==", "0366ef9d-5676-4135-b624-ce79938d5098" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "135",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "3004970a-bd26-43a3-beda-34002cc37ad8", "AQAAAAIAAYagAAAAEMEldomNc84JTalsiRif7H6BI5ejz3vGRcCpRVCT02Ej3JzrQUcZLVJHNXGqoM02bA==", "a079826e-1196-49e2-88dd-7b8054d5d5bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "136",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "10e0096c-6c6d-4b3f-b1c0-a72785d9b45d", "AQAAAAIAAYagAAAAEMa98LJdIS05hcoOFDWsur++IAO1/sl4bNfYAYvfXq1l7UpVORXpWx+bZ+16nXzqZQ==", "b3c80965-af23-4aa3-a2b7-8156cafa060d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "137",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "7e42189a-80d1-4a61-be6e-e56deff6f07e", "AQAAAAIAAYagAAAAELNUPbY5IqYpMD8mLww4tfN4gEE3e8jyOPVLJY7Qv8LFcP1XEMar9+bEVBhvFaKmEA==", "a1328c1b-1fc6-4872-a624-19e211fda161" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "138",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "951778c6-d1ff-4ffb-98df-38d9b2dbd532", "AQAAAAIAAYagAAAAEEQbaAXj2gjy352PK21mZM2tI8ouMMrPm7aT0wsClLfL7OFoeaQ6jtMp877Vul00OA==", "33d0f66a-cbd9-4420-b42c-740f52a73a32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "139",
                columns: new[] { "BillAssignModelBillAssignId", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "f2a54ea3-d890-4fba-95d2-3e8f58646ac6", "AQAAAAIAAYagAAAAEJtAGChkEH05yPMtROA+Rdx09FK5LRHil59nhV85HXkK0rO3dYU8H5fmw3wEuWGrLQ==", "bd602930-2701-4601-8c4f-d2153a45add7" });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BillAssignModelBillAssignId",
                table: "AspNetUsers",
                column: "BillAssignModelBillAssignId");

            migrationBuilder.CreateIndex(
                name: "IX_BillAssign_UserId",
                table: "BillAssign",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BillAssign_BillAssignModelBillAssignId",
                table: "AspNetUsers",
                column: "BillAssignModelBillAssignId",
                principalTable: "BillAssign",
                principalColumn: "BillAssignId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BillAssign_BillAssignModelBillAssignId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BillAssign");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_BillAssignModelBillAssignId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BillAssignModelBillAssignId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23267c0b-b662-4241-a361-2bcc4969d2fd", "AQAAAAIAAYagAAAAEDZH6WyiOcwAF+aq4rvW5to6GxesI29auPd4U4Zu0azodIWWsjY/MDvhhs1bxkzVgw==", "f44b6050-bca5-41fc-bd23-78828e053425" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acbd6200-d047-4d90-aa29-5401c639264a", "AQAAAAIAAYagAAAAEAEaSY1xT2N+5YUP9BLLcSeZ/uTdKgyAAEj/VfToz/FLUzQjVZYirjdcMMxlQPA33Q==", "15e529e0-576a-437d-903e-3bda7ab37632" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c365020c-c402-456c-92a4-0b1bb2dbf3fc", "AQAAAAIAAYagAAAAECYbiF6rnup6Ha9cHgvNJYl5zPSfZ7HGiSXu0HAGMJ6Sse4MTPwqtlQ+VSe4L6Wemg==", "79dcd267-4dbd-4766-a9a1-c3ce3a47a32a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f13ace82-c339-4b6d-ac1f-50ea221a4758", "AQAAAAIAAYagAAAAEJmw/01jmolBUXPiEMYDIVS5vkQs7rkIporGfYBpA9ri5FcIqHup4QZm4Saie0HWIA==", "8571314d-651d-411e-83dd-71366401c3c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5679042-ddba-4790-ad6c-9793dbfc039c", "AQAAAAIAAYagAAAAELLV9tGPnM2zi6JdOnryNJIxW4zd1z7PUCXsC0UUtk+7f9ymnJkcmEIBxD55SmPfeQ==", "aead7e1b-52f8-4391-96db-6071f3666e26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5484776f-d8db-40f1-8cea-144c32c30dab", "AQAAAAIAAYagAAAAEH8PVRL1p0GzY760fbaY0+WDB6fZ3oovUvxZ0nEHJ2TD1CvLWRHqzmWy1xXH0XuIFw==", "505d79f6-7f61-4775-b54f-a74a7b360fbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c29e55d7-918e-4c16-b141-4b975fbdc99d", "AQAAAAIAAYagAAAAEHM2qecYUeui/MiWtaRQvnX5cyt9yXEzQTgAnLxMIuCxQFfH6xlHSYkWN6S7k1QGOw==", "b17e7127-4cc4-4fba-80b9-0473dd8b60e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81682084-9028-4ea9-a4a5-33ee3abe8e82", "AQAAAAIAAYagAAAAEEYgxZCgJ4bnlhEdvuZRLoKK/oS11L0dfLw5L11mUDT0RhFhdoBRwsssjl7FC/QhAw==", "8fcb8547-9856-451e-8e39-5e9edb8933d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b072b27-e533-4d4e-bc07-b1743ace248b", "AQAAAAIAAYagAAAAEJoahLn0egvaeslnGNi91a7yL3/igT8YvvTb8C5ybSNBd5AU5virbAtJTT1aMJ9UMQ==", "c1cf5a6b-2f35-47d3-99c7-0e05bcdca6e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06752849-4da9-4a33-b553-5ccf5f367957", "AQAAAAIAAYagAAAAEPIYy9vzaOCE7ATWU7Flk8WhaP/pTVMOMtEwLPdjz22/VkeN7BV6Ap2Msl4PaCqrAQ==", "381f0da4-0756-4a84-bb84-c84612890af4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcc879c9-bcc4-4e13-aee8-d0b1f570dbd4", "AQAAAAIAAYagAAAAEF2EmN0qxpfyyk9A/xtE3vtEY0shYqCMgdXq80f7kLAlSKyruL0tICA6Go9SJcB2pQ==", "ca4a4a71-1563-43a5-a94c-7aa1ef9a19e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38b42359-9a8e-49fe-83e4-46e217f6e8ed", "AQAAAAIAAYagAAAAEH1LFKQop14ImBONxCLCVy+FjBVyRKVvRQ7hxp+Dph1mQFLcvQPbwRvvC9AwtU5RSg==", "8c5a2be6-fba1-4c2a-aa5e-c78622b5c84f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "113",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2738f9d-6e73-4edd-b7c3-3d7cf2a372cc", "AQAAAAIAAYagAAAAEHcWZRqnv7D1IImSPyrhFXgP+0q/U5q4MMjYDeyLJOLBqLSvKQ4Qio5d8V50rdAmhg==", "27a3cbc8-c6e5-48f1-87a6-3c1a3b6d38cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "114",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "465917f8-c43f-4124-93d7-ab21730b299e", "AQAAAAIAAYagAAAAEGFDTwJ+HJpVWZzYDtGD4Y4TXku3YISF20A31fR0yk+wvxjgIDKFw0rUnJ3i4FvN2A==", "2079c858-efe9-4816-a37c-dfe7f3a5641d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "115",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c21f02b-e603-48fd-be55-f31ae11288cf", "AQAAAAIAAYagAAAAEByWug1QIGl8Wu/ns5fgN7C86TIwvTQJ9YGcFhBKWtSi4aQBrKeR5eHHt1cVx3rrHQ==", "8f6b4af6-ab15-4d34-816d-7f5674339629" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "116",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "436e0873-a8e2-4301-9cdb-a778133c96da", "AQAAAAIAAYagAAAAEPpIRvXECR0y1zMhcV60VnIfJOGQ9YiNMtDLLEpNVTveCVzghlKzum2Ve5E2vTNRkA==", "cb9290d9-aaf9-4339-a7f0-911f1ec74afd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "117",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad03d6e9-43d4-4608-82d0-62cc9d0ef8bc", "AQAAAAIAAYagAAAAEDwGhahJg1qIWfbyV/4pjpM2TcaxX3ZocQ8FnXkkbHh6HhH+rEMJSAMy5tYXKPkBQw==", "0f5463c4-3af6-4a07-9c99-ac771ce305ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "052c4265-2fd7-4603-97b7-e6dd9c5b6bbd", "AQAAAAIAAYagAAAAEPWqMoxdtdBZL0GOi2Yn2pcjQQXHYhfmPdonjOWdBtqpHlOHDh8WUHek4GW8G01voQ==", "9f978b0e-dca7-4696-a6fa-6d4864ce28f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bff29fb9-8546-4db5-ab82-61edbaaf6628", "AQAAAAIAAYagAAAAEKC+JMktQL5zMEShZ7yPN1tGttMr5QZqIoq8ixy2f4vqjNX9/Y/m/YHKltmXZrEb3g==", "952bb1f3-b5bb-47fa-95c3-7303ef089c87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59b7eb55-cb9b-4f98-b012-37f4ce263199", "AQAAAAIAAYagAAAAEG7I1bJlD6xAUJZJwFfPWOie9GmvLYXNEJ3xEDD7z7Wsr16725fA7kiGwtMtfMyn1A==", "65947c44-14d7-4ce6-9d86-4f89e739a28e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "121",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8eba6e88-6380-4bb5-ac26-f026291d16fa", "AQAAAAIAAYagAAAAELQ9/xvwQMprrzn2R6Ksv5Ow5tgweOW0ZjrG315Q4EZaxQpBVtbKAXx2Xci7esqhxg==", "45a6e80c-7066-4062-ba63-1d8fa1f501e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ede01cd2-20a6-4925-aa93-58a7c2715480", "AQAAAAIAAYagAAAAEIrBDkPm7O3hNEOd6Ptv+GtUx2w3N9MA4/j8bQcg3AdytdupK9Js/SUh46JMD+cpjQ==", "e1c1e350-9bdb-4214-8439-26cae0808fc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "336a9c8f-f326-4f96-b548-88e6d3c1415b", "AQAAAAIAAYagAAAAEG51giCfQ3w8ULbZKwLPI7CXXcrQDQQrFNFn0gK5CcyoNBzHfNQdwn038gQvP5W08Q==", "8d2678b7-51be-4ff2-a32c-f1ca3f4ac07c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11c31350-269a-4a41-b221-2db413497d01", "AQAAAAIAAYagAAAAEF3ghJDcNpvysnGBIA1V5RagtveFGjrclgOgiasCwKzwYmeZxyVa+YzKSnaIiWB6kA==", "e02f440a-f1f9-45f1-ba72-6fae8de5582b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "125",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe304d0c-2f96-4593-a13e-8a8f1fa8e9c1", "AQAAAAIAAYagAAAAEPhgnLaeb0trNgB03Sr0i/9OKvCZkjkyYWBiQEYUQZLdwFQGJLVjMKxHcec1VrCRAA==", "09450ea3-0d2b-4666-b03f-3cbbfa657685" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "126",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce6e54da-70fe-42d7-b10f-b6c82cf2a2ed", "AQAAAAIAAYagAAAAECnzwbVabsNnh9GMyjBhOX7jSPtlDqftpxEtJYb28q2l9ilcP3Ghg078ndIaxmWN/A==", "ca343f7e-6c48-47b9-93f7-dbb0c5f63e40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c1c7a40-2359-45cf-b3ee-d5c399e4ebc0", "AQAAAAIAAYagAAAAENlGP2CrtBXx9GBT3ux8JcYRaZBhlDfOd+qDblwt1iV961XGtmK8z5CnMoZG6WUEXA==", "944e7aca-e614-443d-9701-2b3623feb9c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "128",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5691797a-a137-4c2c-b268-db11b6fed669", "AQAAAAIAAYagAAAAEJzZ1T21rqxzRUqiDL6MCHNOpK+6fEJPYOmATIhGg8aZHmSgNQG3yLTeVLnA/rdYow==", "ba60b45c-3a81-4a31-a88b-6c474b47b02b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15dae6fe-99e5-4c8a-9cce-65a9d3055119", "AQAAAAIAAYagAAAAEIqyQ4XyFb36fr0Se9NkFRfhWJ8T7/WfNfta0Dp/E9YcUgDUbmFupw0WybQSq8RMnA==", "6e9b6a9e-142e-4991-beb6-b0d7201f7be2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "130",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "266461b8-00c4-4ebf-894f-9b232752e956", "AQAAAAIAAYagAAAAEAcQeJjM1FpGuB/yA9nDiZNdiL/96YhmJa5s2xB5eXJDe/X4F9NdGMF3f0ibS+A/Sw==", "19b7c25a-49e8-40f2-a3bf-f2205148af29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae0c2d0d-a032-417b-8e53-0d80451d9dd1", "AQAAAAIAAYagAAAAEFGdKlbSFsXHXNHDvl8z80yN7rty8XvPxi+htAaPieY4HOOwaAHmZa5tC3XyotRTgw==", "72a9ee5e-e80a-47b2-9f8a-bab1b59b0392" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "132",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "444a1a36-13c9-4a48-826f-5f0493058b13", "AQAAAAIAAYagAAAAEPu0VcOrs09A4KGSzpCoP4bESpR/DV3uwIMK4T4Yvq8MuHPDMUvyIwA6EtjVJBaWNw==", "eb04d10d-75d4-430c-9236-21db856341c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "133",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd4106c3-c7cd-4786-98ae-ec7d6cb02901", "AQAAAAIAAYagAAAAEMxcgM+FbMMmLTGz6pJ5eJmJqfJcHOlMlzbvEZbQ6encQi1Zq7ntHKDmfl5x4Pkg/g==", "5fdfa107-ec80-4e7d-adbb-9e0240c872b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d313e5bb-ebc3-407f-9ad6-f0f3555a8e36", "AQAAAAIAAYagAAAAEGA6UV05PEXfeFKkpmTpnqSg4nLSBd/pZYYt104fQQWMAGA0WMz1nIJgnVqgKsWptA==", "21d5757d-cb2e-4cac-b25c-b65ac532433d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "135",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6db9002f-1f47-4bee-a52f-5cf6f7f3e178", "AQAAAAIAAYagAAAAEO3SngVXqweOYY9uKZA2Xh7gMah8xrDkaUQcTYnYWufRnWA8uxKAdhV0f7OBJsAdpg==", "94091b04-e7b7-4d75-a299-cb02106638a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "136",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b289771-0077-4a34-8697-cf484125a015", "AQAAAAIAAYagAAAAEOiBuYRNjmALqwgAzu+ZVJ8r3m8rGdnRf1jz7/8Gh6F32pPf9l8fuWPOyz5acQrOMQ==", "d835e7b6-7553-499f-a0fe-201a6eedb418" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "137",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96f243da-e41c-4037-b391-bf8a67180dd2", "AQAAAAIAAYagAAAAEJrj9HFQABBVNpQe4G2ZaeUtbyGL4amEBULZ4UC4CkHg/heMXToOFFoOBAcHbf3svw==", "44a21658-354e-4f0e-95d0-fff3717ef9f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "138",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b95808ea-a464-49a3-bba2-2f83b5b26701", "AQAAAAIAAYagAAAAEL9u4y455/0bHx8B6/yx/DMbmXrOauD7Uk2IK1p3rbaafcYN+Qp3kluxUyYP3lhiGQ==", "2a73aeb2-248d-419e-b503-96219eee3c0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "139",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48679725-7765-4960-8132-98d1f379856f", "AQAAAAIAAYagAAAAEGb91m6v7AOTsov+DrKvb+kyZ8RA8zAwaw/+xDOnFRnItlVC3UlhYiWBwUDoOaUciw==", "be6c4bb6-2af2-4be7-a614-fa93ca47ef12" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 32, 693, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 32, 693, DateTimeKind.Utc).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 32, 693, DateTimeKind.Utc).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 32, 693, DateTimeKind.Utc).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 32, 693, DateTimeKind.Utc).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 32, 693, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 32, 693, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 32, 693, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 32, 693, DateTimeKind.Utc).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 32, 693, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 1,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5234), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5232), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5233), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 2,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5240), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5239), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5239), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 3,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5244), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5242), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5243), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 4,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5248), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5246), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5247), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 5,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5251), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5250), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5250), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 6,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5256), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5254), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5255), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 7,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5259), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5258), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5258), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 8,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5263), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5261), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5262), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 9,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5266), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5265), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5265), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 10,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5270), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5269), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5269), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 11,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5274), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5272), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5273), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 12,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5278), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5276), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5277), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 13,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5281), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5279), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5280), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 14,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5284), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5283), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5284), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 15,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5288), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5286), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5287), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 16,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5291), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5290), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5290), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 17,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5295), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5293), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5294), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 18,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5298), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5297), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5298), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 19,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5302), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5300), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5301), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 20,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5306), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5304), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5305), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 21,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5309), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5307), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5308), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 22,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5313), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5311), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5312), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 23,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5316), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5314), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5315), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 24,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5320), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5318), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5319), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 25,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5323), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5321), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5322), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 26,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5327), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5325), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5326), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 27,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5405), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5403), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5404), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 28,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5409), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5407), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5408), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 29,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5412), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5411), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5411), new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 8,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 9,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 10,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 19, 11, 13, 36, 374, DateTimeKind.Utc).AddTicks(5148));
        }
    }
}
