using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class AWEA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BillAccounts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "BillAccounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BillAccounts");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "BillAccounts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78988552-75db-4f7d-9f49-c66cd0e12d60", "AQAAAAIAAYagAAAAEMNyWbqYNKdK1bR2BxLI8ezjYBy4TOD+P+oPgMf0AlODf/LGNMd4s48uA5u4ei6WAQ==", "98ba5891-9434-47c3-acd7-f555b45a1a50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bf7b85e-4c4f-41c7-a419-8aaad6441824", "AQAAAAIAAYagAAAAEEHgaASDytDMB9FLJ2MwcAdywbdkjGzC2KLigCLh9fq45eIO3Ro9Xd8OPF+yWzEXJQ==", "4887d993-d31b-4e37-8bec-524dfe879d73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7539264d-f390-4c00-b670-b39f97649264", "AQAAAAIAAYagAAAAEEnFRkY7fzGlFFtKCiMb6VZfbskuFWC3oOuP5SrZihQqNBy2un8attaetIccmbhS1A==", "418e7d99-3efa-4a5a-90b9-0aa0c2c4578f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ebbaabf-608b-40a8-95d8-49a10f30df8f", "AQAAAAIAAYagAAAAEJgTQeAKUOYXBPwGMSNcAizNWWn54QHq4CPlWpuNBBSgj+6Uy8yfEKfHGq+8ivBpeg==", "49cc0a2f-24fe-4f78-8555-2161b78e443a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2b74636-f0ab-4d92-bc5a-6c2b3f29f756", "AQAAAAIAAYagAAAAEBZGY2ATMc/r0fhmv1dCePeb/glXuXzwiwudrsqw0yrfNAcpofgFOia10taIKQhYKg==", "728f3fcd-9721-47b1-86ba-f04eb7d70b9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2da29ab-1785-45a6-9f72-5e3baab86547", "AQAAAAIAAYagAAAAEA4+Mu6Phi9lwIYtXRwPcXWpQlIRy2e3ts8VdII6AWGPsfbj/YQbSpaSxB2tgXWxhA==", "48a333a0-2486-4e64-b01d-64cc915a2814" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d04db877-f2d3-41b9-b619-dafc16dfb2aa", "AQAAAAIAAYagAAAAEPF9p6K6gZcCGs7rNcgPVOdQEdpUiqUcfFTbTyklIlKxFnp3SQhJYuRMuwOPnfn09g==", "496152be-b473-4258-8e3f-06fc5d3c1765" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19d593bf-1c2f-4f2d-a3e3-30c21f10f237", "AQAAAAIAAYagAAAAECOJ9Fk8TTq2vdO5LFLP3tRnhkGbq5cvnjvOo9thYIjeEyMyAqY8L6aSnbl3LF6eNQ==", "0b424b3d-2dc4-4d38-8d2c-7f78f56fa3ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff8437c6-d678-4659-a2f6-abe2258e46e6", "AQAAAAIAAYagAAAAEPKCWhGie9cy5BKgfvehbdgdwWAAHK8t/GhpYwmmaMB7JKT4yjd9C+KAJ8Lzed72LQ==", "631d52a6-6683-4809-9d71-5d093c7a5045" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "506592a6-3701-478f-8b42-4e2276fae52a", "AQAAAAIAAYagAAAAEB9xl38Pd8CkrtANpVcR+03rbeQL+2kczjG46GuDz8T2DrRUMqvdlAovMaYyadB+Qw==", "52094d0e-6c24-46ff-bed9-fdfbddd631f0" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 26, 670, DateTimeKind.Utc).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 26, 670, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 26, 670, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 26, 670, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 26, 670, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 26, 670, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 26, 670, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 26, 670, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 26, 670, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 26, 670, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 26, 670, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 27, 334, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 27, 334, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 27, 334, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 27, 334, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 27, 334, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 27, 334, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 8, 34, 27, 334, DateTimeKind.Utc).AddTicks(3969));
        }
    }
}
