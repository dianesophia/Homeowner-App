using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class AWEREWRWER : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillAccounts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4e415ed-4f5f-4efc-844e-15f6da2ade76", "AQAAAAIAAYagAAAAEP5BEWr/n2rQVsZhYqE9q0gg1V88ERJ6I3FdtqgBv4BI6FWO7UO2847zgKghD+ssnQ==", "b37200a3-e440-43c7-a4c3-222c653ee0af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c57a732f-e99d-408f-b907-2269dc4ca73b", "AQAAAAIAAYagAAAAEDlxf4poSrvQumb3pi1z4+qmxU4+6g99M4pjlzILvZe3ifxPxWuXTxcGM76YiwCdAw==", "6e8c68cb-d923-4300-a314-1a25fe0f459d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb25b5f0-6acc-4de6-b4fa-43c9ba887981", "AQAAAAIAAYagAAAAEPD1R+ZDRdjIH05I3W7yCbE+pAimm5lZyulCfSVKmm2ZU/mp9PHKeTM82tA1KuoS2Q==", "49ea09da-a1a8-4d83-ad82-03c8008345e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da7a088d-719b-494d-b1c0-022bc595535d", "AQAAAAIAAYagAAAAEMqfp86kXPm667tZt5bCCDY1MNZRJ1Y0U74zYXlFfzmsGsXe0Ya0W3p5UvSJYGYMqw==", "3a8e0cba-2a26-4aac-a10b-41ea19954f1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9ebfb46-e00a-4f40-bfe7-639c07891e7d", "AQAAAAIAAYagAAAAEONJd6ok/wfVLKv5Oqu+JlCjy3ScjBK0r5RC+8xPwqxv/PONqIampvPtg8N6OMmU0w==", "1dbbf4c1-3b0b-4a64-87dd-018349f940df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "917a8d0a-8950-4444-a823-d72a7cccf29e", "AQAAAAIAAYagAAAAEABefsUAJHmmPAPrABSqf1aNjxtdT75dT5K0zQuz2ewEFkg7opUKzN6Q4FkkvOP8gg==", "e51a9907-cb04-47ec-9695-f1a961c08590" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92629a36-2f85-435d-a902-42fdbc2dd162", "AQAAAAIAAYagAAAAEMIDR3RimlkuEkhcbyApz1vLcy+BXr6xou8jGbjGeMHNk2rbsOQqfWsn5L/vOJW4AA==", "337be619-b822-4832-af14-2fb134ad464e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2960d83-df61-48f5-8584-76aefbcb5610", "AQAAAAIAAYagAAAAEIedpUb3CgjddZRbm7YvP+TpdVGwVkSVLZ1qgCiCmWZUDvzhGCaxezUpQ3MI9R1G0g==", "45b32931-1dc2-42e5-aed1-76da0349a8c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6df8cee7-fdd3-41a7-a4b0-27adc1b971fa", "AQAAAAIAAYagAAAAEDIU7/euQJGRMwFNWKEeosffilpXMCj9OvMezH6LnCZ0OzPRxs9FSeqntjSBDK+53A==", "d2a989d9-96ef-429f-b7e3-3d9ec3af2305" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13e21eed-62f4-4776-947a-d23d7eedef3e", "AQAAAAIAAYagAAAAEI0XGwHFt4shcTI/uqdH/EsPaNuCeivHhFy0tvTeb/3GNQPejSYjfv495r8tOOjhUw==", "4c4ee337-833d-40a1-a0c5-9ddf1042e2b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10cb5836-c0ec-4d5b-a0c4-36bb138f4baa", "AQAAAAIAAYagAAAAENBN1TCtV2iJ5hnMdCRh+lBam9hf+XSSFPMb2PJ/dCMtB5q8bz0TSHH75Rtex0jPwg==", "1803f1f6-5cd9-44a2-a094-29529cc5b46c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b2229ec-2f9f-4cba-ad28-bb79294ca071", "AQAAAAIAAYagAAAAEOY8sCDdsWjsTf7J5WgvOAj6mdCeczL5LvQDLFImVn4/b9IFstGXIKP+A+SK7UP1Ew==", "66d0c385-dc54-4063-a2ba-c059547f07c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "113",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e877023e-db1b-4322-9d70-d585c8358c1b", "AQAAAAIAAYagAAAAEK7h5l0+uiiKzjb6orMw+kUO663Jg9Ny4X8cnAZc1IetbfUl38F2jDp5g4gLRTcVnQ==", "5458429a-cfe1-477e-bfbb-be637c24b7ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "114",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9db390b-d0f7-4be8-a771-22b519e150d6", "AQAAAAIAAYagAAAAEN24JI478wnxZpBSJ++cj2rT7wb67Vu4jjCcz9ITZCmyaLdAcs3ykotao42QgTqySA==", "89546bbf-0736-4158-836a-57028035e8a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "115",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f88ead40-fb34-4898-8ad3-8e3fee6aa42c", "AQAAAAIAAYagAAAAEPRg4YrFddLCh5W40Nj+et5ud8dBG4/Z7RDTD5poe2+O6hT6ub1conxPHpPlyjsv/Q==", "fbea81b7-8631-4810-a87a-977dddc14f54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "116",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5582bde-83c7-49dd-8b33-2c08d524e2c9", "AQAAAAIAAYagAAAAEPFo9ryZ91NhBZwCkXu0iBKKHEVKhg5N66CJR+JtrohIrj6WulMrRvbYehM2jj0JIQ==", "03dfa3f6-7550-447f-ba07-e1e2d1e75215" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "117",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f252c146-7e70-4e3c-bf71-4376664ffabf", "AQAAAAIAAYagAAAAEIQZJ3ITX3ytpOvLlSafd133ELr39i/LFBkqfwzu8jIujO4emS3kjqILh2oHTUquaA==", "ca0838c5-b222-4115-bbdb-259694b30b8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3baddb2f-a867-498a-b2d0-c6a6a23ee03d", "AQAAAAIAAYagAAAAEHmQiE0nlD6S7RSiHYmK8kZ3j1nCJPHbY/YkRuBVaqtw+Jpw20vAlzQHcxtvPd3bXw==", "990b0802-ccf9-4154-a58c-2b2290f6b042" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29dcdac3-9994-4052-9b51-24b625185165", "AQAAAAIAAYagAAAAEHieDe5cNN0ld2ZSsNk6quF2qKhxq1EwovMFU5iGiW3kvKXfVnSOI3v6ILtToRif/Q==", "d02362e4-2c1f-4a7e-9228-cfa6f79af5d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "076735ec-3324-4797-8a50-d6033e268557", "AQAAAAIAAYagAAAAEOGY/kQm2MjXUQ1QZ66eFdk5p9wIuOIoBb6N6y1+sJ9rAGImjIjlPezMISlBdenBew==", "136963bb-8ea0-4f33-8c19-e383a6871c9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "121",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d318f89-dbf2-411c-b2d8-9197c9565fd3", "AQAAAAIAAYagAAAAEN92RPh/BK2/ofUD8hXBkPvBCTpJAEUX9knTsEErZUy4HQZbVxmtjkXTQM7ZoIqHYQ==", "24f234da-16b2-4db6-b889-a71f384a0dfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1d97281-374a-463f-8a20-b9258c627b2e", "AQAAAAIAAYagAAAAEAzSBL9SfL5NA3S+XLlsvCgCYR6405z5NVRBNbN3PTVEvLMbs/GW6EJOKfigBKrEBA==", "8c752f07-760f-499c-82c1-c8d24dafb56c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed00a5b4-2990-4437-a1ce-6daac546d989", "AQAAAAIAAYagAAAAEP/8Mg71hvulTizWD1jqkmfvrwiQMyi5JpJFUfMXyYMxYmHMsEicFGnvcE9TbLMwGw==", "faf6953b-3651-4971-b7c0-3d3eb028efc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a28a99c-10b5-468a-899e-db58348686d3", "AQAAAAIAAYagAAAAEJikSQxMq1wjayH0/m3kjw+SafZU0rVKLCycUggT0pLAB+3XB75KXphWWgNP8Tvhxg==", "0807d9be-ec6b-4f21-9dd5-836823cfd125" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "125",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35da2fc3-c544-4e5b-844e-7d8d597dbf89", "AQAAAAIAAYagAAAAEFsOLvU1/CogN6jviEq/pTVzLVv2uUv55M9bzCYVa8kr5LJnqtnt1JhRKWzvZdO5EQ==", "d646869c-c288-4ad2-a128-482aae9095a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "126",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6a32e0c-a237-4289-9c00-a67aeeae1d1e", "AQAAAAIAAYagAAAAEEVmseXIAXXaModol1cxMgxjknd1MOgMwXDWO3IIUiDWdbddU5dGAIxWat9V7CADAw==", "47d47a12-8021-429e-ae43-a620758492da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7f50c78-c350-45f9-a920-a8d84357d8ee", "AQAAAAIAAYagAAAAELtAL/Fbdla8gHuMXkK6iEAVefw+Op/xmIAxs2YCOnfW2iC6mmHD9Jl73ScVhlFWKg==", "bb903751-7655-46e0-be41-016ab9227ed8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "128",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d2f765c-8c56-4c78-803d-c050f93adb63", "AQAAAAIAAYagAAAAEJfKsUv79PFV6zUgkVVtq/x63Z/kFLLG1G53m9a/OnfjEICGOHi+Qj+un0N/vr62xQ==", "c5fdc6ab-3887-44a9-925f-73b133a9dd8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7b49aa6-b0f7-430d-86ca-f1256e09c7a9", "AQAAAAIAAYagAAAAEPmlwwPmsolt9FVr7d4kOSezHlJg37/W9r+L7gVigFEMlwsjFNmMmmfBVgXYy0Tcrw==", "248e188b-ed8d-4b27-9ce6-0b76d3bfd19a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "130",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af26e306-111c-4e18-ad90-0597fd86380f", "AQAAAAIAAYagAAAAENu5Q0mLffcpEGMZwg7VxNlbCaEWXEJCoSpme6K+Vp3st11W5/Hj3YAbWeieqcv25g==", "223ed1e6-1dc9-4ff0-a84b-ee590ad1744b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0350243-79cb-43eb-84cb-031a15a80e93", "AQAAAAIAAYagAAAAELI9pfH/HLmqtXJCUNisoQOmovOlwgdSGxlKR1VMLz31MVULuUT0REATR3bVUyyeHg==", "c0a15a01-b565-4dd1-b95d-3f2d784856c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "132",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "896e4d6c-0480-43b2-959f-b829a9054eac", "AQAAAAIAAYagAAAAECmuSDGUq9VP0u6w4UNxP/roNIBOmaqq/H8Nszar3u+R4Al7eG/gDHtEyntImLGyIQ==", "01036ef9-5e3c-458d-9964-5e3490f22177" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "133",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73cd2c35-0a1a-42ff-9743-6d474d98363b", "AQAAAAIAAYagAAAAENpyDDLqyjuKCkkU/WH2E6pGSaw8xds3LFTSUFPv1bz6XDtbdxK3gmZ7K5d2xC+fLA==", "927f0886-ea5c-405d-ae14-5614b7dd2ced" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a886162d-781f-411c-9a2d-5bba0858cd6d", "AQAAAAIAAYagAAAAEF8Ro2EqWF4XI57aivYtzDV/W1pYGWFdSVi3vwyevkrhMoqEmwloJW8LdmBkZSLagA==", "d4186162-8bca-4111-bfed-cdfcab0fdd5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "135",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84a75a11-b5a8-4fee-b5c4-aa1be4992fdf", "AQAAAAIAAYagAAAAEPSBfg2xvX7d7c+FXmSCYRFVltdoFQ2zkNSBStzYNAeIFktjaZ2abPe7PWuPEdms9w==", "bfdd0a4b-437a-4e2f-ae88-c4e90e702f81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "136",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a2ab461-7aca-46d0-b600-60b26b080ab8", "AQAAAAIAAYagAAAAECeHqaOtB9+ZhIiFybHXfKZTpmxZRGyPBA8gjfCT3IJxiP84Mk7vf1aZeduUKy8+rQ==", "5b4cd4b9-47c3-434f-9611-813e7ccbd156" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "137",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02ae1e40-e19e-4662-a46f-da8f46f92433", "AQAAAAIAAYagAAAAENHCzcmYLacmPzOHwhXP/r/s5D92FCdwU5s/DI9alJvv1VqMxWd1EkSmG6vRKYhX9w==", "e2d0d087-0188-442b-b9f7-0f2c982251ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "138",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29e532c4-2947-471c-acd1-cb4c340512a3", "AQAAAAIAAYagAAAAEISp6rHOCVeF2Le9C+bOi0etQ3frNqqdAw/WDOhna4DUTfQX26l7iV+QnLcGaQHt2g==", "03eacda7-511d-42ca-9ed7-506703e43ae0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "139",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1275fe9-ea9f-402e-a158-e9e52d32c56c", "AQAAAAIAAYagAAAAEDQmUEs2JeXjr7zWaliLDBTTxqpJBUO+YABB13Vh5RU+TYOk2tH8COcgTITlb5D0Uw==", "c5401cc7-6445-495e-867d-2fa7835bc015" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 26, 807, DateTimeKind.Utc).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 26, 807, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 26, 807, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 26, 807, DateTimeKind.Utc).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 26, 807, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 26, 807, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 26, 807, DateTimeKind.Utc).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 26, 807, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 26, 807, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 26, 807, DateTimeKind.Utc).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 26, 807, DateTimeKind.Utc).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 1,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7666), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7663), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7665), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 2,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7671), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7670), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7671), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 3,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7687), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7673), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7686), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 4,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7689), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7688), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7688), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 5,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7692), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7691), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7691), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 6,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7694), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7693), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7694), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 7,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7696), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7695), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7696), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 8,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7698), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7697), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7698), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 9,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7701), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7700), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7700), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 10,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7704), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7702), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7703), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 11,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7706), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7705), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7705), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 12,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7708), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7707), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7707), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 13,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7711), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7710), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7711), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 14,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7714), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7713), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7714), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 15,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7717), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7716), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7716), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 16,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7719), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7718), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7718), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 17,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7721), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7720), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7720), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 18,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7723), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7722), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7723), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 19,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7725), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7724), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7725), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 20,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7728), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7727), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7727), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 21,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7730), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7729), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7729), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 22,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7732), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7731), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7731), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 23,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7734), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7733), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7734), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 24,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7736), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7735), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7736), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 25,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7738), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7737), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7738), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 26,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7741), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7740), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7740), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 27,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7743), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7742), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7742), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 28,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7745), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7744), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7744), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 29,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7747), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7746), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7747), new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 8,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 9,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 10,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 15, 29, 103, DateTimeKind.Utc).AddTicks(7559));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BillAccounts",
                columns: table => new
                {
                    BillAccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    OutstandingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillAccounts", x => x.BillAccountId);
                    table.ForeignKey(
                        name: "FK_BillAccounts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6337dddd-442b-48fe-9c69-73fd3fa15f89", "AQAAAAIAAYagAAAAEBVtzLzNVVturutw6/inAf/0Saiaav/rQBRePbB1rR5ZR4p/lBNNBDrrAsw83JVEsw==", "d0fbfff2-7a9a-45e7-a53d-78673002feea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a171d09a-ebe9-4e86-ae6a-8384d1874b9f", "AQAAAAIAAYagAAAAEH1ZN3qytPBW4OfbBedFl6BMX/NTsM5MFQA2AxwOcdZhqOVM4upNr5aVVqxtyPPClQ==", "c98b7adc-3c33-44dd-8d54-67566e315cb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbde49a1-8b1b-40d7-ac1a-789a3778c98c", "AQAAAAIAAYagAAAAEAKggEf29ABX/0lgZvEfFlxFCvt+5AU9ZZ/Ey5NrRJtORtIqyC815lSWsca7eLkxAg==", "598de6ad-4761-46d9-b58f-72fbf0ac27c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66975b23-f08d-44b6-8f8b-de1c96b7fecd", "AQAAAAIAAYagAAAAEKMIgjRpW6QDpGkGjMPaX0WYzLLtLMP3z6vsvhSBWC/zKuFkeNfQekBdOAGAuUeS/Q==", "adfbd1c6-a763-4a47-998a-4fef9d97c8b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa7d3765-63af-4daa-a6aa-eaf4878686f6", "AQAAAAIAAYagAAAAEBvHUD64EQTbxH0rJ8b9r2qJS079hPnm0YpOgmveeSwbasCJLqRZwq9chECUj8JFGg==", "df24a8d2-1ba2-4f43-99b1-860184ea0cb6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "875fdd62-ddac-44a2-81b1-db7f1cf09727", "AQAAAAIAAYagAAAAENsTlNLcFRfv8itf36vB0vOCYuObKLeSqOUf1kPjh7GRzA7RF4Io5W7fla5nDBVtzQ==", "214249d6-0ace-4923-821c-a9f087c3290c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3701a701-eb02-444c-9a86-17cdf948fc10", "AQAAAAIAAYagAAAAEGq2v5oiQv0nrnhdzZoWk9vgIHl1hP1RlDy5CKOUdx8umb+Lk+4hnR8Wh9/ugZxmHA==", "3e7050e3-2209-4eaf-8a51-22ee41d0ee57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c31626d-7619-49fd-9eb9-83dcac7d2d69", "AQAAAAIAAYagAAAAEDL9yOWoHMo2BA0T3Y0Uibrv/hiNVdEcwZGU/ZBP0+JX50JJFEmOOhqPdVQCnqFovg==", "2719a7b1-0823-493c-ba4d-178598776864" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57373de0-df6e-420e-aec7-659b06aa3ef0", "AQAAAAIAAYagAAAAEPBk75fhLbIBbpV4sTrdSG8k2oW5xOSDtaFPr7d34ENvYQVtu8jYSRiQz6NbrxPSEg==", "0fa43696-d62a-4899-a2d4-8d3bc226e4ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d0c5109-959e-4a25-a459-da709bee99c7", "AQAAAAIAAYagAAAAEAlNEls4WIeq6larfCH3XSK4qXc5ki9A9ceH6EJyqYMROMsShLd1uvYCPVMiXZHyXQ==", "2ae9b01d-7850-42d5-bb64-e1b94f93ad1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57bb79f2-d62c-43a8-9ba9-9fe19d347e4b", "AQAAAAIAAYagAAAAEC6Gnya9mP1boDxnqxeFdz/+mY2zhgQ0ut1SQszDPbjfiwMrNNzQDRm9Claoom889Q==", "20b8b396-d862-4fda-aaa3-df55f1cd395e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c973c37-d2d7-465d-b9e2-13c82910c831", "AQAAAAIAAYagAAAAEFl5icSOSRHB+hu9qoTG/GFmI2LnPS65UW0Ar8ORTif4a0F3lPRh8vyQ9/Ut+4vEtw==", "62b2c0b1-feb8-444c-a06c-dd84333ed4fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "113",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ce03d2b-7616-485e-ada4-9691ab822ebd", "AQAAAAIAAYagAAAAEJr84bsr3IY6ZMgBruHtpO4gCHRnT8Sb9JwOEb66KS3nRsboIX5Nw8PfAiD1q6NyWw==", "0769d965-8b87-4db3-83f3-5904ee5aae38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "114",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdf50fdd-4367-4b68-89e5-2fc579a86b4c", "AQAAAAIAAYagAAAAENOBHyrbb16JyFY2cP7ClHDVJUHWY1ChI1rm8sRD/bEBTfNsE1sdkRFp7IXHI8Ka7Q==", "03ea5efa-a862-4145-b1ec-669324919a2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "115",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5494e96f-cbcb-4994-a27d-c3a30caa0fc9", "AQAAAAIAAYagAAAAEDaigbzkaqST9K4zFu8jNdZTKjBoObbuM72lU0CQK7X7VQq5E9mGi0XGHD5GMno+NA==", "49a4d508-2fbc-47d3-a113-5cd3ebcb0993" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "116",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb73dbce-da54-4b14-8fab-e51aa90903f1", "AQAAAAIAAYagAAAAEByUVuG5fG4FYAQnThmyr6QP0lZOhsdiIM8KqW0LuXNQ/weX0xooISMUWuTiZl1lLA==", "78735e73-466e-4f67-b2c6-0e516fde4ac8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "117",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee0ddade-fa2a-4103-8b91-671a44d17ccf", "AQAAAAIAAYagAAAAEMFKXaOfmfWRQrojh3R9Oto2RxoV4wfPy+zd6SioyhlgXO/iSgxfq34lNQ/FyIHx6g==", "3cc65e97-43dc-4597-a418-e2b058b02577" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e11fdaae-da15-41dd-a630-1cc9ead8a517", "AQAAAAIAAYagAAAAEB5lPwWtNuo0L6xXtkywK2vk4vNfU75GhAsP9gNkIzht8St1jsJM8EPtWP7ckTm9GQ==", "713bc29f-32f4-42ca-a478-98609f57818c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63a78c4d-04f0-46ca-8480-cb98730a4930", "AQAAAAIAAYagAAAAEJFDdqPpGeEhtHaEaElBOLBqHsDoW22A1LU8DMC2HI2mX7o2bORdXmCsKlgKHTipGw==", "a807646c-dfb1-4197-83bf-1ef15c06a538" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2d39fe3-90c3-4f24-824f-37b5cab3ff75", "AQAAAAIAAYagAAAAEHJXtXG9gxM5Z0Cvpwjdzcw4QIOwd7fg6PEjXWkchaimgBiSzHnCJPK4D9QurkOyNg==", "24096d22-839e-4f1b-ab08-56acd5324765" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "121",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d4b5c2f-4e7e-4e5a-a70f-c055ffe703e4", "AQAAAAIAAYagAAAAECX/121JyzXk/xfxAr92sCe3iNY3/eGSPhnLoT0aEhgITzz/d6ZR8Z+pHqL2mgwo+w==", "3581f7f1-4003-4f52-ac77-d18f0e7deed5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "783aad34-bc57-4b69-943d-9c44446e769f", "AQAAAAIAAYagAAAAEJBasBNGvcSY6/n3MzBAeZoU4mlJyXj6y/mjDTdyaE8ytoHrJraPX7TOhIwoQS63tQ==", "eafa4f11-fece-43d4-8ea4-f0eda566e387" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9314a0fe-ab23-4a1a-bfb2-16834339e2df", "AQAAAAIAAYagAAAAEOXP8sm96XRyslhFFXQFYfBROtDarMS0b2nikZM1HTgw4pG2iZRB7t9o6aHuBT1ulQ==", "66f30389-d7a8-4cab-979f-12637d34e708" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e01db0e6-6b52-42e2-bf16-ae4a08eabf99", "AQAAAAIAAYagAAAAEA06KOQI4bqCf1v3RpslcSpdXI2a+mBjXDaSORdPBruble79oaJvazpPFULefrIWXA==", "aba8987f-6b75-4f6c-a0c6-8b321d2d8de9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "125",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2c4f595-f9ec-4e31-bf98-c6330e66d4f5", "AQAAAAIAAYagAAAAEFwAR+HY80dHAkDRATqtWbCWnPMbsv6nc9IikZa+WJt+y2PMUQhmfYyCLHCm02GKVw==", "fecdb1d5-9abe-4a59-95fa-8b3c557b765c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "126",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0719f662-1c1c-435f-b93e-da0b2b1ac3f3", "AQAAAAIAAYagAAAAEARV02pe5XvjIkNKwiPJUpX0+d03OfxxV9yy32AMwa7X7rzNOUbmyqtiTei4J2yThw==", "33c8cb5b-707a-4142-af87-6b7629ef97b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82c95119-2527-42ec-b522-ce4fd0387bcc", "AQAAAAIAAYagAAAAEKCSqVFw+Z35pVKLyWOne323j7lq0rtPWoGtzUKvMDJDMIjMLKuiJccHiRxPnj/t1w==", "663d1696-bdc6-4e0c-985e-e8b54b3987d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "128",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cfe1ca6-39fd-4904-9eed-a95901794cf9", "AQAAAAIAAYagAAAAEIF2W47qM2xuphTxhjDI2pnDYkkHQml5C3pzpBFgF+4uev7YFoOvVUWgjdznTqb/vw==", "01a80a85-205b-4866-8e9a-7af5861d76d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d8e76be-edf9-40b4-9469-c62272d00a58", "AQAAAAIAAYagAAAAEEVCej4k61YxiHTL+8mwUIn+sN9rMUp1v01AyYfYUWUzSWBnoXXZM2Abnn3JNiBQrQ==", "c1d901d9-141e-4425-b9de-add343fd292f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "130",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb729cbc-ed1c-4fd5-aa5e-4a30a211dc0c", "AQAAAAIAAYagAAAAEG3LxpqwK77ZBlMYYQuoij2he4q9wHWyKV3wbnNQs1IBgwLIIopSe3A6dc7nkTktqw==", "064696b8-7ac3-40f3-bcb7-6e68d96afb82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2959e800-96a2-436d-b219-70fb11cae412", "AQAAAAIAAYagAAAAECKueAGDNXr3SXW1Wq/Clzs2VeHZEO0TKHvJcwhe0n/C69BkaAcn6rStJZ9XImsUlQ==", "2e1a6a5f-011b-4c64-9eb6-6abe987ebca9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "132",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea869ad1-4802-40f2-9751-fe6af371cd41", "AQAAAAIAAYagAAAAEOYKZqLf+sVt8up98jreWBivL2H5BmA9rkxM/Hq5DVPDAjzMw1i9K/lIGnihxrpeSg==", "fdab8870-a77e-4d4a-928d-18cb724f6986" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "133",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55d10b47-b7b1-46b8-8d44-31a68237d007", "AQAAAAIAAYagAAAAELsg2v0mNDI3LIlXZ27FynAjp2HhYyU6vnzmtgvJgR0CY+5uQI4EjxQK73syhyMOdA==", "44426070-a261-4ed4-b651-4bedddc190c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26e4179d-0894-42a6-a7dc-91a39ec448a3", "AQAAAAIAAYagAAAAEHqY+SZyO49YJzFiyv58tECMb38RtJjKc6HUPrG8J97V5MH57E5TysQ8/glzKgaMyA==", "1e2e9ca7-a045-4429-8502-824bc3d9f5a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "135",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "feda6414-7fa5-4b88-a6cb-536c73642dbe", "AQAAAAIAAYagAAAAEPvSrnCKJ6WhgQ0+UjEFXkcoIcXm6TIQ3cy9svVky/wt4WlWYfmCBuC5QmSsCodttQ==", "9da3fc6f-3833-4ac7-8b7b-e5367f2ef3da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "136",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2af4f47f-fd88-48c2-89d1-8a7e5b7c8887", "AQAAAAIAAYagAAAAEIDWmn0KLQ3/7zSporVRVJEQv8f1Fr/QHtqWsa8a7fQrQRaKZ2WfXVNMUUdStk9Svg==", "65627d2f-f03c-4c63-a30d-98669c993938" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "137",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63af0565-d5fa-4d55-92a1-c5f5799147bb", "AQAAAAIAAYagAAAAEEngUfyruRXjugFWdjuhW/uQUtYgiiddoPjRlEMT6nxZ5SkEGcR+R6iqe0azLYg37Q==", "11833809-c93b-4715-8942-e46b80e721bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "138",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5985e213-7f5d-4ff1-b190-3fe7d9e33aa7", "AQAAAAIAAYagAAAAEL/ZgEy7veiaPsCvn7VWVUwdat6bSQHVp+EhrqzPixDOCUAuawJjZ7OF/jho+OJ+sQ==", "fdf022e7-90d4-4d4c-90ec-4f212ee7c04a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "139",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa56ebfc-0031-4103-977d-66fb70623ecb", "AQAAAAIAAYagAAAAEMf9ukLpqJN9UC/0zAcOjGjmd3j1iad2Gw9r8KA9CClOI0aBCJUrHDrBxsZ/KIoiqA==", "d95a0b5c-ccf0-474c-a1fc-e1c6b4d437a5" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 42, 457, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 42, 457, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 42, 457, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 42, 457, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 42, 457, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 42, 457, DateTimeKind.Utc).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 42, 457, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 42, 457, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 42, 457, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 42, 457, DateTimeKind.Utc).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 42, 457, DateTimeKind.Utc).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 1,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8245), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8243), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8244), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 2,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8254), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8252), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8253), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8255) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 3,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8258), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8256), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8257), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 4,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8262), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8260), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8261), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 5,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8266), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8264), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8265), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 6,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8269), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8268), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8268), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 7,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8275), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8273), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8274), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 8,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8278), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8276), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8277), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 9,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8282), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8280), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8281), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 10,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8285), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8283), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8284), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 11,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8289), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8287), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8288), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 12,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8390), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8388), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8389), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 13,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8393), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 14,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8398), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8396), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8397), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 15,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8401), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8400), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8401), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 16,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8405), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8403), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8404), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 17,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8408), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8407), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8408), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 18,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8412), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8410), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8411), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8413) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 19,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8415), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8414), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8415), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 20,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8419), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8417), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8418), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 21,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8422), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8421), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8421), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 22,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8426), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8424), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8425), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 23,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8429), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8428), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8428), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 24,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8433), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8431), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8432), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 25,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8436), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8435), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8435), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 26,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8440), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8438), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8439), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 27,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8443), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8442), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8442), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 28,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8447), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8445), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8446), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 29,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8450), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8449), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8449), new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8451) });

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 8,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 9,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 10,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 6, 32, 46, 24, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.CreateIndex(
                name: "IX_BillAccounts_UserId",
                table: "BillAccounts",
                column: "UserId");
        }
    }
}
