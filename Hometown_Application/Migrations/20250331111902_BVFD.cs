using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class BVFD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BillItemsId",
                table: "BillTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0700098-0a39-457d-a542-23c6d943a268", "AQAAAAIAAYagAAAAEL+T8SN8s0sWa5MBIx6AVzBZO4QjEMv1YQinXQKKGeCtPlxKdZIK6EZdezHnc69jMg==", "16d4c3b2-da86-49bb-8563-3337fc3a39c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa9c6436-16ab-4279-99ff-cfd459df0f9f", "AQAAAAIAAYagAAAAEEDTKRg+U88I4FCNlF+y3d6zJyTTeOSR7+TiM8y9djXZh3tKgr4fAhpj3ikhKyttYQ==", "fd3dd291-cb6d-4b61-bc16-4ba6e8a4ed96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66881b5e-7918-46a7-8f96-482460285b4e", "AQAAAAIAAYagAAAAELfrmeQNIfekXft41EiMaeFvmNmr31pI3UL3HYADQWo8Wzt2gwUJQTge2lpKYqb3TA==", "52e4241a-620c-447b-9f9b-a499e01be333" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c22f6060-07ce-4dce-a692-c939245548e6", "AQAAAAIAAYagAAAAEHSKo4GEjIlgDeXeZ8Gbo9TmFDQ0Ah683/UWGLH7mayP1Bo04Qun84GVB6i+fsGFEQ==", "97375c0d-6b38-4f65-8a20-a0de0f9cbdd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18c38dde-1a99-4328-a5e4-11fe23380d80", "AQAAAAIAAYagAAAAEOlyxaaZc1DX2pMdFOimNceK6cEu4e+4ibDv3ySK7tdiRQ0FccTlu+WC96Z9x2gDvQ==", "929b1ee3-a359-4772-8d30-b3d59ad7989d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3a4cebc-6aba-4cb4-adbd-4d604c954871", "AQAAAAIAAYagAAAAEP9oyXU8Ya3/yl8ZS1RTIzW0Smon3aVIcFoI55A/y5wGXf7qkXvOodQQjsqZEib+zA==", "2f65575c-a4cb-44fd-864f-f83a9559b020" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e97f1ff-d14d-4237-b752-e32344df963e", "AQAAAAIAAYagAAAAECY8TafnQT6yT+/CepmgxC/lDdgZRHfK0R7bpFNYmIQjG8YbzkY8wA0+WthintxLCg==", "c8e75d9c-c2fd-448b-b759-3ff85078bbe1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3c00871-7bca-4545-a450-47d9cc8e9c66", "AQAAAAIAAYagAAAAEL5+LhphxO6tcHJYtmSxiH8M+rQfCf15EiwVeV0p+G2KlLkj2bui0/QZTSDRJs+3gA==", "d6bbae3a-3723-4c86-ac8f-75f69179a1e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de6186b5-eaee-42eb-831c-ff03d0f0a6e6", "AQAAAAIAAYagAAAAEMYDN766zEIoonf4oUpkuUeF9v5v5kW6ICGZjtpkfWbFCuWCF2O4uL75hckLIOa5VA==", "aa4a89f7-b56d-4d70-b354-a840087ecf48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e52f1d48-ab09-427b-9c12-6659351760e7", "AQAAAAIAAYagAAAAENsqx2R5fErsIOzal2hjnsPciVbfwXRITAdNymXr9qdafj+4YbOpypvEcNB10OjZHQ==", "488ab8d1-e190-494b-963b-6f5b0aee6f0d" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 0, 202, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 0, 202, DateTimeKind.Utc).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 0, 202, DateTimeKind.Utc).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 0, 202, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 0, 202, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 0, 202, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 0, 202, DateTimeKind.Utc).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 0, 202, DateTimeKind.Utc).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 0, 202, DateTimeKind.Utc).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 0, 202, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 0, 202, DateTimeKind.Utc).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 1, 96, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 1, 96, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 1, 96, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 1, 96, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 1, 96, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 1, 96, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 11, 19, 1, 96, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.CreateIndex(
                name: "IX_BillTransactions_BillItemsId",
                table: "BillTransactions",
                column: "BillItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillTransactions_BillItems_BillItemsId",
                table: "BillTransactions",
                column: "BillItemsId",
                principalTable: "BillItems",
                principalColumn: "BillItemsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillTransactions_BillItems_BillItemsId",
                table: "BillTransactions");

            migrationBuilder.DropIndex(
                name: "IX_BillTransactions_BillItemsId",
                table: "BillTransactions");

            migrationBuilder.DropColumn(
                name: "BillItemsId",
                table: "BillTransactions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58a2ee79-36d2-45e2-bb6e-186773290ff4", "AQAAAAIAAYagAAAAEGMYngeyRZWWvtxiLX/ZQPnOBGze3H5JO9j0+2ERfCx2cjnsqtOgKl+7CJqNxulbsA==", "1e5e67d9-51dc-4e11-a532-8a22771fc05e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f511654b-f5d1-437f-ae48-23f91f4f4515", "AQAAAAIAAYagAAAAEMQqPnENDU/BXm4Mrhmybo5BCJNN0Fam4vInuj5mg6By5w4rb1sDAS7txWivIy4amg==", "40d78b59-d609-4f7d-80df-0e25d9c11f9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c21333f3-1378-4439-b5a2-8a787cdc6f50", "AQAAAAIAAYagAAAAEDisxtBAMdWVB7/1OltnJ4D4s9nrQhp4abd5LytJmIS89oCaInicD1lXaMtHcQpVmA==", "2299324b-0516-4539-82c9-619bc762403e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc32c878-b258-42f9-99de-067e752df7e7", "AQAAAAIAAYagAAAAEK3h2EJWRNy1843ZZRpZ3zmauwBAee+u+wnPaRsdN24Vv3fwL6+B9rMGUbqPXJaacA==", "8c5840df-6b5c-401c-a438-03b0ada5215e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcff44c2-9832-4305-b72a-fe07a4f906a5", "AQAAAAIAAYagAAAAEK5JX7HJKiJsdM6D/eYxIlXhEU4Sb5ZrdJ6QeBulijhhDN2R8/X8skmXxlU5jMDO1w==", "cbba067a-8db5-4119-a59c-b539d26239a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bc6bffb-3582-411e-a4cb-4da57ba53cae", "AQAAAAIAAYagAAAAEPqRnA8WZOHWaAVDZtFw8Au0ekUFb94tUIfJWQAoFc55UeEBcXQperZlLr81SMi91A==", "f8abbe8f-244b-4809-8072-2b54aed77326" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "511d7411-4377-41eb-9aff-39701151a9e0", "AQAAAAIAAYagAAAAECkrltTzs1RKukKXLeVDeULGDJR1cM4AxXMW/Mapg3zL176oVnOaEgiboF+S7uLzAA==", "e44f74d8-022c-464b-9547-9eb054e3254e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb51bf82-c08f-43ca-9745-5dcd479a7de5", "AQAAAAIAAYagAAAAEKlOu0EzJfbS3I9WG1lsYRwI81HxT9ZDzTUJF+1PjnMhCF0dS9cCdi9ldr2TQ6xcxA==", "4496027f-6e7f-446a-8487-5bce3695c2ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "931cb444-6272-4980-a772-719686c21a50", "AQAAAAIAAYagAAAAEL8Zf9pSyrcTSjn22NE3m/wFN3mx1nxyM2uR/6pKQJcOlpHaSaJNmcO6xXhbBTPn5g==", "68d1e03c-1b14-4cb2-a742-b8e9b3008c91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02c859a2-12ae-4680-b679-f2aea2deec52", "AQAAAAIAAYagAAAAENV05oDd2wC8OklTNEWE30o8F2TG4wGQE2zsTbjLOVuQANWDPFCwycrY95qMYfGxXA==", "f0489493-cc63-4a91-ae65-c5d701ffa92b" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 7, 787, DateTimeKind.Utc).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 7, 787, DateTimeKind.Utc).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 7, 787, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 7, 787, DateTimeKind.Utc).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 7, 787, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 7, 787, DateTimeKind.Utc).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 7, 787, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 7, 787, DateTimeKind.Utc).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 7, 787, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 7, 787, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 7, 787, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 8, 468, DateTimeKind.Utc).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 8, 468, DateTimeKind.Utc).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 8, 468, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 8, 468, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 8, 468, DateTimeKind.Utc).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 8, 468, DateTimeKind.Utc).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 9, 19, 8, 468, DateTimeKind.Utc).AddTicks(1722));
        }
    }
}
