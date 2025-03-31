using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class AWERAWVW : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAccount_AspNetUsers_UserId",
                table: "BillAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionHistory_AspNetUsers_UserId",
                table: "TransactionHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionHistory",
                table: "TransactionHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillAccount",
                table: "BillAccount");

            migrationBuilder.RenameTable(
                name: "TransactionHistory",
                newName: "BillTransactions");

            migrationBuilder.RenameTable(
                name: "BillAccount",
                newName: "BillAccounts");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionHistory_UserId",
                table: "BillTransactions",
                newName: "IX_BillTransactions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BillAccount_UserId",
                table: "BillAccounts",
                newName: "IX_BillAccounts_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillTransactions",
                table: "BillTransactions",
                column: "BillTransactionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillAccounts",
                table: "BillAccounts",
                column: "BillAccountId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_BillAccounts_AspNetUsers_UserId",
                table: "BillAccounts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BillTransactions_AspNetUsers_UserId",
                table: "BillTransactions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillAccounts_AspNetUsers_UserId",
                table: "BillAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_BillTransactions_AspNetUsers_UserId",
                table: "BillTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillTransactions",
                table: "BillTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillAccounts",
                table: "BillAccounts");

            migrationBuilder.RenameTable(
                name: "BillTransactions",
                newName: "TransactionHistory");

            migrationBuilder.RenameTable(
                name: "BillAccounts",
                newName: "BillAccount");

            migrationBuilder.RenameIndex(
                name: "IX_BillTransactions_UserId",
                table: "TransactionHistory",
                newName: "IX_TransactionHistory_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BillAccounts_UserId",
                table: "BillAccount",
                newName: "IX_BillAccount_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionHistory",
                table: "TransactionHistory",
                column: "BillTransactionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillAccount",
                table: "BillAccount",
                column: "BillAccountId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13627146-0561-49cc-a3b9-3f68369554b7", "AQAAAAIAAYagAAAAENC1P8m4/ijZl+q+RlYgMm2OkWDzouway1/Nx84YJ6AcUwhnat4kIRTTblYdZJS3jQ==", "7768648e-96a4-4412-bffb-de0ecf239216" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae1b2645-bdbc-4394-b5e6-f0572721c740", "AQAAAAIAAYagAAAAEJkFcBCsMl4eY2V+9CIHlpdwaou09HJOsQWFfciRx6NDGw6xu+h5iNQC+IKTGxQtEA==", "9fe5c6e8-8837-42be-a4c8-b5cb26284df8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afa96a6d-e1f3-4f37-83a1-527d8451107b", "AQAAAAIAAYagAAAAEBD5oCJjw7fhCcB9PZ941e11z0xHq0r7d7mV+lQWRaAYq+VQAVSQeLV6fCGhBTxwTQ==", "f04f8c6c-de25-4cde-af10-31150c009103" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4d05a84-a052-4ef1-9ca3-a1a35c9272c2", "AQAAAAIAAYagAAAAEBE51v+ZHRczJVOZsMCTGxTofEyRbcztAqSw58qJF/u/T5eFL0dX3akykOVGWqbz8w==", "c65a3359-5ed8-4ee2-88c2-e15ed3c83a9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b17e517f-35a7-4355-8270-a65b660e64cb", "AQAAAAIAAYagAAAAEAm+FruG7TjmcQQXiCOrikBKk0p+OiHrpBnyQjiYUptMj/OzLo0hn85Tui/wnPrQmg==", "7e0a19d4-d623-48e0-9fd7-efe9673804a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8107ddd9-df6e-463b-a357-06d8aa5ccb63", "AQAAAAIAAYagAAAAEOiBF39IYGc9LkpqNXaDSJzqs7uYqM/5EJ0lnblYNauQ9UBL83TQC1YPpCezC/wdoA==", "97b0dc80-ad6e-4de2-a13a-2b4f8fb21360" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5161d54a-b70c-4446-8040-123b4dc487d1", "AQAAAAIAAYagAAAAEH8jrrClSCggYQfXByeWEe3Zhg4sktEy3M4yQu78ybwd/j2XLh/anCeIx4JnbHOS/w==", "58ffcce0-a86d-4d3b-a8c2-58920fb94a58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa29ccf7-aae3-46cf-bf47-95c62cfc519a", "AQAAAAIAAYagAAAAELJvtOKuOhZLSFUhbHkffQmhGtG7OyOw/g/uVqeCmcqIqt95Yd9lUy7e1q2jCq4diA==", "b6185ed7-e4a4-4a10-af86-e3af5c0bf838" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1d62e6e-bdc9-41dc-bbc7-a3f4373cf61d", "AQAAAAIAAYagAAAAEJlJv03XHgdY1Cp8Sz1IeMyQhab4KyTWUOfAa9NfSNNven3dBh75AQQhybavhN/cPw==", "ffaad521-3105-4420-9958-ca58e815d068" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6a65034-9795-417b-97a7-4d7660568291", "AQAAAAIAAYagAAAAED99dAEiAxSf2XtB53QO+uNzj66dH6tvdw1fWCIkY2KUrvq5z+dV8N00h8FQMQTNZQ==", "7e23bb27-59b4-4e46-b55c-42887500fe30" });

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 1,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 7, 785, DateTimeKind.Utc).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 2,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 7, 785, DateTimeKind.Utc).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 3,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 7, 785, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 4,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 7, 785, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 5,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 7, 785, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 6,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 7, 785, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 7,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 7, 785, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 8,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 7, 785, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 9,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 7, 785, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 10,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 7, 785, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "BillItems",
                keyColumn: "BillItemsID",
                keyValue: 11,
                column: "AddedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 7, 785, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 8, 336, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 8, 336, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 3,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 8, 336, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 4,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 8, 336, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 5,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 8, 336, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 6,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 8, 336, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "StaffProfiles",
                keyColumn: "StaffId",
                keyValue: 7,
                column: "AccountCreatedOn",
                value: new DateTime(2025, 3, 31, 8, 13, 8, 336, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.AddForeignKey(
                name: "FK_BillAccount_AspNetUsers_UserId",
                table: "BillAccount",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionHistory_AspNetUsers_UserId",
                table: "TransactionHistory",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
