using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class AWERAWERAWER : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09c360cf-824d-4d54-8f86-794cbbb1b577", "AQAAAAIAAYagAAAAEGxi16Z2+NjsAZBQDayt4igX8Sq2M8979wy9qF23d0rzOefMgXhiLN8GcpctKe3AXA==", "a0c9b211-097c-4487-a34a-5e8cf73f0734" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03d2b7f4-c2ee-4804-83b0-1c38e24706af", "AQAAAAIAAYagAAAAEDasJWZhY1UJyomVg0MWlx+zcsGWMI229OfSn7FTXTOVc58CTJOZqZTFbcQKZs/OLw==", "83d0803b-78b7-4012-b6f0-ce9180bed756" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3edd1541-ffbb-4b13-b657-eb5b224d5b61", "AQAAAAIAAYagAAAAEIa49xZkrrJ8lQr4S+dVoQlUPxEtyW7CGEDFirPzvzxTZaE8Aubl5y09KYKsWokRgg==", "57752603-add7-4718-b918-dd538f6255a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3c90eb9-cdf6-41f4-bb5c-033086c1c4a5", "AQAAAAIAAYagAAAAELSQZWJHvkLHrgXtPoy4MTNE9gwgzkflZiWbkprjqZZ456Yg1UjIAgWCSeaT7IATaQ==", "894aed89-fb63-419b-8327-57a5875579fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8350f440-489a-4b4c-86a3-deb799d2dd9e", "AQAAAAIAAYagAAAAECrcfUXewgp0zIRuhJXw/dM6OxyfgCeQjbX6qkjaGssHqytTsR5J+Po5tsRBCfnoSg==", "1cbf57a7-3d48-4f77-8e52-75d5a4d18a9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73b74e85-286d-4d57-a541-3ff1af32a011", "AQAAAAIAAYagAAAAEI08YCEk7pYPTn6NkkhZ1lr/qcf6MeNFsOnDoAHyimz/XQVf4mxJKmzGJpATTewDOw==", "da704c72-530f-4347-b0f3-e2519e663a62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e88b26c-15f1-4922-9ca0-02ba471bb8fb", "AQAAAAIAAYagAAAAEIhuZXh6HuoY/AxLmxnY9TRsIUKX7ZYv4oVeomCJDCI7jYvzPqlXqWH7Nm8LdatS6A==", "3bc86071-c2e5-4462-b5e1-8032134c6e39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ffc9429-d2c3-40a3-80dc-e116e35dfee9", "AQAAAAIAAYagAAAAEGpMHz+nOZtiLgu/xIH8dB1Zn3vU6fv9oKIFjuFMjdOokX+H2Y0d4AHl21Kpx74kZQ==", "7b67c746-8a32-40c6-8ac9-fe5c3b08138d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec3ec883-7cc8-437b-b738-f74cb08dd877", "AQAAAAIAAYagAAAAEI2luoMJb/j48fARwn+WM3ybTHbNsUlmrBXgKrhdaGnj5MUN0YpD4dIrEJ/CT1nEzg==", "e03fc21e-3991-4afb-b450-b1cb9c05ad5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21b3a8a9-a511-41fa-8ba9-c878d68f25d1", "AQAAAAIAAYagAAAAEHsGHFtRg1/0QIcERPp0DFedgzptQ6f0ZB/gaqpJyfW2neqkByqs4yq2+VRD+No8wg==", "9be50230-0954-4f65-9506-ae010dd3dade" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01aead9f-4b73-4c76-8237-48daca40300c", "AQAAAAIAAYagAAAAECF1yrlYkGtWOpVMK9k/MghiVNdlCTDM9jqygaQx6bVw913LhzDl/kzZhksuB4p1hQ==", "69ef4428-0a63-4243-8ec9-1bb6da69e645" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf41aadf-ffec-4d5f-8671-fae372aaa8a1", "AQAAAAIAAYagAAAAEJncXUN1jX5bcP6p2XUQdEuugn4u3Vbr7XsTQhoIwsk55UhV7XU8w8C0SfmjZ+qt0w==", "791cce56-af15-4329-a05d-0bf6aed78639" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "113",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9e46f0a-03ff-4db9-a55a-0ff31df4a399", "AQAAAAIAAYagAAAAEPvgcwohoTy/tVZAZ2tmtMrK42CMnhxrAgjvJjRuyR4V3CqP95sVmkf4R/Jysby5rA==", "7cf18d9e-0d9a-4121-b3a8-31d1e6c85e92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "114",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e6ea3eb-7513-4c01-ab91-313f9be68a7b", "AQAAAAIAAYagAAAAEMcSIpCFgmqNqBzoCnm1MdWuFkYsLaUx41Y5aFTepXmd2LKemNERAfe/uuWHJ/SW2w==", "9f060330-e862-47a2-b25c-0481a74bea7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "115",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09d3097b-f9d0-488c-a687-3458dc2d855c", "AQAAAAIAAYagAAAAEGaKfTLgnb0qxDRE7fk2cxkZ86hZAoKseKiyTxlyut5B7pHchHact7Vkwn7p6zlROw==", "735d87f7-0781-42de-bc31-fa2c39a4d133" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "116",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2abab477-9469-43f1-a402-fc19017ff4f8", "AQAAAAIAAYagAAAAEOVW/tiWOx+bc2m7S0+lLnT/rh8S7NrhZwGJvx1APBUZohD+JNZ0X2OZ14SbRRs7tw==", "e80f1951-3f2c-499a-a56d-3039dcb2a4c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "117",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38470169-5c67-4da5-a390-313342e6b6ef", "AQAAAAIAAYagAAAAEAm1iGm5Qncle1tAMEcn6+Z6x+yrwkLCrqV+7Z9tIc7YTh04K2d/eAeUcpAnEghrgw==", "f00889a3-6c82-488c-b40d-53cc23c290c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9869ec0-855a-4ba7-9f1a-0983f699cbd6", "AQAAAAIAAYagAAAAEGAYH9HuQ8Om1Kw2Y5Es0ttKawu6zZRSh5CG9new4hByKAi3qXLisGd+12RFv1ELYw==", "32b621ae-6634-4149-9417-bf4973731a0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca8f5f55-b930-4e3a-b5e2-524bc9d66106", "AQAAAAIAAYagAAAAECXL+B/zw0Z/8yLf/0uzA4C11n9QvlBIVzLqxksP1ppRyO9su0N/Kyfl+QxCmdMJbQ==", "076acac3-8227-498d-a3c0-1581406c10a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "364f10f0-16d9-479d-a560-948804961cbc", "AQAAAAIAAYagAAAAEPhZX7rM4WTyhrBp2BIq2CEgai2x6LAehBLdtTj9x/d0uZXtWtKCp/Qopx8bIDYF8A==", "40663358-2da0-45d6-b10d-20aafca7290b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "121",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "327d04d0-504f-46cd-a654-c4ed73967bf3", "AQAAAAIAAYagAAAAENuQ+/86RG5vkjZxNBxQmdL8y+Quv4TlvnF2R4GtE0h420j/FBEuNxSYPK5H2barmA==", "7cb6734a-17ed-4fb3-8940-3aa05fc3481c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94c331ab-a805-4dd8-ac6a-181038425ee3", "AQAAAAIAAYagAAAAEMuRSr5zsH1CSwN+CfEgHnqIZY2UniAaQJSjGPCBLS7OjWedO5JM8Gtbzp5x8Ah8Aw==", "089ab1c5-f50e-4e2d-9283-64919bc27ce4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6df8b7d3-2e61-4fca-91cc-83346afe07ef", "AQAAAAIAAYagAAAAEN14/4DBR2sSwLBcNfdFpXDut5W8hE54+9uWAy06xnPpIdthC9iriqSTYvhTdzRQLA==", "7d9602a8-b6f7-4172-bb98-cc2a2fc897d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "606f86b3-2fea-4e1e-8a91-921084adbbc0", "AQAAAAIAAYagAAAAEI6jJfbFFMRg6nhEAIn+rCfbrBDp+KPpTvH5agHJVda42Mx186X1jkjy1xXw/yvlZA==", "85f01a34-58b7-4524-aee4-b2d1ca0fe499" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "125",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d0ddc9d-0cdc-4afa-8ed7-c9e589f93911", "AQAAAAIAAYagAAAAEHJfGjCunQOleQY6qYd6ltXV0fi5bWXQXQmiFiWrzALNPXQhWH6eWG+kiTWrus9j1w==", "c8c2575f-7e04-49bc-bac9-30597ca68605" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "126",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0595c48-cad9-406d-8eb7-98969b61418e", "AQAAAAIAAYagAAAAEKLyJLYOG5z6JMWIisaYK8n7R9dAnI7ZwtM85D2+HDR5HFal2xHaiohl5I2ZYOASnQ==", "4269ae70-34b3-4cf0-beb8-0f198814a480" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc7e023e-5a65-44f1-a146-2c4a43ce07c0", "AQAAAAIAAYagAAAAEHFEtO6LdAifqScF4z+rzOPaK6OKv4gkDfpu+cZBr1qVGVwBHTh9DgZ8kSrBkYfQFQ==", "a53e54ea-3cee-4ca5-9256-ec9c564cd470" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "128",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "720a8fba-4433-4ff8-9146-c316b6d96a4d", "AQAAAAIAAYagAAAAEAuwDO7UMrMxw58bTMlxEVl6tMgX3hZMzdXjv+Ya4m7qjH4FvsOkXOXfG4vVdSrhSw==", "c5c00e3c-a918-4346-9e9e-bb241b0abe1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1973fcb1-a8c1-46b3-bb3f-c7835b220dab", "AQAAAAIAAYagAAAAENOCO/fyiiAJr9XBTPx9FbPrDATd6wMDF0pdlc+2aDDfCbH93ZWvhBbncqT7Agvo6w==", "f64cf304-243f-4528-9cfe-8b56082a66d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "130",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7aea1098-09b8-440c-85fd-6add916c67a0", "AQAAAAIAAYagAAAAEF9lqGJ4/YD7SOlCPPVT2Trny/8yfcLgRZ55taa3CcrYyK30nMfcbukQ8IMNukcliQ==", "f7be19c4-fcbe-4c1b-9d94-328ea0cf06eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4da65b17-ed17-493e-9875-292e5e499685", "AQAAAAIAAYagAAAAEL1HW/FRUzB5NVAdb4Q2tFEGW2spmyOMEuvw26aYeDedU4xEuhVJYchuOVob58uBjg==", "0bd4d299-bd9a-4cb6-b32c-65e24408d6da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "132",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24466bf7-5f18-432d-98a3-f05cd647f4c3", "AQAAAAIAAYagAAAAEPg7rGATZ9yat9LATOEumvb3X2/B5dlnIz+bzXKq/DvSzNYbFhl0Sv5NdWwYsrL03Q==", "74945f80-795f-45f1-8e92-6138f7f5108c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "133",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4992a668-5aff-4dcb-a867-146e79fdc002", "AQAAAAIAAYagAAAAEMLgadeoSFgZT1dEMUIDQ6D5PYIEaX4vmdzhnIJMhBmo9l0IHSWzu0IZeina5pH+dg==", "acb9a217-ddae-4223-9479-f24e9efaf9c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aebcd001-b5a1-4d0b-973c-3283440e2f65", "AQAAAAIAAYagAAAAEIPHJl3bBFKc9CA/0jL6IDlaIc+uLOMTMXmSjdKkVpw6TZktxMpVy8uCBAee0V5riw==", "64b44696-47a3-47db-acc0-5022af24bccb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "135",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a86e2bec-3f57-41ca-b3e5-812d4ea5c091", "AQAAAAIAAYagAAAAELBPCBVXPJghUgHJaxHKvsCKdqFTSvQmiSO7dRoauxVo/4Zc1m42P7QhYarKhyPbAw==", "42b406db-ecc3-4e89-a7a4-b5f3e8d650e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "136",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0df1a2fb-ca42-48a4-9bc7-7492db0d5fe3", "AQAAAAIAAYagAAAAEPA4YXLulJjbu22SXO6etYhZ5xl8KpY/K1wePp7x0ipgIvxSatfK1DNJ4j20SbTDog==", "19c085f8-56f2-4969-9cae-285cb96b9554" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "137",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25601708-f1c8-4f1d-892a-967814f13dff", "AQAAAAIAAYagAAAAEDWcfT3tK0u19GXZbsKXoWyihR+f4bk8dt7H2DzUlLiyDUscUGD+8dJWNrc2oZSymA==", "7d7851b3-2a95-469f-a774-db4842f34aa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "138",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "700cbdfc-b009-4633-94e2-867baba12edc", "AQAAAAIAAYagAAAAEMOOIC1e5yN31jXZ3x8aGkm6Rc6q7cdv9vBM+cHjljYzktXDYZbhHP/iGIb63PDmFA==", "4d698e91-86a1-4a04-b266-dd3e62228473" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "139",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "044eb643-fc88-4c4c-a8ae-96aa157aa497", "AQAAAAIAAYagAAAAEI2BawySjoOCQI87v8RE54cqmFjp0vxy/99VHE2RmMO4Mei2KbJhtSMlo7nD8Vvfkw==", "7c7d4405-d995-41fe-b483-e5a7c4ce7137" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 54, 643, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 54, 643, DateTimeKind.Utc).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 54, 643, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 54, 643, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 54, 643, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 54, 643, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 54, 643, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 54, 643, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 54, 643, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 54, 643, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 1,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7429), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7427), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7428), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 2,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7435), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7434), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7434), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 3,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7437), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7436), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7437), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 4,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7440), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7439), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7439), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 5,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7442), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7441), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7442), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 6,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7445), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7444), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7444), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 7,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7447), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7446), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7447), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 8,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7450), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7449), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7449), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 9,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7452), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7451), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7452), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 10,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7455), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7454), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7454), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 11,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7457), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7456), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7457), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 12,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7460), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7459), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7459), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 13,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7462), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7461), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7461), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 14,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7465), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7464), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7464), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 15,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7467), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7466), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7467), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 16,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7470), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7469), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7469), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 17,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7472), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7471), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7472), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 18,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7474), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7473), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7474), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 19,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7477), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7476), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7476), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 20,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7479), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7478), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7478), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 21,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7481), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7480), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7481), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 22,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7484), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7483), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7483), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 23,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7486), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7485), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7485), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 24,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7489), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7487), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7488), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 25,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7491), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7490), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7491), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 26,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7494), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7492), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7493), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 27,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7496), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7495), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7495), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 28,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7498), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7497), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7497), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 29,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7504), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7503), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7503), new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7504) });

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 8,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 9,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 10,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 11, 0, 56, 820, DateTimeKind.Utc).AddTicks(7205));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55201834-8acd-47a8-8327-828c8f86fc7f", "AQAAAAIAAYagAAAAEMo4SJNkulpzrax3yroY+fO5IekS+mqZw6tgouxpwq62wQ3putT0FeB2bIOykmFu0w==", "d7d6777e-6611-4575-8ec0-35dabb2cb1f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6f71735-4538-4b33-87e8-6dfba574cf70", "AQAAAAIAAYagAAAAEIfRA63s9SKGJ2p5DXtBT4XGfywaCNT7BZSVuaSjP+vO01Q+YEIY+eSjzD4cxiKpZg==", "5196d75f-b10e-4819-9f75-ff67a1fbbf12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4da011a8-c454-4290-9f0c-410c3129f124", "AQAAAAIAAYagAAAAELY4L7+Xp9pdE18Dy4kajYTe+9C1WyRMiG1SbfgR8HNPowgriUsFvuzylyove79Lsw==", "284e5a4e-37fc-4975-a704-985b51042688" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e76fcc8-52f7-4b48-b396-9907e89ce984", "AQAAAAIAAYagAAAAEIK7fgftFFKpLM0UawzVtr79T+zKKTpfgjGz7F58ChxoHz5qpyc1BZZ7DxKeJ7LZsw==", "3d503dcd-8d9c-4710-ab80-444e21f33f06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a934cedf-261f-4a08-969f-1c0aab86134b", "AQAAAAIAAYagAAAAEGABAd3Rkm9TB9gLcyAk0ao53NI8ayQGr/CX2A/EVh77uwOvh96HifPOxcZAXSLGqQ==", "580e2525-0dea-4d9a-ba3a-28683aecac04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9149f66e-ae00-4082-b6b0-f321392cc644", "AQAAAAIAAYagAAAAEIdTeX0PXlLvZTqCGDF4/oxf3bCc7qSWQquzR7aJj8OOQ2uP6YtKihA5Z4yX/y3qNw==", "1491a2de-a56f-42fa-b20c-59f65683dba6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "722abf9e-ca4c-4d22-850f-26629309cf8b", "AQAAAAIAAYagAAAAEOjLnYY7f1w/nNFY595WOZJUDb8j4yBAK595O/lBUJW5ohAY7GeK5VFs08RDLAy5xg==", "ee1f36c3-bbbd-45ea-9557-cd77073d1bb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "718616c8-bd95-4033-a09f-49f1902f65cc", "AQAAAAIAAYagAAAAECC6RrJr/t9pb4fZIKl38rGZcDU5f0v2HxOCnjExaOvLYVoLZOi0ibNbrKJQ24B3yQ==", "9267082a-1cf0-4047-9d34-6e7913759034" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a793ac4-b3d0-44cd-90e5-8b3300e44825", "AQAAAAIAAYagAAAAEKrLmTK48OHsA8IhvJuigV/fBtYyWBg1ToHUnr7CdtakeLe/CCrK1TAonGGS6xF8yw==", "867aa1df-a272-40a4-a797-f1f92a43fec0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "942b9ce7-a2e1-4210-89ee-aa2c3ee3487d", "AQAAAAIAAYagAAAAEPdVPmHZl1l4cLQHyMfL7VlMb2maN9+CBYsoaLKAMuNPhfWYr70/A+9/rbm/RUyEVw==", "a5d59fb0-905c-40fa-979f-0d8fe9f04c7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2035600f-463f-4c91-a89a-497cf4ebc9b3", "AQAAAAIAAYagAAAAEOrMU8Jp1jpKiAluGWtMhAYUlQcSbb0CCur9afFzNcQsFYfWG3Q8tUkSE6kubxYcCg==", "5d71e4ad-83ee-45a5-88ee-3f1575ca1ff4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "492c1ea3-d53f-4299-8396-177e5165ef42", "AQAAAAIAAYagAAAAEILKuShvg67J7gPvMwfRaxD6msMznV1YvedZI3VygpjjT0Aoz0mJSvDoaCUwIfewIw==", "1ef34ca8-c09b-4a94-bb12-92deb1d40fc1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "113",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73a4d70c-5469-49f4-8cde-094284904933", "AQAAAAIAAYagAAAAEOiWu3JGKzGhjVmrd8TH1ULT6TRY3pr3HsgMwkCZ/aUi+sZYgWBqiyLVLbvqziZp5g==", "3967da86-40a2-4931-ac0c-92eba48875cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "114",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "874f7a1e-e113-4869-aa34-2804e1a361c6", "AQAAAAIAAYagAAAAEJBG5qL/+d3UtRZbM3XYl4OUX4+A7tThTw8zAMZ+hGSaD3g+m0GvTYckTAy5hF2N5A==", "b0c51e17-3e49-4896-a5b5-b969a0eabd0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "115",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e509dc86-acbf-4548-b17b-868220919233", "AQAAAAIAAYagAAAAENehuxyxyztA17xCqkTc0x7dbLhb/ZDcscKcN6qRcZidueGjptj1KQt5fG3QVIO2Cw==", "7b17578e-5629-4880-8c06-b5ca32466569" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "116",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a810cca4-9b93-4d09-8654-24c7a6851bcc", "AQAAAAIAAYagAAAAEE/Vnv1fFVr5X9jGf8wNKeDPKTkEHNMgiYQH++K4u6LTzA1x1OmIv2L96+AzX/IRkw==", "78b69918-f8e4-478b-a1be-e0b11c2c8cbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "117",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5d2000f-e1e2-429d-975e-756d371e45e9", "AQAAAAIAAYagAAAAENlSv528bAgaenO9y/h+wkbBD1ds+SfZGsTLHdsZwAlVL/PlIoF4OmIqr8ylAJ9hDQ==", "199673e1-e36d-4063-bc82-fe43ce288758" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f92983da-599c-422e-a6d1-2bb7979e5013", "AQAAAAIAAYagAAAAENYQC4XAVxfsRSp2Y7snG8JtzIP0t0bBNTixuuzrnC47IAwa8riVNAQMelQ//5Te8Q==", "3006028a-595f-4142-8690-c233f143fdef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53bc7e01-c523-48a8-9bd4-ea553e0d55d2", "AQAAAAIAAYagAAAAEKDGW6j2N2wZYLxFDNRXoRZqCrIyU2KNT85gSNY7YBifV2SocKITxFQqsR0/mmyRtg==", "9b15815b-4ff0-402e-a136-2558420f6231" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8563c35c-1cec-4b3a-ad3e-51bdcdd442ba", "AQAAAAIAAYagAAAAEPivL20KN9uPF0CtGLJ+Gma6m91e2adqwqNDTJvMWI+1cMkiFOQGAt8+CI1mraY51w==", "f615fc7d-23b4-4e89-bc47-a3de1117432f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "121",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e54bf52b-b0d5-4eaf-8c2b-51516eebf088", "AQAAAAIAAYagAAAAEJv5kawCcVoFpnWh27CTK85sBVTNNNPNA4nCMutuRqfengbpiaDHanqAUDhu0Rie6g==", "95890560-dcc6-47cf-93c8-b1eac8411c5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "122",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb88b08b-5362-453a-acd0-14dd28e55f5b", "AQAAAAIAAYagAAAAEBSO0OZpLOrfHj8NOeAIIZIR1xGP35HfWv1ENkV/8CuqvdHepoKyqao7Z0s2KAlJZQ==", "be0978ae-da60-4f63-8a0e-4b50da9d7f91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "123",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bb329bf-331e-4f45-b77f-7af5b4cf82b4", "AQAAAAIAAYagAAAAEAynLqfbb7pCu73rqy5XqB5k8atG2aiGNzQijPXwSymxKZ0kl87WYqFhCubzL7zSvA==", "3ede0462-4de9-4aee-af57-1eb599683331" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1eb9607-f6e1-4dc9-bf1f-e3fda7e3dc19", "AQAAAAIAAYagAAAAEBo5L2EaVe11xl94Zqz9AlMBFpM+oE+j/tjgBI6eG4lje5ED+uL1cyQNA4DCIjoyMA==", "48d2c7d8-1231-4224-b68a-6428b85346fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "125",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bacd0ae-af09-42f3-baae-4fb4eae346d7", "AQAAAAIAAYagAAAAEHOAP4TCCtMliITbRyrDXPpnELJd51GuZor12ttkXUcu0Sp7EXcKsNcj/Kq+E1EXig==", "a5ce88a1-4547-41e0-ba2a-fb0011b1b9cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "126",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55645c23-512a-43b0-b2ca-204f0c2c00a3", "AQAAAAIAAYagAAAAEAJOEOrI7GooClZ+BuAiIcJTLueV2om4Ex3zmOGgBGToCZUAk/REDGHqcj4Nq7Jzhw==", "83c362c8-5acc-4136-8a1e-0c98dfb0999b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "127",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92309684-f61e-49bb-890c-1f63b5618570", "AQAAAAIAAYagAAAAEEEP6UAT8N1aR5x4q7qcqDkhnphRa3RiqMxLLlW7vYY7QWoXR1rL8fzUkt9SqHex/w==", "613058fe-b53f-40a7-b049-205344775d6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "128",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15365c00-7032-4b98-863d-f69f87295b22", "AQAAAAIAAYagAAAAEMxygg74IPuaRI1GkhBhK+hcAgxTxZIKHhi1xzHyXJpYvmSzGR9v0LHaCmM+kwmspA==", "64675bdd-544d-440a-8e4d-ee98e6e28058" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "129",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "465d75d2-72ce-4ec9-b355-b210a014e498", "AQAAAAIAAYagAAAAEKABUPmS3HwjvGUhzpBv7H6scluTFJvNnMnNI3de+lGdV6zSgxDjb1Vh/7FHybbrHA==", "7cf7ba31-c06a-4e73-892a-d374da22d66c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "130",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3eadad5f-86dd-4dea-aee5-b064c1373c1d", "AQAAAAIAAYagAAAAELPlUY+lgGz5WnyVCCf+IHFp4KeBRlaPaUCMMuIVoD7ooJFI2OIab1dedFimPDY2vQ==", "2b9edc94-1865-4dbf-8c9a-c8f530eec313" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bebee402-758b-40bb-b7d4-1f9422ee7b80", "AQAAAAIAAYagAAAAEHZaIV9aXtR+ztLmAonw96O0q1d87fsj+5dJLsAnkyT6L4SzEaUZKoxQAQLi6q4XKA==", "366677b7-edfc-49e8-99f2-5ea3ab6dabc4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "132",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1957c89-a017-43f2-a019-d25ed58abbcf", "AQAAAAIAAYagAAAAEF3t1CRbeZC31gheeGzsQTvLh2URpRADp1fJvfPP5xV+chGeNt5Eg4nRaeYyuYH+qA==", "22335998-258d-4f32-bc39-802aff34936a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "133",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f208ea5-7898-4f14-af96-a5444951df1c", "AQAAAAIAAYagAAAAECqjTqh+R8vqt/WbujrEG2EljTtafcvtsUKZOc1KnMFVM5eL+vxSWmYwJ74NtHvfqw==", "73800f5f-68ea-4695-9989-693ac427726b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3124cc4c-1a3b-482d-884e-f2d3c66ab258", "AQAAAAIAAYagAAAAEJw++jkxoTV8Pam5AlG5eLlAdosVH5g85fP6FcuRF68csM3LfEy7yZYpTv0YW7b03g==", "8a0f5606-c4bd-4b8c-a02a-e4a404040117" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "135",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6471ed1-ddfd-440b-bd74-5e4e3c0556f2", "AQAAAAIAAYagAAAAEHOWe5gIHwDWwHUU90IMDYrDb4v7Tf2IGaS+hQ0SHC0MaAbQQHtodIDsT931vl7Jpw==", "b64a29a8-0e5e-495e-886e-35557a33d66e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "136",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c599893-d7aa-42f1-8d4c-ca6e9e77a026", "AQAAAAIAAYagAAAAEFiErg4bSIYfy13alIJeTOfIr7bsGpFXpbDV7XstjsvtBTowQiDtpig6KvCXxSU5Yw==", "dc4632d2-7f85-457f-b9a2-83aabd954c94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "137",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd5ed0c1-90cd-4ba2-b86e-c95bd9662e4c", "AQAAAAIAAYagAAAAEP92pTPtmD7REXw0drFptjaQStyBoBpazmjtDZB1Yle7kPQdijLFWRJ0Pmst9QVptg==", "22be0ff5-45bf-4ce5-b1a2-b0bb6ec6765c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "138",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "931751b0-95b8-4813-8f93-23e73126d1b0", "AQAAAAIAAYagAAAAEAUIzh61LwKs1bQIABv1njFeG9H40NI9VJqqtoRlwV4Tu0Mpe/4kAb2al9Cc/n7Bdw==", "1da351af-e9e2-42d0-abd2-ee806262db0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "139",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a62585ed-66f9-4a87-ad60-4f1dd4088536", "AQAAAAIAAYagAAAAEL1637M6cnap1ChsE5Efvn1PNASnGBgartJnDK4ie1AfJPnJKqrn7BfTmUaVVfwSXQ==", "ac7a4366-b2d4-48fd-82b8-b4fa7e4aff3b" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 26, 752, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 26, 752, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 26, 752, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 26, 752, DateTimeKind.Utc).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 26, 752, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 26, 752, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 26, 752, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 26, 752, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 26, 752, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 26, 752, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.InsertData(
                table: "BillItems",
                columns: new[] { "BillItemsID", "AddedBy", "AddedOn", "Amount", "BillItemsModelBillItemsID", "Description", "IsDeleted", "PaymentDuration", "PaymentName", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 3, null, new DateTime(2025, 4, 17, 9, 27, 26, 752, DateTimeKind.Utc).AddTicks(3819), 2500.00m, null, "Monthly payment for electricity consumption.", false, "Monthly", "Electricity Bill", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 1,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5267), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5263), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5264), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 2,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5272), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5271), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5271), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 3,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5290), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5274), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5289), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 4,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5293), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5292), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5292), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 5,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5295), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5294), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5295), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 6,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5298), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5297), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5297), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 7,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5300), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5299), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5300), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 8,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5303), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5302), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5302), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 9,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5305), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5304), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5305), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 10,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5308), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5307), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5307), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 11,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5310), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5309), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5309), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 12,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5312), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5311), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5312), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 13,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5316), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5315), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5316), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 14,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5319), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5318), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5318), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 15,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5321), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5320), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5321), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 16,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5324), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5323), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5323), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 17,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5326), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5325), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5326), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 18,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5329), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5328), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5328), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 19,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5331), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5330), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5331), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 20,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5334), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5333), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5333), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 21,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5336), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5335), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5335), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 22,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5338), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5337), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5338), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 23,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5341), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5340), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5340), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 24,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5343), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5342), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5343), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 25,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5346), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5345), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5345), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 26,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5348), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5347), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5348), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 27,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5351), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5350), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5350), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 28,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5353), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5352), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5353), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "HomeownerProfiles",
                keyColumn: "HomeownerId",
                keyValue: 29,
                columns: new[] { "ApprovedOn", "MoveInDate", "MoveOutDate", "RegisteredOn" },
                values: new object[] { new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5357), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5355), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5356), new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 8,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 9,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 10,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 4, 17, 9, 27, 28, 939, DateTimeKind.Utc).AddTicks(5110));
        }
    }
}
