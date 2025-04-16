using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class AWERAEWRERWEVB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillItems",
                columns: table => new
                {
                    BillItemsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    BillItemsModelBillItemsID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillItems", x => x.BillItemsID);
                    table.ForeignKey(
                        name: "FK_BillItems_BillItems_BillItemsModelBillItemsID",
                        column: x => x.BillItemsModelBillItemsID,
                        principalTable: "BillItems",
                        principalColumn: "BillItemsID");
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    UploadedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UploadedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isAllDay = table.Column<bool>(type: "bit", nullable: false),
                    DateTimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facility",
                columns: table => new
                {
                    FacilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OtherType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(252)", maxLength: 252, nullable: false),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ApprovedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility", x => x.FacilityId);
                });

            migrationBuilder.CreateTable(
                name: "RequestTypes",
                columns: table => new
                {
                    RequestTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    AssignedDepartment = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestTypes", x => x.RequestTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminProfiles",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AdminRole = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    AppointedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsSuperAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminProfiles", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ProfilePicturePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    IsGenderPublic = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsBirthdayPublic = table.Column<bool>(type: "bit", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    IsActiveUser = table.Column<bool>(type: "bit", nullable: false),
                    FacebookProfile = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    MakeFacebookPublic = table.Column<bool>(type: "bit", nullable: false),
                    TwitterProfile = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    LinkedInProfile = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    AdminProfilesAdminId = table.Column<int>(type: "int", nullable: true),
                    HomeownerProfilesHomeownerId = table.Column<int>(type: "int", nullable: true),
                    StaffProfilesStaffId = table.Column<int>(type: "int", nullable: true),
                    BillAssignmentModelBillAssignmentId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AdminProfiles_AdminProfilesAdminId",
                        column: x => x.AdminProfilesAdminId,
                        principalTable: "AdminProfiles",
                        principalColumn: "AdminId");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillAccounts",
                columns: table => new
                {
                    BillAccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OutstandingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RemainingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_Bills_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BillTransactions",
                columns: table => new
                {
                    BillTransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BillItemsId = table.Column<int>(type: "int", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaidBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaymentReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    ChatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RecipientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ApplicationUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.ChatId);
                    table.ForeignKey(
                        name: "FK_Chats_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Chats_AspNetUsers_ApplicationUserId1",
                        column: x => x.ApplicationUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Chats_AspNetUsers_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Chats_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FeedbackComplaints",
                columns: table => new
                {
                    FeedbackComplaintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    AdminReply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackComplaints", x => x.FeedbackComplaintId);
                    table.ForeignKey(
                        name: "FK_FeedbackComplaints_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeedbackComplaints_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    HouseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BlockName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LotNumber = table.Column<int>(type: "int", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    IsOccupied = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.HouseId);
                    table.ForeignKey(
                        name: "FK_Houses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Polls",
                columns: table => new
                {
                    PollId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatorId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polls", x => x.PollId);
                    table.ForeignKey(
                        name: "FK_Polls_AspNetUsers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservation_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservation_Facility_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facility",
                        principalColumn: "FacilityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceStaffAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceRequestId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    IsUnavailable = table.Column<bool>(type: "bit", nullable: false),
                    AssignedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AcceptedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceStaffAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceStaffAssignments_AspNetUsers_StaffId",
                        column: x => x.StaffId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StaffProfiles",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Department = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActiveEmployee = table.Column<bool>(type: "bit", nullable: false),
                    IsAlsoHomeOwner = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    EmergencyContactName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    EmergencyContactNumber = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    EmergencyContactRelation = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    IsFired = table.Column<bool>(type: "bit", nullable: true),
                    AccountCreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountCreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffProfiles", x => x.StaffId);
                    table.ForeignKey(
                        name: "FK_StaffProfiles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VehicleGatepasses",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehiclePlateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: true),
                    IsRejected = table.Column<bool>(type: "bit", nullable: true),
                    ApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VehicleImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RejectionReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QRCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GatePassIssuedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GatePassExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleGatepasses", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_VehicleGatepasses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitorGatepasses",
                columns: table => new
                {
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VisitorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumberOfVisitors = table.Column<int>(type: "int", nullable: true),
                    VehicleType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VehiclePlateNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    VehicleColor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GatePassIssuedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GatePassExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: true),
                    IsRejected = table.Column<bool>(type: "bit", nullable: true),
                    ApprovalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorGatepasses", x => x.VisitorId);
                    table.ForeignKey(
                        name: "FK_VisitorGatepasses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillAssignment",
                columns: table => new
                {
                    BillAssignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BillId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_BillAssignment", x => x.BillAssignmentId);
                    table.ForeignKey(
                        name: "FK_BillAssignment_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BillAssignment_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "BillId");
                });

            migrationBuilder.CreateTable(
                name: "BillDetail",
                columns: table => new
                {
                    BillDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillId = table.Column<int>(type: "int", nullable: false),
                    BillItemsID = table.Column<int>(type: "int", nullable: false),
                    CustomAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ActualAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "BillPayment",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillPayment", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_BillPayment_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "BillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeownerProfiles",
                columns: table => new
                {
                    HomeownerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MoveInDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MoveOutDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsBanned = table.Column<bool>(type: "bit", nullable: true),
                    IsPromotedToStaff = table.Column<bool>(type: "bit", nullable: true),
                    IsPromotedToAdmin = table.Column<bool>(type: "bit", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HouseModelHouseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeownerProfiles", x => x.HomeownerId);
                    table.ForeignKey(
                        name: "FK_HomeownerProfiles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HomeownerProfiles_Houses_HouseModelHouseId",
                        column: x => x.HouseModelHouseId,
                        principalTable: "Houses",
                        principalColumn: "HouseId");
                });

            migrationBuilder.CreateTable(
                name: "PollQuestions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    QuestionType = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    PollId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PollQuestions", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_PollQuestions_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "PollId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId");
                });

            migrationBuilder.CreateTable(
                name: "Reactions",
                columns: table => new
                {
                    ReactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactions", x => x.ReactionId);
                    table.ForeignKey(
                        name: "FK_Reactions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reactions_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId");
                });

            migrationBuilder.CreateTable(
                name: "ServiceRequests",
                columns: table => new
                {
                    ServiceRequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Urgency = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Schedule = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RejectedReason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RejectedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CancelReason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CancelledOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RequestTypeId = table.Column<int>(type: "int", nullable: false),
                    HomeownerId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRequests", x => x.ServiceRequestId);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_HomeownerProfiles_HomeownerId",
                        column: x => x.HomeownerId,
                        principalTable: "HomeownerProfiles",
                        principalColumn: "HomeownerId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_RequestTypes_RequestTypeId",
                        column: x => x.RequestTypeId,
                        principalTable: "RequestTypes",
                        principalColumn: "RequestTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceRequests_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionOptions",
                columns: table => new
                {
                    OptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OptionText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionOptions", x => x.OptionId);
                    table.ForeignKey(
                        name: "FK_QuestionOptions_PollQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "PollQuestions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PollResponses",
                columns: table => new
                {
                    ResponseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextResponse = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    SelectedOptionId = table.Column<int>(type: "int", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    PollId = table.Column<int>(type: "int", nullable: false),
                    RespondentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsAnonymous = table.Column<bool>(type: "bit", nullable: false),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PollResponses", x => x.ResponseId);
                    table.ForeignKey(
                        name: "FK_PollResponses_AspNetUsers_RespondentId",
                        column: x => x.RespondentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PollResponses_PollQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "PollQuestions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PollResponses_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "PollId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PollResponses_QuestionOptions_SelectedOptionId",
                        column: x => x.SelectedOptionId,
                        principalTable: "QuestionOptions",
                        principalColumn: "OptionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "HomeOwner", "HOMEOWNER" },
                    { "3", null, "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AdminProfilesAdminId", "BillAssignmentModelBillAssignmentId", "Bio", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FacebookProfile", "FirstName", "Gender", "HomeownerProfilesHomeownerId", "IsActiveUser", "IsApproved", "IsBirthdayPublic", "IsGenderPublic", "LastName", "LinkedInProfile", "LockoutEnabled", "LockoutEnd", "MakeFacebookPublic", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "ProfilePicturePath", "SecurityStamp", "StaffProfilesStaffId", "TwitterProfile", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "100", 0, null, null, null, "6603fab0-2eb9-4ead-9a28-de92d0ed01fd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "elon.musk@example.com", true, null, "Elon", null, null, true, false, false, false, "Musk", null, false, null, false, "ELON.MUSK@EXAMPLE.COM", "ELON.MUSK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPnlDr5pXMtgbNq2bPPdnIYvAY5y/XG2iKGjrnDskBMvrpAu76SSLH4c4LdzTUJOtw==", null, false, null, "wwwroot/images/picc.png", "e373f1c8-fdf3-4f80-8122-42240b9e8c29", null, null, false, "elon.musk@example.com" },
                    { "102", 0, null, null, null, "408a28c2-b8b6-4fa4-920d-02b45cb723aa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bill.gates@example.com", true, null, "Bill", null, null, true, false, false, false, "Gates", null, false, null, false, "BILL.GATES@EXAMPLE.COM", "BILL.GATES@EXAMPLE.COM", "AQAAAAIAAYagAAAAECENMOABzzKHeFfO6EQp1Z8dGueyv3a6n/6qdGj4963upH+5OaajxEkKQhDm/SsESQ==", null, false, null, null, "8e4c6cdd-79c5-48b9-bb48-7b203e69ae3a", null, null, false, "bill.gates@example.com" },
                    { "103", 0, null, null, null, "23b332ec-de59-40a0-92d3-c8c9c806e590", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mark.zuckerberg@example.com", true, null, "Mark", null, null, true, false, false, false, "Zuckerberg", null, false, null, false, "MARK.ZUCKERBERG@EXAMPLE.COM", "MARK.ZUCKERBERG@EXAMPLE.COM", "AQAAAAIAAYagAAAAECN3gspx6MyQ0sV/TwmURjia4IM6j6QAt73fe1QMNnVvUYZjw59bz8v5d8JaCb200w==", null, false, null, null, "efa63d30-fe61-4dde-9a93-3af5f86c06da", null, null, false, "mark.zuckerberg@example.com" },
                    { "104", 0, null, null, null, "7129f3b8-030c-4fc0-92fe-066c5ad32375", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sundar.pichai@example.com", true, null, "Sundar", null, null, true, false, false, false, "Pichai", null, false, null, false, "SUNDAR.PICHAI@EXAMPLE.COM", "SUNDAR.PICHAI@EXAMPLE.COM", "AQAAAAIAAYagAAAAELwH+0qmpmdIBhyiJoqkffmgMMcM1oPQff4mHWHLmCzsZJLWk4C58OBAmRFmh8E74g==", null, false, null, null, "73e22e5f-ac51-4efd-97cb-7e09c1cb9cd7", null, null, false, "sundar.pichai@example.com" },
                    { "105", 0, null, null, null, "2340c07d-b04f-4e64-9f5d-77f1db8379fe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tim.cook@example.com", true, null, "Tim", null, null, true, false, false, false, "Cook", null, false, null, false, "TIM.COOK@EXAMPLE.COM", "TIM.COOK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJA/V/lDAvjmUM7xlLM38rReXxjrjMwuAxrpKmKpXytSAz8usyRzuZXizrM3Ib6YUA==", null, false, null, null, "b3766192-06e4-4c20-9dee-146fb32cc61b", null, null, false, "tim.cook@example.com" },
                    { "106", 0, null, null, null, "0f96a4ad-2875-470a-876b-292888a97f74", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "satya.nadella@example.com", true, null, "Satya", null, null, true, false, false, false, "Nadella", null, false, null, false, "SATYA.NADELLA@EXAMPLE.COM", "SATYA.NADELLA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOaVL5ntU8z6iBDPPKoDH/xUmzQdd1zu9w/AroKsUOmI07/vSiYSHfXuSfcMMBdWog==", null, false, null, null, "051aecb0-c64e-4caf-bef5-a4ebc1c286e6", null, null, false, "satya.nadella@example.com" },
                    { "107", 0, null, null, null, "7b976c84-2092-4370-b118-b9b381439643", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jack.dorsey@example.com", true, null, "Jack", null, null, true, false, false, false, "Dorsey", null, false, null, false, "JACK.DORSEY@EXAMPLE.COM", "JACK.DORSEY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGIVSEJaLj0gIrOG9JnOhY6RSVVYUdqtHUxwMQYeuSZtsNqJFU9/wVDyitSFwj/5Gg==", null, false, null, null, "f0b2e005-ffe7-43c6-91cb-0494f7d73d93", null, null, false, "jack.dorsey@example.com" },
                    { "108", 0, null, null, null, "2260af81-c730-4f80-95fe-ba3a349a6eaa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "larry.page@example.com", true, null, "Larry", null, null, true, false, false, false, "Page", null, false, null, false, "LARRY.PAGE@EXAMPLE.COM", "LARRY.PAGE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPDLTebNUEt08VbDDtuBennTuxDsqSaZiQpuoHBKfHYxarEYmx1MyCoqziJWzrHt6A==", null, false, null, null, "5df13291-60e0-4626-94ce-24af6b64616a", null, null, false, "larry.page@example.com" },
                    { "109", 0, null, null, null, "5770c295-91ef-4ff9-9244-c57b77291a32", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sergey.brin@example.com", true, null, "Sergey", null, null, true, false, false, false, "Brin", null, false, null, false, "SERGEY.BRIN@EXAMPLE.COM", "SERGEY.BRIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIyC3yBfb6VdCA8bE+i4yMrS6YY8iz5NV6ecxA+9XvMR/pe7L3Thqs5exEnnXpXuRQ==", null, false, null, null, "db252cd8-73af-4e9b-a737-cdf0b0305bdb", null, null, false, "sergey.brin@example.com" },
                    { "110", 0, null, null, null, "e974c131-0e48-4e87-95a8-c84ffacf2b4a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "steve.jobs@example.com", true, null, "Steve", null, null, true, false, false, false, "Jobs", null, false, null, false, "STEVE.JOBS@EXAMPLE.COM", "STEVE.JOBS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAUh2W6ICN3S+k89GqO9+F0frKjVPdLUJtA3LpvuyrLDe4DMz+M8sujoEc4NbMOvnw==", null, false, null, null, "f20b050f-614e-4dd9-aaba-945400da284d", null, null, false, "steve.jobs@example.com" },
                    { "111", 0, null, null, null, "ba0d98f0-6183-460a-9aec-9e0196231b79", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sheryl.sandberg@example.com", true, null, "Sheryl", null, null, true, false, false, false, "Sandberg", null, false, null, false, "SHERYL.SANDBERG@EXAMPLE.COM", "SHERYL.SANDBERG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPSsDhpURP/NOvj9vjPOl/D52wDw5G7ENmkBZSkE9gIXRMhoHJX2lFtpqeQUyhnsng==", null, false, null, null, "324ff910-281c-438b-9563-d3a2761a5af8", null, null, false, "sheryl.sandberg@example.com" },
                    { "112", 0, null, null, null, "b722e8df-1c99-418b-87a5-a500b9b6696f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reed.hastings@example.com", true, null, "Reed", null, null, true, false, false, false, "Hastings", null, false, null, false, "REED.HASTINGS@EXAMPLE.COM", "REED.HASTINGS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPpsxDBu2VidW+durVq551uweT0GI4EmlO7Ll3xP0Cvzm6/gkUZuoBFpyBFteZhmfw==", null, false, null, null, "9b36321c-d4b8-4f3b-bbc7-8828670084f7", null, null, false, "reed.hastings@example.com" },
                    { "113", 0, null, null, null, "9dc61e5e-a3ff-48e9-859e-b6724cfa22ed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "marissa.mayer@example.com", true, null, "Marissa", null, null, true, false, false, false, "Mayer", null, false, null, false, "MARISSA.MAYER@EXAMPLE.COM", "MARISSA.MAYER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHyJBTFKfXC+CH3978t9scxejB8HnkRwYrC+8wmHD+QQYYZs0kLlLcDkjIvKigjMhw==", null, false, null, null, "77aadc5a-e35b-4cd4-ae82-b333d1be1772", null, null, false, "marissa.mayer@example.com" },
                    { "114", 0, null, null, null, "cebf5883-6196-4e7e-b9c7-9910fe959264", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "elizabeth.holmes@example.com", true, null, "Elizabeth", null, null, true, false, false, false, "Holmes", null, false, null, false, "ELIZABETH.HOLMES@EXAMPLE.COM", "ELIZABETH.HOLMES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO3oN/IScHxbi6/7xipfRatm7OQ8ZgsTj+Pm+3+Zq0zhVQ3L8hp3Axt5/XhXN5Zjsw==", null, false, null, null, "709c7520-e530-4ac6-99df-b7a50ffd7db1", null, null, false, "elizabeth.holmes@example.com" },
                    { "115", 0, null, null, null, "0ca92596-12ed-46ab-9c81-a362aa200847", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "susan.wojcicki@example.com", true, null, "Susan", null, null, true, false, false, false, "Wojcicki", null, false, null, false, "SUSAN.WOJCICKI@EXAMPLE.COM", "SUSAN.WOJCICKI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPk9ChySk3LOaFXGGom+A8PYrHgq/sTKONx/ewQ8lNZlnXmgFEl30tSPlX3BcAZr0w==", null, false, null, null, "9b34e839-0a60-46d3-b429-01de5398c642", null, null, false, "susan.wojcicki@example.com" },
                    { "116", 0, null, null, null, "b30d2332-62cf-446a-8ca6-020fe4cf29dc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tim.arnold@example.com", true, null, "Tim", null, null, true, false, false, false, "Arnold", null, false, null, false, "TIM.ARNOLD@EXAMPLE.COM", "TIM.ARNOLD@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB8vexJueF3kJCDmo0FjirnGErpPWeTe97Hv+eekIqiTvawvnE3Zt279zigyHIYVug==", null, false, null, null, "1ba3d786-8a0f-4ab4-87d5-b89885016609", null, null, false, "tim.arnold@example.com" },
                    { "117", 0, null, null, null, "60e282f2-908f-40ef-87e7-430dbd094d1d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.iger@example.com", true, null, "Bob", null, null, true, false, false, false, "Iger", null, false, null, false, "BOB.IGER@EXAMPLE.COM", "BOB.IGER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMjdMiSR/JGe4xGxKwmqA0M8thwII+WDgMxAnIybDUlB/mEv6PuDeTSNI10gC1x2VA==", null, false, null, null, "4ae8e462-5a55-41a2-be2e-aeb4b085734d", null, null, false, "bob.iger@example.com" },
                    { "118", 0, null, null, null, "df25a6e1-c3e3-4229-9067-3d6e556929cd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "larry.ellison@example.com", true, null, "Larry", null, null, true, false, false, false, "Ellison", null, false, null, false, "LARRY.ELLISON@EXAMPLE.COM", "LARRY.ELLISON@EXAMPLE.COM", "AQAAAAIAAYagAAAAELCkywiHuGAT7EGXZ6G9suNtAL/stGRc+QKCCbQdfhi3HEpvAjWoQ7ofR4YCUxw2kw==", null, false, null, null, "28862a65-84ad-4f8d-a8a6-d66fdc693637", null, null, false, "larry.ellison@example.com" },
                    { "119", 0, null, null, null, "68489eeb-35e9-44ce-9525-e85d442ad425", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "richard.branson@example.com", true, null, "Richard", null, null, true, false, false, false, "Branson", null, false, null, false, "RICHARD.BRANSON@EXAMPLE.COM", "RICHARD.BRANSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKpL7RSwQRRa5YjDVNmyWa7ZeNuhchE/MhBvxGDDIwvYJjYeZxth7nmfeJkJkfJH5w==", null, false, null, null, "243454a1-a5fd-4537-a4ef-cba4d8f2f6f6", null, null, false, "richard.branson@example.com" },
                    { "120", 0, null, null, null, "153d8cd4-277c-4cd0-9db0-8d4ecf505285", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jack.ma@example.com", true, null, "Jack", null, null, true, false, false, false, "Ma", null, false, null, false, "JACK.MA@EXAMPLE.COM", "JACK.MA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEK2DtsK9BLpcbVfJy56B9vkobXxVFXali9Tgx9bpxsIRirz3rDgWCOVAFfld/91AUw==", null, false, null, null, "525e484e-25a3-4057-b6fa-38b487723b9b", null, null, false, "jack.ma@example.com" },
                    { "121", 0, null, null, null, "86f7fb68-554f-46f2-8f45-a50ffd901a2f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "warren.buffett@example.com", true, null, "Warren", null, null, true, false, false, false, "Buffett", null, false, null, false, "WARREN.BUFFETT@EXAMPLE.COM", "WARREN.BUFFETT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP++bpsDB6fq4QUIkoh4fBM/LmIXeA+AQCyeZtIVmf711RCT2ah2laBvlOq2P8DeJQ==", null, false, null, null, "dc7c63bc-042a-4e70-9b60-8c0e53613714", null, null, false, "warren.buffett@example.com" },
                    { "122", 0, null, null, null, "e948401c-8299-460b-a82a-20cec464c818", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mary.barrett@example.com", true, null, "Mary", null, null, true, false, false, false, "Barrett", null, false, null, false, "MARY.BARRETT@EXAMPLE.COM", "MARY.BARRETT@EXAMPLE.COM", "AQAAAAIAAYagAAAAELTJQbcSacbXo3OEppFS795FEo/CA++bHnhihexsV79wUtX4ZfNu7TV+nQqQ2V+ESw==", null, false, null, null, "eef65578-944a-4cd7-a305-fbe55550d45d", null, null, false, "mary.barrett@example.com" },
                    { "123", 0, null, null, null, "5b5c8ff8-951e-4c97-a20c-9d713d8a50e7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ginni.rometty@example.com", true, null, "Ginni", null, null, true, false, false, false, "Rometty", null, false, null, false, "GINNI.ROMETTY@EXAMPLE.COM", "GINNI.ROMETTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIk2M21szeOsP/wEw9Vg+DFjcCHWSA8SoG4eTh9xYNydqo8q16EADG+iBKuYRHZHrA==", null, false, null, null, "47e05843-d50d-4d9a-bee9-168bf14aa280", null, null, false, "ginni.rometty@example.com" },
                    { "124", 0, null, null, null, "080d3b5f-1d43-4b4f-98e4-a4b5ce363398", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mark.benioff@example.com", true, null, "Mark", null, null, true, false, false, false, "Benioff", null, false, null, false, "MARK.BENIOFF@EXAMPLE.COM", "MARK.BENIOFF@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHZ/QesbImp3qUZ2xdXtQj1ExEBlECqGUmKLeRkOq1JalAgr77PsEBeIi2TBaxze0w==", null, false, null, null, "752d0210-df20-4b51-a65b-5b7dfe9b70d7", null, null, false, "mark.benioff@example.com" },
                    { "125", 0, null, null, null, "492ad950-1618-4b9b-affb-2cc7c70f7da0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kevin.systrom@example.com", true, null, "Kevin", null, null, true, false, false, false, "Systrom", null, false, null, false, "KEVIN.SYSTROM@EXAMPLE.COM", "KEVIN.SYSTROM@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEAqIC+h93fKt+uMYzdWWJCh0mfp98JKh2qIR+uuEuWYv4/sLSYC5u+prUMqzxpE6Q==", null, false, null, null, "cee1d36e-ab8c-4127-b313-a281e0804d0f", null, null, false, "kevin.systrom@example.com" },
                    { "126", 0, null, null, null, "64a3f51b-44fb-4a2a-b82c-119c50986029", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "evan.spiegel@example.com", true, null, "Evan", null, null, true, false, false, false, "Spiegel", null, false, null, false, "EVAN.SPIEGEL@EXAMPLE.COM", "EVAN.SPIEGEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGGsdIFp/eXo0mZcGq4X3amnnQTVDrsCpdJ5pqeuTQ/n35QmYajv6kl1ulWf0lASHw==", null, false, null, null, "1ca397ef-b289-4a03-94ba-b17d47a18383", null, null, false, "evan.spiegel@example.com" },
                    { "127", 0, null, null, null, "9fe35a3d-f73a-487c-9918-b41b1d605f5f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jan.koum@example.com", true, null, "Jan", null, null, true, false, false, false, "Koum", null, false, null, false, "JAN.KOUM@EXAMPLE.COM", "JAN.KOUM@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ/NSoCj/6eM7+TKnUSWal/Mrx4haIpNIMEtr3wRMnoX1rofa7bMH1DEAfzZuRN/qw==", null, false, null, null, "c3e4714d-e0c4-4169-b2f1-5f5140ddc644", null, null, false, "jan.koum@example.com" },
                    { "128", 0, null, null, null, "1a5a4fb6-5c94-495a-abdc-d7461e30bd7c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "janice.fang@example.com", true, null, "Janice", null, null, true, false, false, false, "Fang", null, false, null, false, "JANICE.FANG@EXAMPLE.COM", "JANICE.FANG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIkG6ltX8XVBRPMEDttiYh+8YuW5HraOI3Y4zKNjgGViWvP84prE8DisObgnyUCXtA==", null, false, null, null, "aa691f6b-c369-4bec-a4ad-753765c1984d", null, null, false, "janice.fang@example.com" },
                    { "129", 0, null, null, null, "144b62cf-9fbb-47fd-b302-ef92563588cb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sergey.gladkikh@example.com", true, null, "Sergey", null, null, true, false, false, false, "Gladkikh", null, false, null, false, "SERGEY.GLADKIKH@EXAMPLE.COM", "SERGEY.GLADKIKH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFi0yoIEHmIP5vkYyzV7R4bdJifTLkRSN/4eAFjEHeMErI05LFzSW36zG21V30x68w==", null, false, null, null, "3b128011-8fc7-4b31-afcf-9078fcae468b", null, null, false, "sergey.gladkikh@example.com" },
                    { "130", 0, null, null, null, "b6d2196f-3b3d-48cd-b53b-f458fa1e14fb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tony.hsieh@example.com", true, null, "Tony", null, null, true, false, false, false, "Hsieh", null, false, null, false, "TONY.HSIEH@EXAMPLE.COM", "TONY.HSIEH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ1M5ZHAFbkhxe7rx5z9UGpBByDPJZzYG7W5ZhAUTMwSzDcRRfAD8/U4HweS0SPPgA==", null, false, null, null, "1ce215ff-6260-40ad-b20b-72d2550f1362", null, null, false, "tony.hsieh@example.com" },
                    { "131", 0, null, null, null, "93e8a123-e5a1-4631-bd7f-52fad1090f06", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "richard.hyne@example.com", true, null, "Richard", null, null, true, false, false, false, "Hyne", null, false, null, false, "RICHARD.HYNE@EXAMPLE.COM", "RICHARD.HYNE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH9+PIVk9vYzorYIetN/iUGwCSIHseCKQ011gXxxNSW632qufTAvBcOpWox1Ae+sHA==", null, false, null, null, "d5baad92-ffeb-48ee-8115-971fbcac0ed2", null, null, false, "richard.hyne@example.com" },
                    { "132", 0, null, null, null, "fdc83ef4-0930-49d1-bc9e-2a538595ee9b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "peter.thiel@example.com", true, null, "Peter", null, null, true, false, false, false, "Thiel", null, false, null, false, "PETER.THIEL@EXAMPLE.COM", "PETER.THIEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGh1A276oj5m7JU0zx8my/dqroze0vEm6iv8U0RepdytNuqwlX+LrhgayKJGGmbweQ==", null, false, null, null, "d499e04f-cf57-4d70-83a3-022466fae7eb", null, null, false, "peter.thiel@example.com" },
                    { "133", 0, null, null, null, "38a83f09-6c14-43a8-ade9-7aee2890b416", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "steve.wozniak@example.com", true, null, "Steve", null, null, true, false, false, false, "Wozniak", null, false, null, false, "STEVE.WOZNIAK@EXAMPLE.COM", "STEVE.WOZNIAK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBf7vprjTodmV7R0bUPzb1ak/++ONF/3qnu5FC3uGp0pei3V4mp0XZHbWHResBiGeQ==", null, false, null, null, "ca515280-8087-46f2-864b-4e2faf06fc46", null, null, false, "steve.wozniak@example.com" },
                    { "134", 0, null, null, null, "73a820da-3c6c-4ce8-a689-f37776f080a3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.carmack@example.com", true, null, "John", null, null, true, false, false, false, "Carmack", null, false, null, false, "JOHN.CARMACK@EXAMPLE.COM", "JOHN.CARMACK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAv/r6kpAPRimActVATKWJsEbWU2XrNmdEItlCxj2DqvAEnE8kTCvzhkY30Ve2e2Sw==", null, false, null, null, "f6df53ac-f2c5-4d0e-a174-12e9fbe2230e", null, null, false, "john.carmack@example.com" },
                    { "135", 0, null, null, null, "0c14898c-ef6b-471e-abd9-aa416f588550", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mike.zyda@example.com", true, null, "Mike", null, null, true, false, false, false, "Zyda", null, false, null, false, "MIKE.ZYDA@EXAMPLE.COM", "MIKE.ZYDA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKVPRfqDtbciCGdnjnIH7zmbGv6a+leCnc8bgJ9yXvR+XRCR/Wz92NpvDMdZ4i5Lvw==", null, false, null, null, "a5becf59-4a25-4224-9d74-62d5f4deab07", null, null, false, "mike.zyda@example.com" },
                    { "136", 0, null, null, null, "d63d2b09-dca5-49c5-9f4e-433885b4130f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cheryl.sandberg@example.com", true, null, "Cheryl", null, null, true, false, false, false, "Sandberg", null, false, null, false, "CHERYL.SANDBERG@EXAMPLE.COM", "CHERYL.SANDBERG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHzoCjuI31L+yOItg7uZin+xAoqzMoUVnEeE34tpzpzJiCJOYIntOtEshtds5FZ21A==", null, false, null, null, "789aa6b6-aed7-42ec-9c2f-cf081b9ba329", null, null, false, "cheryl.sandberg@example.com" },
                    { "137", 0, null, null, null, "7c156c0e-ca8b-4497-936d-5b3a80a68b80", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "karen.smith@example.com", true, null, "Karen", null, null, true, false, false, false, "Smith", null, false, null, false, "KAREN.SMITH@EXAMPLE.COM", "KAREN.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKi+J753+m6/CHyzXlA1O/Vyhr1wjNBWP04zKLxQGqN6XOdAriS2YCygR4lsljBujQ==", null, false, null, null, "e4ec0c86-5850-47cc-93fc-8f9a8b88e3e4", null, null, false, "karen.smith@example.com" },
                    { "138", 0, null, null, null, "9f375428-12c5-426a-9a69-d8595bd3c978", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.lee@example.com", true, null, "David", null, null, true, false, false, false, "Lee", null, false, null, false, "DAVID.LEE@EXAMPLE.COM", "DAVID.LEE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPiDp+ygQR8IKshpgy91Zz30rA+OlMWgfRESJ3n8YSyD861UInwOY0wIedIvSrehAg==", null, false, null, null, "a928c3a6-bec9-4cf8-b055-82e7b1825a32", null, null, false, "david.lee@example.com" },
                    { "139", 0, null, null, null, "1b9e02dd-8b2a-4523-aa1b-106ebebc11c6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "james.taylor@example.com", true, null, "James", null, null, true, false, false, false, "Taylor", null, false, null, false, "JAMES.TAYLOR@EXAMPLE.COM", "JAMES.TAYLOR@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPlTxqi8Eyci4zi7rw5sx9h0rVmZKONiS3gWgiapqKutc90sO2dWTW0hrZO751773A==", null, false, null, null, "e3dc6527-ecc5-4c14-8f09-ff92da71f1b0", null, null, false, "james.taylor@example.com" }
                });

            migrationBuilder.InsertData(
                table: "BillItems",
                columns: new[] { "BillItemsID", "AddedBy", "AddedOn", "Amount", "BillItemsModelBillItemsID", "Description", "IsDeleted", "PaymentDuration", "PaymentName", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 4, 14, 18, 14, 25, 252, DateTimeKind.Utc).AddTicks(2843), 3500.00m, null, "Monthly HOA dues covering maintenance, security, and amenities.", false, "Monthly", "Homeowners Association (HOA) Fees", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(2025, 4, 14, 18, 14, 25, 252, DateTimeKind.Utc).AddTicks(2854), 100.00m, null, "Monthly water consumption charges.", false, "Monthly", "Water Bill", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(2025, 4, 14, 18, 14, 25, 252, DateTimeKind.Utc).AddTicks(2856), 2500.00m, null, "Monthly payment for electricity consumption.", false, "Monthly", "Electricity Bill", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, new DateTime(2025, 4, 14, 18, 14, 25, 252, DateTimeKind.Utc).AddTicks(2857), 300.00m, null, "Monthly fee for waste disposal services.", false, "Monthly", "Garbage Collection Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, new DateTime(2025, 4, 14, 18, 14, 25, 252, DateTimeKind.Utc).AddTicks(2858), 1500.00m, null, "Monthly fee for subdivision security services.", false, "Monthly", "Security Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, new DateTime(2025, 4, 14, 18, 14, 25, 252, DateTimeKind.Utc).AddTicks(2859), 500.00m, null, "Monthly fee for streetlight maintenance.", false, "Monthly", "Street Lighting Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, new DateTime(2025, 4, 14, 18, 14, 25, 252, DateTimeKind.Utc).AddTicks(2860), 800.00m, null, "Annual fee for maintaining the clubhouse and shared spaces.", false, "Yearly", "Clubhouse Maintenance Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, new DateTime(2025, 4, 14, 18, 14, 25, 252, DateTimeKind.Utc).AddTicks(2861), 5000.00m, null, "Annual contribution for property tax remittance.", false, "Yearly", "Property Tax Contribution", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, new DateTime(2025, 4, 14, 18, 14, 25, 252, DateTimeKind.Utc).AddTicks(2862), 1200.00m, null, "Quarterly contribution for major subdivision repairs.", false, "Quarterly", "Sinking Fund Contribution", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, new DateTime(2025, 4, 14, 18, 14, 25, 252, DateTimeKind.Utc).AddTicks(2864), 600.00m, null, "Quarterly fee for pest control services in the subdivision.", false, "Quarterly", "Pest Control Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, new DateTime(2025, 4, 14, 18, 14, 25, 252, DateTimeKind.Utc).AddTicks(2865), 1000.00m, null, "Annual fee for road maintenance and repairs.", false, "Yearly", "Road Maintenance Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RequestTypes",
                columns: new[] { "RequestTypeId", "AssignedDepartment", "Description", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, 0, "Request for pool maintenance.", true, "Pool Cleaning" },
                    { 2, 1, "Report or ask about lost items.", true, "Lost and Found Inquiry" },
                    { 3, 2, "Concerns about billing and payments.", true, "Billing Issue" },
                    { 4, 3, "Report issues with internet connectivity.", true, "Internet Issue" },
                    { 5, 4, "Request lawn maintenance services.", true, "Lawn Mowing" },
                    { 6, 5, "Report plumbing issues like leaks.", true, "Plumbing Repair" },
                    { 7, 6, "Report security concerns or suspicious activity.", true, "Suspicious Activity" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusId", "StatusName" },
                values: new object[,]
                {
                    { 1, "Available" },
                    { 2, "Unavailable" },
                    { 3, "Pending" },
                    { 4, "In Progress" },
                    { 5, "Resolved" },
                    { 6, "Closed" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "100" },
                    { "3", "102" },
                    { "3", "103" },
                    { "3", "104" },
                    { "3", "105" },
                    { "3", "106" },
                    { "3", "107" },
                    { "3", "108" },
                    { "3", "109" },
                    { "3", "110" },
                    { "2", "111" },
                    { "2", "112" },
                    { "2", "113" },
                    { "2", "114" },
                    { "2", "115" },
                    { "2", "116" },
                    { "2", "117" },
                    { "2", "118" },
                    { "2", "119" },
                    { "2", "120" },
                    { "2", "121" },
                    { "2", "122" },
                    { "2", "123" },
                    { "2", "124" },
                    { "2", "125" },
                    { "2", "126" },
                    { "2", "127" },
                    { "2", "128" },
                    { "2", "129" },
                    { "2", "130" },
                    { "2", "131" },
                    { "2", "132" },
                    { "2", "133" },
                    { "2", "134" },
                    { "2", "135" },
                    { "2", "136" },
                    { "2", "137" },
                    { "2", "138" },
                    { "2", "139" }
                });

            migrationBuilder.InsertData(
                table: "HomeownerProfiles",
                columns: new[] { "HomeownerId", "ApprovedBy", "ApprovedOn", "HouseModelHouseId", "IsApproved", "IsBanned", "IsPromotedToAdmin", "IsPromotedToStaff", "MoveInDate", "MoveOutDate", "RegisteredOn", "UserId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7226), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7224), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7225), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7226), "111" },
                    { 2, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7231), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7230), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7230), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7231), "112" },
                    { 3, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7239), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7232), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7238), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7239), "113" },
                    { 4, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7241), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7240), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7240), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7241), "114" },
                    { 5, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7243), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7242), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7242), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7243), "115" },
                    { 6, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7245), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7244), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7244), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7245), "116" },
                    { 7, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7247), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7246), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7246), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7247), "117" },
                    { 8, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7249), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7248), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7248), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7249), "118" },
                    { 9, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7251), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7250), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7250), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7251), "119" },
                    { 10, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7253), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7252), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7252), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7253), "120" },
                    { 11, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7255), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7254), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7254), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7255), "121" },
                    { 12, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7257), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7256), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7256), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7257), "122" },
                    { 13, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7259), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7258), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7258), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7259), "123" },
                    { 14, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7261), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7260), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7260), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7261), "124" },
                    { 15, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7262), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7262), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7262), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7263), "125" },
                    { 16, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7264), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7264), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7264), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7265), "126" },
                    { 17, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7266), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7265), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7266), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7267), "127" },
                    { 18, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7268), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7267), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7268), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7269), "128" },
                    { 19, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7270), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7269), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7270), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7271), "129" },
                    { 20, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7272), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7271), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7272), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7273), "130" },
                    { 21, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7274), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7273), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7274), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7274), "131" },
                    { 22, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7276), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7275), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7276), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7276), "132" },
                    { 23, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7278), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7277), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7277), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7278), "133" },
                    { 24, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7280), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7279), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7279), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7280), "134" },
                    { 25, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7282), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7281), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7281), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7282), "135" },
                    { 26, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7284), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7283), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7283), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7284), "136" },
                    { 27, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7287), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7286), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7286), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7287), "137" },
                    { 28, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7289), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7288), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7288), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7289), "138" },
                    { 29, null, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7290), null, true, false, false, false, new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7290), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7290), new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7291), "139" }
                });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "HouseId", "BlockName", "IsOccupied", "LotNumber", "StreetName", "UserId" },
                values: new object[,]
                {
                    { 1, "AspenHeight", true, 1, "Ashwood Lane", "100" },
                    { 2, "AspenHeight", true, 2, "Ashwood Lane", "102" },
                    { 3, "AspenHeight", true, 3, "Ashwood Lane", "103" },
                    { 4, "AspenHeight", true, 4, "Ashwood Lane", "104" },
                    { 5, "AspenHeight", true, 5, "Ashwood Lane", "105" },
                    { 6, "BirchHaven", true, 1, "Birchwood Avenue", "106" },
                    { 7, "BirchHaven", true, 2, "Birchwood Avenue", "107" },
                    { 8, "BirchHaven", true, 3, "Birchwood Avenue", "108" },
                    { 9, "BirchHaven", true, 4, "Birchwood Avenue", "109" },
                    { 10, "BirchHaven", true, 5, "Birchwood Avenue", "110" },
                    { 11, "CedarCrest", true, 1, "Cedar Hollow Road", "111" },
                    { 12, "CedarCrest", true, 2, "Cedar Hollow Road", "112" },
                    { 13, "CedarCrest", true, 3, "Cedar Hollow Road", "113" },
                    { 14, "CedarCrest", true, 4, "Cedar Hollow Road", "114" },
                    { 15, "CedarCrest", true, 5, "Cedar Hollow Road", "115" },
                    { 16, "ChestnutGrove", true, 1, "Chestnut Boulevard", "116" },
                    { 17, "ChestnutGrove", true, 2, "Chestnut Boulevard", "117" },
                    { 18, "ChestnutGrove", true, 3, "Chestnut Boulevard", "118" },
                    { 19, "ChestnutGrove", true, 4, "Chestnut Boulevard", "119" },
                    { 20, "ChestnutGrove", true, 5, "Chestnut Boulevard", "120" },
                    { 21, "CrystalLake", true, 1, "Crystal Drive", "121" },
                    { 22, "CrystalLake", true, 2, "Crystal Drive", "122" },
                    { 23, "CrystalLake", true, 3, "Crystal Drive", "123" },
                    { 24, "CrystalLake", true, 4, "Crystal Drive", "124" },
                    { 25, "CrystalLake", true, 5, "Crystal Drive", "125" },
                    { 26, "ElmwoodBlock", true, 1, "Elmwood Drive", "126" },
                    { 27, "ElmwoodBlock", true, 2, "Elmwood Drive", "127" },
                    { 28, "ElmwoodBlock", true, 3, "Elmwood Drive", "128" },
                    { 29, "ElmwoodBlock", true, 4, "Elmwood Drive", "129" },
                    { 30, "ElmwoodBlock", true, 5, "Elmwood Drive", "130" }
                });

            migrationBuilder.InsertData(
                table: "StaffProfiles",
                columns: new[] { "StaffId", "AccountCreatedBy", "AccountCreatedOn", "Address", "Department", "EmergencyContactName", "EmergencyContactNumber", "EmergencyContactRelation", "HireDate", "IsActiveEmployee", "IsAlsoHomeOwner", "IsDeleted", "IsFired", "Position", "Salary", "UpdatedBy", "UpdatedOn", "UserId" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7071), "123 Main St", 6, "Jane Doe", "1234567890", "Spouse", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Security Officer", 25000.00m, null, null, "100" },
                    { 2, "admin", new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7086), "456 Oak St", 5, "John Smith", "0987654321", "Brother", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Maintenance Supervisor", 30000.00m, null, null, "102" },
                    { 3, "admin", new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7094), "789 Pine St", 3, "Alice Brown", "5678901234", "Sister", new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "System Administrator", 35000.00m, null, null, "103" },
                    { 4, "admin", new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7099), "987 Cedar St", 2, "Bob White", "2345678901", "Father", new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Finance Manager", 40000.00m, null, null, "104" },
                    { 5, "admin", new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7107), "654 Birch St", 0, "Chris Green", "3456789012", "Friend", new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Amenities Coordinator", 28000.00m, null, null, "105" },
                    { 6, "admin", new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7112), "321 Maple St", 1, "Diana Blue", "4567890123", "Cousin", new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Customer Service Representative", 26000.00m, null, null, "106" },
                    { 7, "admin", new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7117), "159 Elm St", 4, "Evan Red", "5678901234", "Uncle", new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Head Gardener", 27000.00m, null, null, "107" },
                    { 8, "admin", new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7122), "123 Main St", 6, "Jane Doe", "1234567890", "Spouse", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Security Officer", 25000.00m, null, null, "108" },
                    { 9, "admin", new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7139), "456 Oak St", 5, "John Smith", "0987654321", "Brother", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Maintenance Supervisor", 30000.00m, null, null, "109" },
                    { 10, "admin", new DateTime(2025, 4, 14, 18, 14, 26, 955, DateTimeKind.Utc).AddTicks(7154), "789 Pine St", 3, "Alice Brown", "5678901234", "Sister", new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "System Administrator", 35000.00m, null, null, "110" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminProfiles_UserId",
                table: "AdminProfiles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AdminProfilesAdminId",
                table: "AspNetUsers",
                column: "AdminProfilesAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BillAssignmentModelBillAssignmentId",
                table: "AspNetUsers",
                column: "BillAssignmentModelBillAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_HomeownerProfilesHomeownerId",
                table: "AspNetUsers",
                column: "HomeownerProfilesHomeownerId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_StaffProfilesStaffId",
                table: "AspNetUsers",
                column: "StaffProfilesStaffId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BillAccounts_UserId",
                table: "BillAccounts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BillAssignment_BillId",
                table: "BillAssignment",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_BillAssignment_UserId",
                table: "BillAssignment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetail_BillId",
                table: "BillDetail",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetail_BillItemsID",
                table: "BillDetail",
                column: "BillItemsID");

            migrationBuilder.CreateIndex(
                name: "IX_BillItems_BillItemsModelBillItemsID",
                table: "BillItems",
                column: "BillItemsModelBillItemsID");

            migrationBuilder.CreateIndex(
                name: "IX_BillPayment_BillId",
                table: "BillPayment",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_UserId",
                table: "Bills",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BillTransactions_BillItemsId",
                table: "BillTransactions",
                column: "BillItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_BillTransactions_UserId",
                table: "BillTransactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ApplicationUserId",
                table: "Chats",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ApplicationUserId1",
                table: "Chats",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_RecipientId",
                table: "Chats",
                column: "RecipientId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_SenderId",
                table: "Chats",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackComplaints_StatusId",
                table: "FeedbackComplaints",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackComplaints_UserId",
                table: "FeedbackComplaints",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeownerProfiles_HouseModelHouseId",
                table: "HomeownerProfiles",
                column: "HouseModelHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeownerProfiles_UserId",
                table: "HomeownerProfiles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_BlockName_LotNumber_StreetName",
                table: "Houses",
                columns: new[] { "BlockName", "LotNumber", "StreetName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Houses_UserId",
                table: "Houses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PollQuestions_PollId",
                table: "PollQuestions",
                column: "PollId");

            migrationBuilder.CreateIndex(
                name: "IX_PollResponses_PollId",
                table: "PollResponses",
                column: "PollId");

            migrationBuilder.CreateIndex(
                name: "IX_PollResponses_QuestionId",
                table: "PollResponses",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_PollResponses_RespondentId",
                table: "PollResponses",
                column: "RespondentId");

            migrationBuilder.CreateIndex(
                name: "IX_PollResponses_SelectedOptionId",
                table: "PollResponses",
                column: "SelectedOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Polls_CreatorId",
                table: "Polls",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOptions_QuestionId",
                table: "QuestionOptions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_PostId",
                table: "Reactions",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_UserId",
                table: "Reactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_FacilityId",
                table: "Reservation",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_UserId",
                table: "Reservation",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_HomeownerId",
                table: "ServiceRequests",
                column: "HomeownerId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_RequestTypeId",
                table: "ServiceRequests",
                column: "RequestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_StatusId",
                table: "ServiceRequests",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRequests_UserId",
                table: "ServiceRequests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceStaffAssignments_StaffId",
                table: "ServiceStaffAssignments",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffProfiles_UserId",
                table: "StaffProfiles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleGatepasses_UserId",
                table: "VehicleGatepasses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorGatepasses_UserId",
                table: "VisitorGatepasses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminProfiles_AspNetUsers_UserId",
                table: "AdminProfiles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BillAssignment_BillAssignmentModelBillAssignmentId",
                table: "AspNetUsers",
                column: "BillAssignmentModelBillAssignmentId",
                principalTable: "BillAssignment",
                principalColumn: "BillAssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_HomeownerProfiles_HomeownerProfilesHomeownerId",
                table: "AspNetUsers",
                column: "HomeownerProfilesHomeownerId",
                principalTable: "HomeownerProfiles",
                principalColumn: "HomeownerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_StaffProfiles_StaffProfilesStaffId",
                table: "AspNetUsers",
                column: "StaffProfilesStaffId",
                principalTable: "StaffProfiles",
                principalColumn: "StaffId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminProfiles_AspNetUsers_UserId",
                table: "AdminProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_BillAssignment_AspNetUsers_UserId",
                table: "BillAssignment");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_AspNetUsers_UserId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeownerProfiles_AspNetUsers_UserId",
                table: "HomeownerProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Houses_AspNetUsers_UserId",
                table: "Houses");

            migrationBuilder.DropForeignKey(
                name: "FK_StaffProfiles_AspNetUsers_UserId",
                table: "StaffProfiles");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BillAccounts");

            migrationBuilder.DropTable(
                name: "BillDetail");

            migrationBuilder.DropTable(
                name: "BillPayment");

            migrationBuilder.DropTable(
                name: "BillTransactions");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "FeedbackComplaints");

            migrationBuilder.DropTable(
                name: "PollResponses");

            migrationBuilder.DropTable(
                name: "Reactions");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "ServiceRequests");

            migrationBuilder.DropTable(
                name: "ServiceStaffAssignments");

            migrationBuilder.DropTable(
                name: "VehicleGatepasses");

            migrationBuilder.DropTable(
                name: "VisitorGatepasses");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "BillItems");

            migrationBuilder.DropTable(
                name: "QuestionOptions");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Facility");

            migrationBuilder.DropTable(
                name: "RequestTypes");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "PollQuestions");

            migrationBuilder.DropTable(
                name: "Polls");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AdminProfiles");

            migrationBuilder.DropTable(
                name: "BillAssignment");

            migrationBuilder.DropTable(
                name: "HomeownerProfiles");

            migrationBuilder.DropTable(
                name: "StaffProfiles");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Houses");
        }
    }
}
