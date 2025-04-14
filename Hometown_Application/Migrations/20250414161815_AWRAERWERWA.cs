using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class AWRAERWERWA : Migration
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Urgency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Schedule = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RejectedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RejectedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CancelReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CancelledOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    RequestTypeId = table.Column<int>(type: "int", nullable: false),
                    HomeownerId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRequests", x => x.ServiceRequestId);
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
                    { "100", 0, null, null, null, "95d1f026-f9e8-4e71-a9de-71d0ef33e939", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "elon.musk@example.com", true, null, "Elon", null, null, true, false, false, false, "Musk", null, false, null, false, "ELON.MUSK@EXAMPLE.COM", "ELON.MUSK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEI7P7mQyxXIb6+Cg93vH106YfsQug2+26a/xDPi+at5HD3YNL8smHE2ijC/XzEeeA==", null, false, null, "wwwroot/images/picc.png", "6e306008-8844-43c5-a206-966d1bd6ba25", null, null, false, "elon.musk@example.com" },
                    { "102", 0, null, null, null, "40f84934-9355-4669-a62b-b483678a6001", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bill.gates@example.com", true, null, "Bill", null, null, true, false, false, false, "Gates", null, false, null, false, "BILL.GATES@EXAMPLE.COM", "BILL.GATES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJqM0Yr5E7zWHqs/cLco3TNK01bfhc/OWCR4UDxRUayQnb8k1pqP8MBiAz981Q4csg==", null, false, null, null, "3cff7e12-db70-4832-9d15-b707b75f1fae", null, null, false, "bill.gates@example.com" },
                    { "103", 0, null, null, null, "443ea1a1-9ed4-4b10-987f-ce3e56ed70d3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mark.zuckerberg@example.com", true, null, "Mark", null, null, true, false, false, false, "Zuckerberg", null, false, null, false, "MARK.ZUCKERBERG@EXAMPLE.COM", "MARK.ZUCKERBERG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAohEX92w20VB3kzMpUNpKgYkh1JZ4pqJpcJdRjm9Nd4mrJXWE7UtXpwwL93WLCBng==", null, false, null, null, "8cb9656d-1077-451f-8d2c-bb01b81d9860", null, null, false, "mark.zuckerberg@example.com" },
                    { "104", 0, null, null, null, "3c804aeb-df5a-4488-a4b6-08f4a6c37ae5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sundar.pichai@example.com", true, null, "Sundar", null, null, true, false, false, false, "Pichai", null, false, null, false, "SUNDAR.PICHAI@EXAMPLE.COM", "SUNDAR.PICHAI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHPod1hKXNNIfCMJp6FQIOUe4JvcP6henyg+zg8ImH8kl6O7FC2nE5oHcrIlhHzzbQ==", null, false, null, null, "f9edf658-122d-4416-a5d8-3d82ad0f95ed", null, null, false, "sundar.pichai@example.com" },
                    { "105", 0, null, null, null, "65cd9531-50db-403f-b0e9-260faf030d60", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tim.cook@example.com", true, null, "Tim", null, null, true, false, false, false, "Cook", null, false, null, false, "TIM.COOK@EXAMPLE.COM", "TIM.COOK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBX9OVlhY4LZS7TS8GVvmaFWuc4n3i5f4J20twJp+7l2I/zMV5mSStpBr242J1OQNw==", null, false, null, null, "03f562fc-ebf1-47f7-9571-b0802bb69099", null, null, false, "tim.cook@example.com" },
                    { "106", 0, null, null, null, "6ab4db7c-58b8-44c2-ae15-7acc00698800", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "satya.nadella@example.com", true, null, "Satya", null, null, true, false, false, false, "Nadella", null, false, null, false, "SATYA.NADELLA@EXAMPLE.COM", "SATYA.NADELLA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEK4MWAyt8axn4Tx+oB2ba93J9gnhyEHNT2JD57CUUXe+lZp+RKhEU+YoLC8k/GTtPg==", null, false, null, null, "0679ad36-5ef8-472b-b657-7fd9e2cb6863", null, null, false, "satya.nadella@example.com" },
                    { "107", 0, null, null, null, "5bc9abb9-635a-4b9f-94a0-d370a86055eb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jack.dorsey@example.com", true, null, "Jack", null, null, true, false, false, false, "Dorsey", null, false, null, false, "JACK.DORSEY@EXAMPLE.COM", "JACK.DORSEY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKrGpserlqkskHqDpI6Vp1FHXl2e0qlRfRWcHu3BR82kXyw8aqypJrlIRZ0uxwYY1Q==", null, false, null, null, "4c080126-9dfe-4626-af8c-a10c24962729", null, null, false, "jack.dorsey@example.com" },
                    { "108", 0, null, null, null, "4592b2c5-c873-49d7-a9fd-c2f1dc179f10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "larry.page@example.com", true, null, "Larry", null, null, true, false, false, false, "Page", null, false, null, false, "LARRY.PAGE@EXAMPLE.COM", "LARRY.PAGE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH0H2mLPuf+d+U4Zr8vuJooQyb+I8kMLCzlq1VAO+fqu0vbUAbRma/xkixV1LwGLyw==", null, false, null, null, "72392c64-319c-4936-859e-9f27d51811b0", null, null, false, "larry.page@example.com" },
                    { "109", 0, null, null, null, "5b875d02-7365-4308-84df-662e80f32bac", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sergey.brin@example.com", true, null, "Sergey", null, null, true, false, false, false, "Brin", null, false, null, false, "SERGEY.BRIN@EXAMPLE.COM", "SERGEY.BRIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAELSRm3+ddZTf9ncrecXpxC/ukH7lxY+6OR/FeKoCQjSZfCj0x3NB3TXdNoUr/eucMA==", null, false, null, null, "e749b1f5-45f5-4731-b33c-1a95681a5f60", null, null, false, "sergey.brin@example.com" },
                    { "110", 0, null, null, null, "18d76045-29d2-4288-b513-792ceb2cef88", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "steve.jobs@example.com", true, null, "Steve", null, null, true, false, false, false, "Jobs", null, false, null, false, "STEVE.JOBS@EXAMPLE.COM", "STEVE.JOBS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJYhVbzUXTz5g+7q45pGet5iBncsCmvxjtjcblXriMLGYZRUWeKhf/8qnYz+5zYwPA==", null, false, null, null, "ea44530b-2647-4fd1-a784-800510bd3fed", null, null, false, "steve.jobs@example.com" },
                    { "111", 0, null, null, null, "0e76348e-b5ea-41f7-8ffe-4b0b5c88fa02", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sheryl.sandberg@example.com", true, null, "Sheryl", null, null, true, false, false, false, "Sandberg", null, false, null, false, "SHERYL.SANDBERG@EXAMPLE.COM", "SHERYL.SANDBERG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAYJAE1TlHrSElaFZ6DQUbwMHMKP4OeanDTB+xqgfQqNIWFZS2vsc4jOl+MmEL1Fmg==", null, false, null, null, "a41e044c-df18-431c-8df8-8c9098332367", null, null, false, "sheryl.sandberg@example.com" },
                    { "112", 0, null, null, null, "18d77c0d-a0f4-46a4-9968-85ede862b88d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reed.hastings@example.com", true, null, "Reed", null, null, true, false, false, false, "Hastings", null, false, null, false, "REED.HASTINGS@EXAMPLE.COM", "REED.HASTINGS@EXAMPLE.COM", "AQAAAAIAAYagAAAAECiPJxioP9z4wGm3MlRQMV8/opD/0PRQw5LZgzAQkjk20M/Ctr+guxgGSOXzv2j7jw==", null, false, null, null, "52cb671f-60b4-4f28-aad1-89112926a965", null, null, false, "reed.hastings@example.com" },
                    { "113", 0, null, null, null, "d99b653c-cd4f-4d5a-97ec-9e1f3db3aead", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "marissa.mayer@example.com", true, null, "Marissa", null, null, true, false, false, false, "Mayer", null, false, null, false, "MARISSA.MAYER@EXAMPLE.COM", "MARISSA.MAYER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIDgCtOSosxsygby7UnJQwMdZsTnUjHFYh7Wx2+jqO0o1KGlgJ8B5RxaVeR7eRG/8g==", null, false, null, null, "74de51c7-3009-42be-8bd9-d257e47cfd3d", null, null, false, "marissa.mayer@example.com" },
                    { "114", 0, null, null, null, "987ff812-5a84-4b09-bba8-9ea5c980b933", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "elizabeth.holmes@example.com", true, null, "Elizabeth", null, null, true, false, false, false, "Holmes", null, false, null, false, "ELIZABETH.HOLMES@EXAMPLE.COM", "ELIZABETH.HOLMES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBeZD/T2n/BZ928spAUKomWe+zSdLH0fvdpDrQ5QzbDQL5Zv0QmSgo44Efz3rO5REA==", null, false, null, null, "f42348b1-b4b7-4630-9a57-f412f4f0f4c0", null, null, false, "elizabeth.holmes@example.com" },
                    { "115", 0, null, null, null, "2130e480-bfcf-43f5-9ac3-151c02eec093", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "susan.wojcicki@example.com", true, null, "Susan", null, null, true, false, false, false, "Wojcicki", null, false, null, false, "SUSAN.WOJCICKI@EXAMPLE.COM", "SUSAN.WOJCICKI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGYreXVx9PVgtxKSNlz/bRiGbEl0qDJIeMpJmVkfFmYFZS8EZwcNgxi94QoKHjZuQw==", null, false, null, null, "5163cf08-8845-4f2d-ae1d-2c9084e6d208", null, null, false, "susan.wojcicki@example.com" },
                    { "116", 0, null, null, null, "2422bf6f-88d5-4bff-a65a-a55eaace8c83", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tim.arnold@example.com", true, null, "Tim", null, null, true, false, false, false, "Arnold", null, false, null, false, "TIM.ARNOLD@EXAMPLE.COM", "TIM.ARNOLD@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOxc0QVpSswClXWCDGXVUJgl9qoaaZHatKqgr1k1a3IyA5cCrVvNj3iIMA6Q6O7WqA==", null, false, null, null, "56210cd6-e37c-4c50-99e3-a07b65828640", null, null, false, "tim.arnold@example.com" },
                    { "117", 0, null, null, null, "f773c73b-d550-46ba-ad9a-aad07fa5a3d4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.iger@example.com", true, null, "Bob", null, null, true, false, false, false, "Iger", null, false, null, false, "BOB.IGER@EXAMPLE.COM", "BOB.IGER@EXAMPLE.COM", "AQAAAAIAAYagAAAAECMrhUC3c3lgxD+ZJaVzX0fgQ4q6thmOa9uq+XblQ7z3z2Bl8LT+jBxu8oKojd9W6w==", null, false, null, null, "d28d988e-8035-4a6c-a013-7a18a861d8f0", null, null, false, "bob.iger@example.com" },
                    { "118", 0, null, null, null, "ba869e1a-ce6e-4ee4-b55a-27b4644dcd0d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "larry.ellison@example.com", true, null, "Larry", null, null, true, false, false, false, "Ellison", null, false, null, false, "LARRY.ELLISON@EXAMPLE.COM", "LARRY.ELLISON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ0zeNAdU45yDn7PiNMTLpm7jcc7t21aEirLtB8Ur3o8I6TF8Ct0qmjjC3UHN3Cn0A==", null, false, null, null, "8a23eee5-2e22-44ef-9b5e-bb3d10d1f3f0", null, null, false, "larry.ellison@example.com" },
                    { "119", 0, null, null, null, "6957e117-2895-4e82-9647-2c5116875a1e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "richard.branson@example.com", true, null, "Richard", null, null, true, false, false, false, "Branson", null, false, null, false, "RICHARD.BRANSON@EXAMPLE.COM", "RICHARD.BRANSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKOfP0LYTdoW7KGSZsCUUHjwwXZYIsiYokm7/7S3E4nm0O5L5da7mEa+3PKsypZGXQ==", null, false, null, null, "15857d90-0fbd-4c9c-9115-613cc1c51b85", null, null, false, "richard.branson@example.com" },
                    { "120", 0, null, null, null, "febdb1c6-f62a-4c40-ac5b-b62f0e9c630e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jack.ma@example.com", true, null, "Jack", null, null, true, false, false, false, "Ma", null, false, null, false, "JACK.MA@EXAMPLE.COM", "JACK.MA@EXAMPLE.COM", "AQAAAAIAAYagAAAAECGn2sbg+lxP63+G9JGgBc9slWRnNAf80eDkwdjp+Ryo8yo4Rdl6/UPSsMIkPoL26Q==", null, false, null, null, "be3055c1-a1ce-459f-a8b2-1c118e64d3e7", null, null, false, "jack.ma@example.com" },
                    { "121", 0, null, null, null, "b122f91a-548f-4073-be4c-92b77ccb9edb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "warren.buffett@example.com", true, null, "Warren", null, null, true, false, false, false, "Buffett", null, false, null, false, "WARREN.BUFFETT@EXAMPLE.COM", "WARREN.BUFFETT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJMQsalUhYHqAsAhXDLOyrMv/suEuMIh72eVA0w+K72mD7ruyHWRg1MHqi1v9RotiA==", null, false, null, null, "bd60ece0-1e80-4f9c-a8e5-c8c413be2b86", null, null, false, "warren.buffett@example.com" },
                    { "122", 0, null, null, null, "6744515f-6be1-4066-82ae-5e2e93a247f2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mary.barrett@example.com", true, null, "Mary", null, null, true, false, false, false, "Barrett", null, false, null, false, "MARY.BARRETT@EXAMPLE.COM", "MARY.BARRETT@EXAMPLE.COM", "AQAAAAIAAYagAAAAELWZwlAq9pWyuItkjcOahItFnIVJXdtuO+otvzIPfW1DtnJg+UU9lwkxn3WK4p7GRw==", null, false, null, null, "0bf5dfb0-ec94-462e-b3e6-733677b74003", null, null, false, "mary.barrett@example.com" },
                    { "123", 0, null, null, null, "84f45780-22d9-4dfc-8c9b-8e802e2a1111", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ginni.rometty@example.com", true, null, "Ginni", null, null, true, false, false, false, "Rometty", null, false, null, false, "GINNI.ROMETTY@EXAMPLE.COM", "GINNI.ROMETTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEII35Xxg/k3FB71TCHT3r3jB3qZ/eT0EzvEdTdLHusu/RRtm468jiIuROeAVZb+Tjw==", null, false, null, null, "12bf4466-89a3-4a18-8a62-85107b372df9", null, null, false, "ginni.rometty@example.com" },
                    { "124", 0, null, null, null, "f4d23f64-563c-479d-9a8e-288ff6eee196", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mark.benioff@example.com", true, null, "Mark", null, null, true, false, false, false, "Benioff", null, false, null, false, "MARK.BENIOFF@EXAMPLE.COM", "MARK.BENIOFF@EXAMPLE.COM", "AQAAAAIAAYagAAAAECOrEGZ3z2dQQIaUf2pCH5Bka82qq59qA3oSEn8OBw9wx/cXXe7L86yeJg0Knb2x6A==", null, false, null, null, "3f0c54cf-6e68-4e5a-9576-d1fb40f4e483", null, null, false, "mark.benioff@example.com" },
                    { "125", 0, null, null, null, "a01ea1b8-978f-4356-84b5-fdb554251d76", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kevin.systrom@example.com", true, null, "Kevin", null, null, true, false, false, false, "Systrom", null, false, null, false, "KEVIN.SYSTROM@EXAMPLE.COM", "KEVIN.SYSTROM@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO5OJQOZo2VoCAWpyqJUcv+eE1XDODL0zr0efPT7QICJpWSRub8w14p31vp4+qF09Q==", null, false, null, null, "706fe745-a7e3-48ab-8deb-cb9a4ce04a34", null, null, false, "kevin.systrom@example.com" },
                    { "126", 0, null, null, null, "5b372452-65e3-497a-b43e-ebab96feb678", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "evan.spiegel@example.com", true, null, "Evan", null, null, true, false, false, false, "Spiegel", null, false, null, false, "EVAN.SPIEGEL@EXAMPLE.COM", "EVAN.SPIEGEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMosBXhn2LtsKFSKFN2zSEbNXmmS8/oO2ValMpZy6GFah4iLdTZ/IdQKG2LL7xRpdg==", null, false, null, null, "8887f762-93c3-4bf1-9a48-6c68935af3ac", null, null, false, "evan.spiegel@example.com" },
                    { "127", 0, null, null, null, "f2246494-0e2c-4e73-a432-7fd67aa31560", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jan.koum@example.com", true, null, "Jan", null, null, true, false, false, false, "Koum", null, false, null, false, "JAN.KOUM@EXAMPLE.COM", "JAN.KOUM@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEaiHFpz4wVIZWuHbKsuZrA+bAc0oPTNcWB2u8TmXzcNJlVtEGLLlCfVW9jT7msmig==", null, false, null, null, "ff30ea0c-6c4f-43c9-9034-f110c962bd55", null, null, false, "jan.koum@example.com" },
                    { "128", 0, null, null, null, "f7b9f92e-4de3-451a-91f9-25f982756baf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "janice.fang@example.com", true, null, "Janice", null, null, true, false, false, false, "Fang", null, false, null, false, "JANICE.FANG@EXAMPLE.COM", "JANICE.FANG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBSy5l2H+1ubScGPwgLhOTRC1JSZiP0twWe7q+9ObTPOw9+80i4HDw5wD/hH3/gjDg==", null, false, null, null, "8fec1cbc-02d5-46e0-b603-03f9cf3e9c22", null, null, false, "janice.fang@example.com" },
                    { "129", 0, null, null, null, "b462ef51-dfb3-44b3-a380-f17db197b1d9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sergey.gladkikh@example.com", true, null, "Sergey", null, null, true, false, false, false, "Gladkikh", null, false, null, false, "SERGEY.GLADKIKH@EXAMPLE.COM", "SERGEY.GLADKIKH@EXAMPLE.COM", "AQAAAAIAAYagAAAAECLvcYTtnyEAZwbt/W1e9qMaEDOeuvRqEaQQoqaGW925LM+NEVcFT4dvQV3gYOWEOQ==", null, false, null, null, "03c192ab-66a7-4375-89fa-e587c887215f", null, null, false, "sergey.gladkikh@example.com" },
                    { "130", 0, null, null, null, "cc84ca56-a8ae-4d0a-add8-77564878867a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tony.hsieh@example.com", true, null, "Tony", null, null, true, false, false, false, "Hsieh", null, false, null, false, "TONY.HSIEH@EXAMPLE.COM", "TONY.HSIEH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBHxmpX+blz/sH7VYUvKuTkQvLiGtTSywqAU6TQZEi921jfIhaqj8eeo2+hsVwBdBw==", null, false, null, null, "26de7a0d-c703-4fc3-b93d-d264817a7a97", null, null, false, "tony.hsieh@example.com" },
                    { "131", 0, null, null, null, "47ba055c-505f-4629-9f96-fa14b73b591b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "richard.hyne@example.com", true, null, "Richard", null, null, true, false, false, false, "Hyne", null, false, null, false, "RICHARD.HYNE@EXAMPLE.COM", "RICHARD.HYNE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOsQamTKUD3eGVSbXKdEckJHchTIzRUbxH5ilWKI9CLSbDD5Ne8K1OYcJOFWkd7Vuw==", null, false, null, null, "186b0d42-68f1-4610-a7b7-0fa8082ef5b3", null, null, false, "richard.hyne@example.com" },
                    { "132", 0, null, null, null, "9fe57201-1538-49eb-b8d3-437d16943999", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "peter.thiel@example.com", true, null, "Peter", null, null, true, false, false, false, "Thiel", null, false, null, false, "PETER.THIEL@EXAMPLE.COM", "PETER.THIEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDJI5q/A79dDsb0YUcMb1S12+iwchSDgfcaxRgzIvLLLd8O4j1luLs5Qfozngr3tkg==", null, false, null, null, "9ca7edd4-cff3-4c3f-bf80-2c7a15ce2193", null, null, false, "peter.thiel@example.com" },
                    { "133", 0, null, null, null, "a0cddc77-b46f-4bc1-8e04-ae08c7ddbfe8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "steve.wozniak@example.com", true, null, "Steve", null, null, true, false, false, false, "Wozniak", null, false, null, false, "STEVE.WOZNIAK@EXAMPLE.COM", "STEVE.WOZNIAK@EXAMPLE.COM", "AQAAAAIAAYagAAAAELSwS3wfcCbEAZjGwt7kD2rah+mS/zQolaM6GNhXJoTaeDnKEtyWkNWGhBqvMLnxPQ==", null, false, null, null, "e61ec30a-7e39-48ea-a6a4-4c1af57d7497", null, null, false, "steve.wozniak@example.com" },
                    { "134", 0, null, null, null, "c644aea9-a2e7-4760-b390-98c547251dbc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.carmack@example.com", true, null, "John", null, null, true, false, false, false, "Carmack", null, false, null, false, "JOHN.CARMACK@EXAMPLE.COM", "JOHN.CARMACK@EXAMPLE.COM", "AQAAAAIAAYagAAAAECiyfl80A3pPilfgUS43hT12tI19VEN5ZxFkvNR0v4lrX784PrzQtOVDuSEIlIxWBg==", null, false, null, null, "4b3aac45-a296-4f5b-9280-7910ceec4dd6", null, null, false, "john.carmack@example.com" },
                    { "135", 0, null, null, null, "8becbf51-1a91-429f-b02f-1e395c56a21d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mike.zyda@example.com", true, null, "Mike", null, null, true, false, false, false, "Zyda", null, false, null, false, "MIKE.ZYDA@EXAMPLE.COM", "MIKE.ZYDA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI46XL5e53CeIvbYoI64oCVigCd/VkU20xfVjT4OXLIS+RUBsOOMTtzHUTYbvVyK8g==", null, false, null, null, "ac5259d7-7992-4c68-9955-5a7c4b781ec6", null, null, false, "mike.zyda@example.com" },
                    { "136", 0, null, null, null, "ca300fc9-63ba-4ef9-a8bf-2584ae6af989", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cheryl.sandberg@example.com", true, null, "Cheryl", null, null, true, false, false, false, "Sandberg", null, false, null, false, "CHERYL.SANDBERG@EXAMPLE.COM", "CHERYL.SANDBERG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIJ4lwzCJxskAbZiYvyLM+IGrMPCIj7uMeHIpOZSXXfVmpKoH7rvAd3TvKBvzS/Y/w==", null, false, null, null, "df6f986e-ce34-4354-823e-0b07b5d0799c", null, null, false, "cheryl.sandberg@example.com" },
                    { "137", 0, null, null, null, "91d9b3e6-0411-43d9-88a5-1838deabf4dc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "karen.smith@example.com", true, null, "Karen", null, null, true, false, false, false, "Smith", null, false, null, false, "KAREN.SMITH@EXAMPLE.COM", "KAREN.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH9qMH/O0TWzJDC7lAwqJKM1TEUlrbICaazNJqCukW7lOVfReXIZ/PI0J0BC1vUM9g==", null, false, null, null, "e72b41b6-4cb8-479f-a55b-d2798ffbcd55", null, null, false, "karen.smith@example.com" },
                    { "138", 0, null, null, null, "43eeb361-de25-45be-8965-2d4aad02ea72", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.lee@example.com", true, null, "David", null, null, true, false, false, false, "Lee", null, false, null, false, "DAVID.LEE@EXAMPLE.COM", "DAVID.LEE@EXAMPLE.COM", "AQAAAAIAAYagAAAAECHcmVKhHw+HpKASkgJxkb2Shz2c4UaPYpPeFvwPvIV4CllhpV6A4H+qCNPkkNylIA==", null, false, null, null, "0eab57c3-e8c1-4a44-8952-a5078bb9e822", null, null, false, "david.lee@example.com" },
                    { "139", 0, null, null, null, "8f47556b-9c87-438c-bdfb-d8ef81c3a147", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "james.taylor@example.com", true, null, "James", null, null, true, false, false, false, "Taylor", null, false, null, false, "JAMES.TAYLOR@EXAMPLE.COM", "JAMES.TAYLOR@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPjSfuLTjfKFudNSqYgQv8fhKa/0BFKgeTFUxPPPafx5bR96NePb4iz+so2CmzH60Q==", null, false, null, null, "47001e8c-5fde-4adc-91a1-ecfb1fd58b37", null, null, false, "james.taylor@example.com" }
                });

            migrationBuilder.InsertData(
                table: "BillItems",
                columns: new[] { "BillItemsID", "AddedBy", "AddedOn", "Amount", "BillItemsModelBillItemsID", "Description", "IsDeleted", "PaymentDuration", "PaymentName", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(8986), 3500.00m, null, "Monthly HOA dues covering maintenance, security, and amenities.", false, "Monthly", "Homeowners Association (HOA) Fees", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(8995), 100.00m, null, "Monthly water consumption charges.", false, "Monthly", "Water Bill", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(8997), 2500.00m, null, "Monthly payment for electricity consumption.", false, "Monthly", "Electricity Bill", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(8999), 300.00m, null, "Monthly fee for waste disposal services.", false, "Monthly", "Garbage Collection Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(9000), 1500.00m, null, "Monthly fee for subdivision security services.", false, "Monthly", "Security Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(9001), 500.00m, null, "Monthly fee for streetlight maintenance.", false, "Monthly", "Street Lighting Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(9002), 800.00m, null, "Annual fee for maintaining the clubhouse and shared spaces.", false, "Yearly", "Clubhouse Maintenance Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(9004), 5000.00m, null, "Annual contribution for property tax remittance.", false, "Yearly", "Property Tax Contribution", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(9005), 1200.00m, null, "Quarterly contribution for major subdivision repairs.", false, "Quarterly", "Sinking Fund Contribution", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(9007), 600.00m, null, "Quarterly fee for pest control services in the subdivision.", false, "Quarterly", "Pest Control Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, new DateTime(2025, 4, 14, 16, 18, 12, 92, DateTimeKind.Utc).AddTicks(9008), 1000.00m, null, "Annual fee for road maintenance and repairs.", false, "Yearly", "Road Maintenance Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                    { 1, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(777), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(775), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(776), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(778), "111" },
                    { 2, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(781), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(780), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(781), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(782), "112" },
                    { 3, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(793), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(783), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(792), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(794), "113" },
                    { 4, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(796), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(795), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(796), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(797), "114" },
                    { 5, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(799), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(798), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(798), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(799), "115" },
                    { 6, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(801), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(800), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(801), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(802), "116" },
                    { 7, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(804), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(803), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(803), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(804), "117" },
                    { 8, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(806), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(805), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(806), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(807), "118" },
                    { 9, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(809), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(808), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(808), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(809), "119" },
                    { 10, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(811), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(810), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(811), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(812), "120" },
                    { 11, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(814), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(813), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(813), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(814), "121" },
                    { 12, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(816), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(815), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(815), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(817), "122" },
                    { 13, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(819), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(818), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(818), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(819), "123" },
                    { 14, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(821), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(820), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(821), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(822), "124" },
                    { 15, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(824), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(823), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(823), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(824), "125" },
                    { 16, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(826), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(825), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(825), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(826), "126" },
                    { 17, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(828), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(827), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(828), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(829), "127" },
                    { 18, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(831), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(830), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(830), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(831), "128" },
                    { 19, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(833), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(832), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(833), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(834), "129" },
                    { 20, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(836), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(835), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(835), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(836), "130" },
                    { 21, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(839), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(837), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(838), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(839), "131" },
                    { 22, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(841), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(840), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(840), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(841), "132" },
                    { 23, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(843), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(842), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(843), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(844), "133" },
                    { 24, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(846), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(845), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(845), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(846), "134" },
                    { 25, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(848), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(847), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(848), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(849), "135" },
                    { 26, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(851), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(850), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(850), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(851), "136" },
                    { 27, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(853), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(852), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(852), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(854), "137" },
                    { 28, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(856), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(855), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(855), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(856), "138" },
                    { 29, null, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(859), null, true, false, false, false, new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(858), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(859), new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(860), "139" }
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
                    { 1, "admin", new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(468), "123 Main St", 6, "Jane Doe", "1234567890", "Spouse", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Security Officer", 25000.00m, null, null, "100" },
                    { 2, "admin", new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(487), "456 Oak St", 5, "John Smith", "0987654321", "Brother", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Maintenance Supervisor", 30000.00m, null, null, "102" },
                    { 3, "admin", new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(497), "789 Pine St", 3, "Alice Brown", "5678901234", "Sister", new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "System Administrator", 35000.00m, null, null, "103" },
                    { 4, "admin", new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(507), "987 Cedar St", 2, "Bob White", "2345678901", "Father", new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Finance Manager", 40000.00m, null, null, "104" },
                    { 5, "admin", new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(518), "654 Birch St", 0, "Chris Green", "3456789012", "Friend", new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Amenities Coordinator", 28000.00m, null, null, "105" },
                    { 6, "admin", new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(527), "321 Maple St", 1, "Diana Blue", "4567890123", "Cousin", new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Customer Service Representative", 26000.00m, null, null, "106" },
                    { 7, "admin", new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(536), "159 Elm St", 4, "Evan Red", "5678901234", "Uncle", new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Head Gardener", 27000.00m, null, null, "107" },
                    { 8, "admin", new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(545), "123 Main St", 6, "Jane Doe", "1234567890", "Spouse", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Security Officer", 25000.00m, null, null, "108" },
                    { 9, "admin", new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(602), "456 Oak St", 5, "John Smith", "0987654321", "Brother", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Maintenance Supervisor", 30000.00m, null, null, "109" },
                    { 10, "admin", new DateTime(2025, 4, 14, 16, 18, 14, 431, DateTimeKind.Utc).AddTicks(630), "789 Pine St", 3, "Alice Brown", "5678901234", "Sister", new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "System Administrator", 35000.00m, null, null, "110" }
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
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
