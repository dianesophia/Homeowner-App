using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class leobuang : Migration
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillItems", x => x.BillItemsID);
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
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { "100", 0, null, null, null, "32c1a819-061b-49e0-ace7-b12532f21274", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "elon.musk@example.com", true, null, "Elon", null, null, true, false, false, false, "Musk", null, false, null, false, "ELON.MUSK@EXAMPLE.COM", "ELON.MUSK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPSZPz/0H9EzA2+jxfWRHmAnc3c7UFPLFa2ef1Wx2eMJ1JMnviKhEmr0um4U5+2okw==", null, false, null, "wwwroot/images/picc.png", "20bf43e9-ef57-43af-85ab-e7ebdfd560cd", null, null, false, "elon.musk@example.com" },
                    { "102", 0, null, null, null, "1aa4b430-b51c-413b-88a6-b85419878088", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bill.gates@example.com", true, null, "Bill", null, null, true, false, false, false, "Gates", null, false, null, false, "BILL.GATES@EXAMPLE.COM", "BILL.GATES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPPuTAnOCOPx4F5Mbwt+Co4EtzChRDATJx3jDSl2KmtnseN1roiFHEgZHE+VdRjXYQ==", null, false, null, null, "fd7126e0-f93c-46ef-a9b6-1a848dd89ddb", null, null, false, "bill.gates@example.com" },
                    { "103", 0, null, null, null, "c15aebad-a379-44d2-9158-d08c7fb2f9b1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mark.zuckerberg@example.com", true, null, "Mark", null, null, true, false, false, false, "Zuckerberg", null, false, null, false, "MARK.ZUCKERBERG@EXAMPLE.COM", "MARK.ZUCKERBERG@EXAMPLE.COM", "AQAAAAIAAYagAAAAENEKBrV0nzgaBylfBGE9LPj1h6rinhI+W1vU+9CnfYM92F3CYtPzx2+MEEmac/xRtQ==", null, false, null, null, "01031068-c56f-499a-86bf-e43c0564eca4", null, null, false, "mark.zuckerberg@example.com" },
                    { "104", 0, null, null, null, "af60a5a6-cae0-40cb-b54c-e2c6ff8dc73e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sundar.pichai@example.com", true, null, "Sundar", null, null, true, false, false, false, "Pichai", null, false, null, false, "SUNDAR.PICHAI@EXAMPLE.COM", "SUNDAR.PICHAI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI46oo4bC72UYRB/2//yfr0IxtUHSQWDIdY3dyt7KhMfoMUUyLAPI8k1lgwnuJrViA==", null, false, null, null, "b756ddff-1a8b-41e8-9af7-a724db047b24", null, null, false, "sundar.pichai@example.com" },
                    { "105", 0, null, null, null, "496d10ae-3b73-4ab5-8ce3-65e9e791f684", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tim.cook@example.com", true, null, "Tim", null, null, true, false, false, false, "Cook", null, false, null, false, "TIM.COOK@EXAMPLE.COM", "TIM.COOK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMDibvTUsFe7ntDrxwa4MdDjUo68S9aOhM2LJvUU5u7SFP0WYCkkL72pdu53Z9l1vw==", null, false, null, null, "9e7cbe3b-62ec-48bf-b2ba-b9ca6136ea61", null, null, false, "tim.cook@example.com" },
                    { "106", 0, null, null, null, "cd7a9461-6a71-4445-8741-600868a6e1fc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "satya.nadella@example.com", true, null, "Satya", null, null, true, false, false, false, "Nadella", null, false, null, false, "SATYA.NADELLA@EXAMPLE.COM", "SATYA.NADELLA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJGqo3Il2yi+kg7tyPPSIbd5cqLPfitNvuDhvinBbwbly6426OckeKCL/7JSrrWVtQ==", null, false, null, null, "3581e35e-b84a-4533-a80d-2c54429250e2", null, null, false, "satya.nadella@example.com" },
                    { "107", 0, null, null, null, "25ab0f15-2ed2-461b-aec6-4f2b3ff957fd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jack.dorsey@example.com", true, null, "Jack", null, null, true, false, false, false, "Dorsey", null, false, null, false, "JACK.DORSEY@EXAMPLE.COM", "JACK.DORSEY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKgdk8hfCC+QpyA4TUjZtFy5UTSGeaSEEJBQ0/90h7F/Cdg5hIbVqD2f6P/aw4sLZg==", null, false, null, null, "e08e7979-4273-408b-8b3d-3ebecd2d733e", null, null, false, "jack.dorsey@example.com" },
                    { "108", 0, null, null, null, "e8469719-0a0e-4753-a4b3-e759df73f21e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "larry.page@example.com", true, null, "Larry", null, null, true, false, false, false, "Page", null, false, null, false, "LARRY.PAGE@EXAMPLE.COM", "LARRY.PAGE@EXAMPLE.COM", "AQAAAAIAAYagAAAAENgTvf7BiMoAgAudIEWIpHaYgThtzCmvRuyhIKbCDyF+1etnJlM4L2MWgsO3VzJWmg==", null, false, null, null, "4ad0a7d4-19eb-497b-ab02-358fb07223fe", null, null, false, "larry.page@example.com" },
                    { "109", 0, null, null, null, "09208cc8-a22e-4ab3-8c5a-9b47a50eede2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sergey.brin@example.com", true, null, "Sergey", null, null, true, false, false, false, "Brin", null, false, null, false, "SERGEY.BRIN@EXAMPLE.COM", "SERGEY.BRIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOhhBMVVDQZzsArEevZtVhxGkBl2JAwNm7V7s2fy+SKcg0lZeyQym6RXGyo4PgBz6w==", null, false, null, null, "25747423-b552-424c-9e3e-fb0916f6186a", null, null, false, "sergey.brin@example.com" },
                    { "110", 0, null, null, null, "5dc01c86-ee2c-4916-82cc-b7ad597f10ae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "steve.jobs@example.com", true, null, "Steve", null, null, true, false, false, false, "Jobs", null, false, null, false, "STEVE.JOBS@EXAMPLE.COM", "STEVE.JOBS@EXAMPLE.COM", "AQAAAAIAAYagAAAAECYCED2j+bigTtFLqqpTKEMAMOxlLwNj2NjR/Nv/EVIt82mLV+/jBmikT09ZtY5ipQ==", null, false, null, null, "998029ba-c4b4-475a-a75b-5e8bebdadd6f", null, null, false, "steve.jobs@example.com" },
                    { "111", 0, null, null, null, "a61c81c2-e4d9-40a4-bf58-8e57cb3cd454", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sheryl.sandberg@example.com", true, null, "Sheryl", null, null, true, false, false, false, "Sandberg", null, false, null, false, "SHERYL.SANDBERG@EXAMPLE.COM", "SHERYL.SANDBERG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAY682AEKSqYwY3Kvv31fcIt80fQhv4Alp9q2KvnYKmWnJ+cWfEmsM/WtSt+JprSxg==", null, false, null, null, "c7afdc98-155a-410c-b353-d11db49fc51d", null, null, false, "sheryl.sandberg@example.com" },
                    { "112", 0, null, null, null, "eb931370-58e0-4b12-9e5e-dddff98ce543", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reed.hastings@example.com", true, null, "Reed", null, null, true, false, false, false, "Hastings", null, false, null, false, "REED.HASTINGS@EXAMPLE.COM", "REED.HASTINGS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIy9sXZCsdftupr4l9OJq58IUvQ8rUCk6lez176ubxZjZZYYrWK438TQwZp7HFPjsA==", null, false, null, null, "128b2515-6f65-4a0f-bbc4-1daae05eae6a", null, null, false, "reed.hastings@example.com" },
                    { "113", 0, null, null, null, "84be8765-2328-4a02-807b-6290a6485076", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "marissa.mayer@example.com", true, null, "Marissa", null, null, true, false, false, false, "Mayer", null, false, null, false, "MARISSA.MAYER@EXAMPLE.COM", "MARISSA.MAYER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPiph0OtHELFkds9WNm1hhxW4BGcQkL68cMeZDmnw1fBaum2809U1f8FZEqWUMXHpw==", null, false, null, null, "5bfab6f3-b56e-40e8-95b8-521147602da4", null, null, false, "marissa.mayer@example.com" },
                    { "114", 0, null, null, null, "daa2d3b0-6e01-4580-9cea-499a3b2ffb87", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "elizabeth.holmes@example.com", true, null, "Elizabeth", null, null, true, false, false, false, "Holmes", null, false, null, false, "ELIZABETH.HOLMES@EXAMPLE.COM", "ELIZABETH.HOLMES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBRGpT4fPIDMLFE+piUnZPgPFJ2uSoPMj42TlVjXi/9EUQoOwmWJFh+vTu0+hjYZgg==", null, false, null, null, "873d9164-82f3-4b09-b1bf-2d93d8646ecd", null, null, false, "elizabeth.holmes@example.com" },
                    { "115", 0, null, null, null, "eb721173-e267-422d-9b83-733fb7eb2335", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "susan.wojcicki@example.com", true, null, "Susan", null, null, true, false, false, false, "Wojcicki", null, false, null, false, "SUSAN.WOJCICKI@EXAMPLE.COM", "SUSAN.WOJCICKI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPoKyACNKKh18GEy2jhtF/yEQVIbNy16z7/AY+X3kwCLG8ZfmuKicrPZgs8uikIGLA==", null, false, null, null, "c34b79b0-369c-4dd2-be98-8020a9eb7acc", null, null, false, "susan.wojcicki@example.com" },
                    { "116", 0, null, null, null, "3f611e8e-8d09-45ce-b564-0cc2902218f6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tim.arnold@example.com", true, null, "Tim", null, null, true, false, false, false, "Arnold", null, false, null, false, "TIM.ARNOLD@EXAMPLE.COM", "TIM.ARNOLD@EXAMPLE.COM", "AQAAAAIAAYagAAAAEN0Fml1WSeDv3nZrg7vj8pckAo9P4KtBI9S53JBMmWeWmH6MlG5uW1DepfKSVjRAag==", null, false, null, null, "782abf49-9530-46e1-85b3-048b8c45ac1a", null, null, false, "tim.arnold@example.com" },
                    { "117", 0, null, null, null, "fcd02b51-d7ff-42e1-af56-3f72bcb3f438", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.iger@example.com", true, null, "Bob", null, null, true, false, false, false, "Iger", null, false, null, false, "BOB.IGER@EXAMPLE.COM", "BOB.IGER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDve5V0P8aIf2CmQNoBM1ICKsiUuJuqfWTpY3fyTJ72oFIjcEBXpQZd2vqOKag9Zag==", null, false, null, null, "4086b1cd-4520-4670-9f8b-b4aa9a5e7597", null, null, false, "bob.iger@example.com" },
                    { "118", 0, null, null, null, "ca3380d2-ace6-4aea-94bf-86058831eb7d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "larry.ellison@example.com", true, null, "Larry", null, null, true, false, false, false, "Ellison", null, false, null, false, "LARRY.ELLISON@EXAMPLE.COM", "LARRY.ELLISON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFBUgQfcoJU5g0dGWOUZI78efKW8JIJDEBM4fJr900adlRxdePLhKCOiuEi/gt/iLQ==", null, false, null, null, "c82e2580-96e9-46e1-85c3-e43ad380bfcc", null, null, false, "larry.ellison@example.com" },
                    { "119", 0, null, null, null, "fe626828-eec3-4a0d-8693-2cbb4f6f940e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "richard.branson@example.com", true, null, "Richard", null, null, true, false, false, false, "Branson", null, false, null, false, "RICHARD.BRANSON@EXAMPLE.COM", "RICHARD.BRANSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMp7NRvM6nmsNpdUyyAzCO/4SGFgXk9deAcAufM6SwsO5J5cLGmnFiJCaX60rZ2g1A==", null, false, null, null, "1931bfbc-6b1c-45f3-be96-f1d20105afe7", null, null, false, "richard.branson@example.com" },
                    { "120", 0, null, null, null, "9268d8f8-7431-472d-bbef-d20ffd7ade39", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jack.ma@example.com", true, null, "Jack", null, null, true, false, false, false, "Ma", null, false, null, false, "JACK.MA@EXAMPLE.COM", "JACK.MA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKJ8Ke9bCdu1m+nYpdPAI7WZbG1gwfVg3Wm816rHBk6EArZd6ukXyEitYzNmkhEg7Q==", null, false, null, null, "105c606b-5961-499b-ad69-5385b961d438", null, null, false, "jack.ma@example.com" },
                    { "121", 0, null, null, null, "4321cad3-60a5-4f08-9bcc-b6cc32643d0d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "warren.buffett@example.com", true, null, "Warren", null, null, true, false, false, false, "Buffett", null, false, null, false, "WARREN.BUFFETT@EXAMPLE.COM", "WARREN.BUFFETT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEA3W7O9cBthQ1Cgzeii+PRrPLiDvZBnGdr4feCcdVwkD0E7I3u5zDdRCHA+Dg7lWwA==", null, false, null, null, "91e7d53d-7293-485e-a30b-ab39f9ac174c", null, null, false, "warren.buffett@example.com" },
                    { "122", 0, null, null, null, "0f8a8866-b68a-44a9-b017-0aefd7863981", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mary.barrett@example.com", true, null, "Mary", null, null, true, false, false, false, "Barrett", null, false, null, false, "MARY.BARRETT@EXAMPLE.COM", "MARY.BARRETT@EXAMPLE.COM", "AQAAAAIAAYagAAAAECLrAeCzH9H5t9luK+HwqLnxbqRxcLSm/8SvKylRQutmJ5tdYAM5CQ8lQeJCBnlTAQ==", null, false, null, null, "7b249f6a-67ca-4df1-b758-e08d9e59f317", null, null, false, "mary.barrett@example.com" },
                    { "123", 0, null, null, null, "b29445f1-0e38-4801-ba57-3539c7263ec8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ginni.rometty@example.com", true, null, "Ginni", null, null, true, false, false, false, "Rometty", null, false, null, false, "GINNI.ROMETTY@EXAMPLE.COM", "GINNI.ROMETTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAENFjfq4lEe6L9PPmvriaf5IwspMOd6DsV5QTYbIh7mymf7Yjmmm8Bg4AD/dKzxWBHg==", null, false, null, null, "fab945c1-cfab-46e5-a08e-6e8698b1450f", null, null, false, "ginni.rometty@example.com" },
                    { "124", 0, null, null, null, "11517037-51d0-474b-a5e5-e5c3d8ffd224", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mark.benioff@example.com", true, null, "Mark", null, null, true, false, false, false, "Benioff", null, false, null, false, "MARK.BENIOFF@EXAMPLE.COM", "MARK.BENIOFF@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJGBUsCCg/twghqZtqN2Co7V3M92dq2Qtg2u1PSFpETPndhVg6fjihv4yRkJbV6aqA==", null, false, null, null, "46702209-0a40-4e1e-be8f-3ae525f2da43", null, null, false, "mark.benioff@example.com" },
                    { "125", 0, null, null, null, "49ab02e2-1c23-493f-abd2-a3e49b70a70b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kevin.systrom@example.com", true, null, "Kevin", null, null, true, false, false, false, "Systrom", null, false, null, false, "KEVIN.SYSTROM@EXAMPLE.COM", "KEVIN.SYSTROM@EXAMPLE.COM", "AQAAAAIAAYagAAAAECXgWfYytc1MUUNbZH9/kFEefjbpdobL1OMFu3YwP86RaQPGR7YbedTVcub4YyuqRg==", null, false, null, null, "771a197d-9d66-4fc5-a86c-7efb7b0ab0e9", null, null, false, "kevin.systrom@example.com" },
                    { "126", 0, null, null, null, "7ca28216-bc79-4059-82d2-22b95360ae20", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "evan.spiegel@example.com", true, null, "Evan", null, null, true, false, false, false, "Spiegel", null, false, null, false, "EVAN.SPIEGEL@EXAMPLE.COM", "EVAN.SPIEGEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFak6l7oqgWQlG9hLxUnB5nf9XszNKEm9GfBXdvY5VE9ZjdLtnaZfHQDRs3inJpmWQ==", null, false, null, null, "badf4d95-a66a-444a-b9a8-cd73e0df9f67", null, null, false, "evan.spiegel@example.com" },
                    { "127", 0, null, null, null, "f932061d-b6da-4bfb-99f6-6103e74d785e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jan.koum@example.com", true, null, "Jan", null, null, true, false, false, false, "Koum", null, false, null, false, "JAN.KOUM@EXAMPLE.COM", "JAN.KOUM@EXAMPLE.COM", "AQAAAAIAAYagAAAAECk5DvdUVL82Sno3pEtyT4VINiDeH3ewWKPM5Kq3r+jm3SN00ftp12dY+p1UKEuVdQ==", null, false, null, null, "70a67974-161f-477a-b41f-db70b2b35a20", null, null, false, "jan.koum@example.com" },
                    { "128", 0, null, null, null, "31a47a4a-6d58-4e2b-b89d-1208b36f03a8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "janice.fang@example.com", true, null, "Janice", null, null, true, false, false, false, "Fang", null, false, null, false, "JANICE.FANG@EXAMPLE.COM", "JANICE.FANG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHm++jtONXY0U/tC1h0JuqsIgD4X5LfaM4P6XgHKA+fGMRbQCGMk7omh3cvMZmSuoA==", null, false, null, null, "74eefd64-03bd-4483-8b68-4f95ac58ec7b", null, null, false, "janice.fang@example.com" },
                    { "129", 0, null, null, null, "560e751b-5496-400d-a17d-e909a884919f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sergey.gladkikh@example.com", true, null, "Sergey", null, null, true, false, false, false, "Gladkikh", null, false, null, false, "SERGEY.GLADKIKH@EXAMPLE.COM", "SERGEY.GLADKIKH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJP/EubHGvltjVmGCr2UYADFY6+HaIwehLAQ60b1RYrDKZVz8s0XT0607gUkKtnPNQ==", null, false, null, null, "44071f0c-7125-4c16-bd07-2bb22ad79625", null, null, false, "sergey.gladkikh@example.com" },
                    { "130", 0, null, null, null, "4d274d51-4f10-49ac-a571-f6d5660c302e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tony.hsieh@example.com", true, null, "Tony", null, null, true, false, false, false, "Hsieh", null, false, null, false, "TONY.HSIEH@EXAMPLE.COM", "TONY.HSIEH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBxLBsVp20wrxrRb5kHV2bfyGa5EyNTMUSSrLSSUumPNNkRT2pCXAsPK470bVYXuJA==", null, false, null, null, "0fe4b504-e5cf-4223-80ee-98fd6f64be7a", null, null, false, "tony.hsieh@example.com" },
                    { "131", 0, null, null, null, "0124cec4-7a8d-4a4e-834b-408cafa08766", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "richard.hyne@example.com", true, null, "Richard", null, null, true, false, false, false, "Hyne", null, false, null, false, "RICHARD.HYNE@EXAMPLE.COM", "RICHARD.HYNE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEALohdmr1romQ+FFJ/qY/ED892TlwBLSnqnbGCollwoF8OkcCct4pid5/nbFmlwHnA==", null, false, null, null, "ff44ff5e-5cd1-40ce-bbbf-eca34bf45cdb", null, null, false, "richard.hyne@example.com" },
                    { "132", 0, null, null, null, "3847442b-dd7e-47c4-9fef-cfbc7a6b3f9e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "peter.thiel@example.com", true, null, "Peter", null, null, true, false, false, false, "Thiel", null, false, null, false, "PETER.THIEL@EXAMPLE.COM", "PETER.THIEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBkbQwGvNsPjTN1hETtSjjbvSKKkREEdycdhmJwZjPMwAfDmDfFHZiiVUjW2fGohvg==", null, false, null, null, "2bee3173-9450-41d2-bd17-d52bacb59ec4", null, null, false, "peter.thiel@example.com" },
                    { "133", 0, null, null, null, "e5f4f212-3a7e-4540-90c9-eac54ae82237", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "steve.wozniak@example.com", true, null, "Steve", null, null, true, false, false, false, "Wozniak", null, false, null, false, "STEVE.WOZNIAK@EXAMPLE.COM", "STEVE.WOZNIAK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJe4i/oT8R08gn3AewPGD7XhIsfO6wj2mnqu7z5kFq3ejP9Pvnr6P6aFR/VhtnYJog==", null, false, null, null, "ed924a48-6b34-42bb-b7ba-f2ae9be316b5", null, null, false, "steve.wozniak@example.com" },
                    { "134", 0, null, null, null, "360c8111-095b-4638-8e88-65cc5ade15aa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.carmack@example.com", true, null, "John", null, null, true, false, false, false, "Carmack", null, false, null, false, "JOHN.CARMACK@EXAMPLE.COM", "JOHN.CARMACK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAgVw9ONVVgWgdl/W3PScn66kdHrZNePqcLUoHhp7PxLUgAcKWke2XAGSop1Th5SAg==", null, false, null, null, "52a20b82-ce0a-428d-8d5c-9e6118df3096", null, null, false, "john.carmack@example.com" },
                    { "135", 0, null, null, null, "ec5eb518-dc60-45fe-abae-997ad675b025", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mike.zyda@example.com", true, null, "Mike", null, null, true, false, false, false, "Zyda", null, false, null, false, "MIKE.ZYDA@EXAMPLE.COM", "MIKE.ZYDA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMFdRIn/SYBCegWFdO9IH5wJblkCHpuvnE7bbz20skveNMU+UOrfdZUyBDdVe35iCA==", null, false, null, null, "df2af51a-927d-4946-a0ad-03a6155a355c", null, null, false, "mike.zyda@example.com" },
                    { "136", 0, null, null, null, "6e5c7a00-8ed1-4a4a-bb42-91396a610f95", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cheryl.sandberg@example.com", true, null, "Cheryl", null, null, true, false, false, false, "Sandberg", null, false, null, false, "CHERYL.SANDBERG@EXAMPLE.COM", "CHERYL.SANDBERG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGo17NrXEX9R9ut3pmqane7UuBhxF7f3shfBwIqLABl/cVPe+LGdNmxyLzwRT8NA0w==", null, false, null, null, "0d80fc8d-6636-4e16-ae63-d50f130ecadc", null, null, false, "cheryl.sandberg@example.com" },
                    { "137", 0, null, null, null, "bd7a0f10-2cf9-4442-b816-443f10794944", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "karen.smith@example.com", true, null, "Karen", null, null, true, false, false, false, "Smith", null, false, null, false, "KAREN.SMITH@EXAMPLE.COM", "KAREN.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEPFxYvW8DDvIrqixG+NoBsSqR/M1c6Pzws5a/7Q+inbcM8PoHlLf3LHnBB/G93wOA==", null, false, null, null, "fa678470-94c3-4758-9059-7b4e662282c0", null, null, false, "karen.smith@example.com" },
                    { "138", 0, null, null, null, "f66b8c16-5f51-425e-85dd-60fd9e891c9c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.lee@example.com", true, null, "David", null, null, true, false, false, false, "Lee", null, false, null, false, "DAVID.LEE@EXAMPLE.COM", "DAVID.LEE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBYaV2oqZcvBw8H3X/2DeaVYKKmS6Vlw0qXIX8WGi7fl2jt+nZKxBg1FJ4ofJF9FTg==", null, false, null, null, "35a6491d-d305-434d-bb29-0d1a640f633d", null, null, false, "david.lee@example.com" },
                    { "139", 0, null, null, null, "f9d7ee68-242e-4542-ad0d-3d25eae60b84", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "james.taylor@example.com", true, null, "James", null, null, true, false, false, false, "Taylor", null, false, null, false, "JAMES.TAYLOR@EXAMPLE.COM", "JAMES.TAYLOR@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI/I8o0muhX5d3QuxVUHvxvoQ9iNr+NOTZ4S9CV0gEqnNnftsahqTAlnpo9EiwXqrg==", null, false, null, null, "53c976a9-2cb9-4b42-85c6-df31c15f9de0", null, null, false, "james.taylor@example.com" }
                });

            migrationBuilder.InsertData(
                table: "BillItems",
                columns: new[] { "BillItemsID", "AddedBy", "AddedOn", "Amount", "Description", "IsDeleted", "PaymentDuration", "PaymentName", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 4, 14, 13, 28, 52, 887, DateTimeKind.Utc).AddTicks(2349), 3500.00m, "Monthly HOA dues covering maintenance, security, and amenities.", false, "Monthly", "Homeowners Association (HOA) Fees", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(2025, 4, 14, 13, 28, 52, 887, DateTimeKind.Utc).AddTicks(2358), 100.00m, "Monthly water consumption charges.", false, "Monthly", "Water Bill", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(2025, 4, 14, 13, 28, 52, 887, DateTimeKind.Utc).AddTicks(2360), 2500.00m, "Monthly payment for electricity consumption.", false, "Monthly", "Electricity Bill", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, new DateTime(2025, 4, 14, 13, 28, 52, 887, DateTimeKind.Utc).AddTicks(2362), 300.00m, "Monthly fee for waste disposal services.", false, "Monthly", "Garbage Collection Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, new DateTime(2025, 4, 14, 13, 28, 52, 887, DateTimeKind.Utc).AddTicks(2364), 1500.00m, "Monthly fee for subdivision security services.", false, "Monthly", "Security Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, new DateTime(2025, 4, 14, 13, 28, 52, 887, DateTimeKind.Utc).AddTicks(2366), 500.00m, "Monthly fee for streetlight maintenance.", false, "Monthly", "Street Lighting Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, new DateTime(2025, 4, 14, 13, 28, 52, 887, DateTimeKind.Utc).AddTicks(2367), 800.00m, "Annual fee for maintaining the clubhouse and shared spaces.", false, "Yearly", "Clubhouse Maintenance Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, new DateTime(2025, 4, 14, 13, 28, 52, 887, DateTimeKind.Utc).AddTicks(2369), 5000.00m, "Annual contribution for property tax remittance.", false, "Yearly", "Property Tax Contribution", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, new DateTime(2025, 4, 14, 13, 28, 52, 887, DateTimeKind.Utc).AddTicks(2371), 1200.00m, "Quarterly contribution for major subdivision repairs.", false, "Quarterly", "Sinking Fund Contribution", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, new DateTime(2025, 4, 14, 13, 28, 52, 887, DateTimeKind.Utc).AddTicks(2372), 600.00m, "Quarterly fee for pest control services in the subdivision.", false, "Quarterly", "Pest Control Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, new DateTime(2025, 4, 14, 13, 28, 52, 887, DateTimeKind.Utc).AddTicks(2373), 1000.00m, "Annual fee for road maintenance and repairs.", false, "Yearly", "Road Maintenance Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                    { 1, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9432), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9430), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9431), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9432), "111" },
                    { 2, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9437), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9436), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9436), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9437), "112" },
                    { 3, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9446), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9438), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9445), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9446), "113" },
                    { 4, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9448), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9447), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9447), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9448), "114" },
                    { 5, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9450), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9449), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9449), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9450), "115" },
                    { 6, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9452), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9451), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9451), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9452), "116" },
                    { 7, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9454), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9453), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9453), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9454), "117" },
                    { 8, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9456), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9455), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9455), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9456), "118" },
                    { 9, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9458), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9457), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9457), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9458), "119" },
                    { 10, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9460), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9459), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9459), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9460), "120" },
                    { 11, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9532), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9531), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9532), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9533), "121" },
                    { 12, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9535), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9534), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9534), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9535), "122" },
                    { 13, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9537), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9536), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9536), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9537), "123" },
                    { 14, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9539), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9538), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9538), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9539), "124" },
                    { 15, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9541), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9540), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9540), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9541), "125" },
                    { 16, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9543), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9542), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9542), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9543), "126" },
                    { 17, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9545), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9544), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9544), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9545), "127" },
                    { 18, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9547), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9546), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9546), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9547), "128" },
                    { 19, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9549), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9548), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9548), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9549), "129" },
                    { 20, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9551), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9550), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9550), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9551), "130" },
                    { 21, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9553), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9552), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9552), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9553), "131" },
                    { 22, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9555), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9554), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9554), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9555), "132" },
                    { 23, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9557), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9556), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9556), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9557), "133" },
                    { 24, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9559), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9558), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9558), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9559), "134" },
                    { 25, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9560), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9560), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9560), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9561), "135" },
                    { 26, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9562), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9562), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9562), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9563), "136" },
                    { 27, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9564), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9564), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9564), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9565), "137" },
                    { 28, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9568), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9567), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9567), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9568), "138" },
                    { 29, null, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9570), null, true, false, false, false, new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9569), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9569), new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9570), "139" }
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
                    { 1, "admin", new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(7483), "123 Main St", 6, "Jane Doe", "1234567890", "Spouse", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Security Officer", 25000.00m, null, null, "100" },
                    { 2, "admin", new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(7495), "456 Oak St", 5, "John Smith", "0987654321", "Brother", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Maintenance Supervisor", 30000.00m, null, null, "102" },
                    { 3, "admin", new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(7502), "789 Pine St", 3, "Alice Brown", "5678901234", "Sister", new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "System Administrator", 35000.00m, null, null, "103" },
                    { 4, "admin", new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(7508), "987 Cedar St", 2, "Bob White", "2345678901", "Father", new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Finance Manager", 40000.00m, null, null, "104" },
                    { 5, "admin", new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(7515), "654 Birch St", 0, "Chris Green", "3456789012", "Friend", new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Amenities Coordinator", 28000.00m, null, null, "105" },
                    { 6, "admin", new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(7521), "321 Maple St", 1, "Diana Blue", "4567890123", "Cousin", new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Customer Service Representative", 26000.00m, null, null, "106" },
                    { 7, "admin", new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(7528), "159 Elm St", 4, "Evan Red", "5678901234", "Uncle", new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Head Gardener", 27000.00m, null, null, "107" },
                    { 8, "admin", new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(7532), "123 Main St", 6, "Jane Doe", "1234567890", "Spouse", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Security Officer", 25000.00m, null, null, "108" },
                    { 9, "admin", new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9203), "456 Oak St", 5, "John Smith", "0987654321", "Brother", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Maintenance Supervisor", 30000.00m, null, null, "109" },
                    { 10, "admin", new DateTime(2025, 4, 14, 13, 28, 54, 651, DateTimeKind.Utc).AddTicks(9274), "789 Pine St", 3, "Alice Brown", "5678901234", "Sister", new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "System Administrator", 35000.00m, null, null, "110" }
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
