using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class ADFERWER : Migration
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
                    RatePerHour = table.Column<int>(type: "int", nullable: true),
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
                    BillAssignModelBillAssignId = table.Column<int>(type: "int", nullable: true),
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
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SelectedTimeSlotIndex = table.Column<int>(type: "int", nullable: false)
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsArrived = table.Column<bool>(type: "bit", nullable: true),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsExited = table.Column<bool>(type: "bit", nullable: true),
                    ExitDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                name: "BillFee",
                columns: table => new
                {
                    BillFeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillAssignmentId = table.Column<int>(type: "int", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillFee", x => x.BillFeeID);
                    table.ForeignKey(
                        name: "FK_BillFee_BillAssignment_BillAssignmentId",
                        column: x => x.BillAssignmentId,
                        principalTable: "BillAssignment",
                        principalColumn: "BillAssignmentId");
                });

            migrationBuilder.CreateTable(
                name: "BillPayment",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillId = table.Column<int>(type: "int", nullable: true),
                    BillAssignmentId = table.Column<int>(type: "int", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    BillAssignmentModelBillAssignmentId = table.Column<int>(type: "int", nullable: true),
                    BillModelBillId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillPayment", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_BillPayment_BillAssignment_BillAssignmentId",
                        column: x => x.BillAssignmentId,
                        principalTable: "BillAssignment",
                        principalColumn: "BillAssignmentId");
                    table.ForeignKey(
                        name: "FK_BillPayment_BillAssignment_BillAssignmentModelBillAssignmentId",
                        column: x => x.BillAssignmentModelBillAssignmentId,
                        principalTable: "BillAssignment",
                        principalColumn: "BillAssignmentId");
                    table.ForeignKey(
                        name: "FK_BillPayment_Bills_BillId",
                        column: x => x.BillId,
                        principalTable: "Bills",
                        principalColumn: "BillId");
                    table.ForeignKey(
                        name: "FK_BillPayment_Bills_BillModelBillId",
                        column: x => x.BillModelBillId,
                        principalTable: "Bills",
                        principalColumn: "BillId");
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
                columns: new[] { "Id", "AccessFailedCount", "AdminProfilesAdminId", "BillAssignModelBillAssignId", "BillAssignmentModelBillAssignmentId", "Bio", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FacebookProfile", "FirstName", "Gender", "HomeownerProfilesHomeownerId", "IsActiveUser", "IsApproved", "IsBirthdayPublic", "IsGenderPublic", "LastName", "LinkedInProfile", "LockoutEnabled", "LockoutEnd", "MakeFacebookPublic", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "ProfilePicturePath", "SecurityStamp", "StaffProfilesStaffId", "TwitterProfile", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "100", 0, null, null, null, null, "682c2a72-dfe4-49cf-8642-cf319d7730b3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "elon.musk@example.com", true, null, "Elon", null, null, true, false, false, false, "Musk", null, false, null, false, "ELON.MUSK@EXAMPLE.COM", "ELON.MUSK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDjSRWyE4azK5W5h4g3DhtD66ZY1bXY2gzkMvbODtYSoItfft+y0OR8zBCJz2SMzMw==", null, false, null, "wwwroot/images/picc.png", "9873177b-ca2d-4180-abdc-a1fb9e30757c", null, null, false, "elon.musk@example.com" },
                    { "102", 0, null, null, null, null, "b7b6f733-3431-4a1b-959a-7411eeb3ece4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bill.gates@example.com", true, null, "Bill", null, null, true, false, false, false, "Gates", null, false, null, false, "BILL.GATES@EXAMPLE.COM", "BILL.GATES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJWymfBg8sAqfm6fJ/WjAC5wnNQwozjOBxgfkTdiuRZlGLWqHZfNJV8qlRuRlJ/Rvg==", null, false, null, null, "1a87b2ae-228c-4849-aacb-07a221d5ecc9", null, null, false, "bill.gates@example.com" },
                    { "103", 0, null, null, null, null, "d4da317e-06e0-405a-9969-95fe4a962670", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mark.zuckerberg@example.com", true, null, "Mark", null, null, true, false, false, false, "Zuckerberg", null, false, null, false, "MARK.ZUCKERBERG@EXAMPLE.COM", "MARK.ZUCKERBERG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDvKlNJr9HZ9c3qRW9awMO7NvNaRTxYjXa62pNIpoFTeEetDAnLot7TklMOUhQzE4A==", null, false, null, null, "4670ee46-8be1-4adc-bd31-63f41cc72384", null, null, false, "mark.zuckerberg@example.com" },
                    { "104", 0, null, null, null, null, "9f2d1549-884a-4665-94a4-28c409d9bfd3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sundar.pichai@example.com", true, null, "Sundar", null, null, true, false, false, false, "Pichai", null, false, null, false, "SUNDAR.PICHAI@EXAMPLE.COM", "SUNDAR.PICHAI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEhmmlovqJQk+z3CdIZ/stA8JRMr62GHGbheHgf/m0xU4/u9q1MVBcGe4GAjZ0kuyQ==", null, false, null, null, "94bf9a05-23b1-403e-80f9-f781a09dac53", null, null, false, "sundar.pichai@example.com" },
                    { "105", 0, null, null, null, null, "74c97231-5a35-4308-8f91-d6e1f9f3c0e8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tim.cook@example.com", true, null, "Tim", null, null, true, false, false, false, "Cook", null, false, null, false, "TIM.COOK@EXAMPLE.COM", "TIM.COOK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKc9HUeJste0RTRnGOns6RBSTcB1F+Jzze66XCVwagOWyLbm5uGWr0hIsigJ3/H13g==", null, false, null, null, "bfdb9847-6c5f-48ea-9486-6b9937f7c353", null, null, false, "tim.cook@example.com" },
                    { "106", 0, null, null, null, null, "4690793e-1a30-4b19-80f1-510d7731cad8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "satya.nadella@example.com", true, null, "Satya", null, null, true, false, false, false, "Nadella", null, false, null, false, "SATYA.NADELLA@EXAMPLE.COM", "SATYA.NADELLA@EXAMPLE.COM", "AQAAAAIAAYagAAAAENidvtlya0B6NE6CPzvcDvCTehW6X48lGX4JIX1zzRwMmMNEd8BAsHS72lhhTbD70Q==", null, false, null, null, "bcee0728-6a63-4800-b279-f1728c7d5182", null, null, false, "satya.nadella@example.com" },
                    { "107", 0, null, null, null, null, "938fcbc9-4a59-4076-ba9f-608357aa935b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jack.dorsey@example.com", true, null, "Jack", null, null, true, false, false, false, "Dorsey", null, false, null, false, "JACK.DORSEY@EXAMPLE.COM", "JACK.DORSEY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF6UwDIfr+eRlrip9sNHSlHcY2zW/wrtwpLdlImPPuRMQ/gCAJCM+4QoK5TBp0q66Q==", null, false, null, null, "c1c1e7d8-9d45-478b-ab01-d6f2e021e0e6", null, null, false, "jack.dorsey@example.com" },
                    { "108", 0, null, null, null, null, "0f39651d-53d3-417f-8df6-a477af126d69", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "larry.page@example.com", true, null, "Larry", null, null, true, false, false, false, "Page", null, false, null, false, "LARRY.PAGE@EXAMPLE.COM", "LARRY.PAGE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFMv967Cu2/B8Z6vQ9JRCkb/GOTPjBLG3kJAIY1OXU4cgGDQ6c60GC5c5j947wPasA==", null, false, null, null, "4ce91fd7-029a-4690-8886-f2fe48f8aef8", null, null, false, "larry.page@example.com" },
                    { "109", 0, null, null, null, null, "1324bfd1-4f9b-4d86-a065-ba533f0d64c0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sergey.brin@example.com", true, null, "Sergey", null, null, true, false, false, false, "Brin", null, false, null, false, "SERGEY.BRIN@EXAMPLE.COM", "SERGEY.BRIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGewt9cysM2IddUwXg/sKqGj//uKatJqlIXyb6gCPPOJfbY090hUQh538fZ73X4Xuw==", null, false, null, null, "db651b48-eadf-45ce-838c-823a2cc15653", null, null, false, "sergey.brin@example.com" },
                    { "110", 0, null, null, null, null, "3e854b23-9b28-4fa8-8dd3-951f2f2e3eb7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "steve.jobs@example.com", true, null, "Steve", null, null, true, false, false, false, "Jobs", null, false, null, false, "STEVE.JOBS@EXAMPLE.COM", "STEVE.JOBS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMhXIUco8OflvsBNb9CRm70+rIvSZccZd4SkKnXy+ZaUmU2cYyix52eP0JftaP0Lew==", null, false, null, null, "3456eced-5b64-47c8-b044-ab3f80534d1e", null, null, false, "steve.jobs@example.com" },
                    { "111", 0, null, null, null, null, "ccf54fd5-d74d-4c08-9dd4-af18b6987a7f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sheryl.sandberg@example.com", true, null, "Sheryl", null, null, true, false, false, false, "Sandberg", null, false, null, false, "SHERYL.SANDBERG@EXAMPLE.COM", "SHERYL.SANDBERG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEG9W82NWJ968x/J1ZKxHdUnqJv6ng6uu4Yc6OEUDbldPOqo98DBI2+DTGHisAliSFQ==", null, false, null, null, "16012d51-0153-429f-b515-62155351ee08", null, null, false, "sheryl.sandberg@example.com" },
                    { "112", 0, null, null, null, null, "f9232934-179e-45bd-a3d2-3067dda0ef5d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reed.hastings@example.com", true, null, "Reed", null, null, true, false, false, false, "Hastings", null, false, null, false, "REED.HASTINGS@EXAMPLE.COM", "REED.HASTINGS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEImlJ9pO/VFXIzb9Or0VZyXYUfLflF/kYL+Ax6wRMfuf6SpzT1FQXGzKDX6ZMIiPGw==", null, false, null, null, "650e3e60-9437-4615-9c9d-05a6f4b23138", null, null, false, "reed.hastings@example.com" },
                    { "113", 0, null, null, null, null, "8d69f226-46fd-4683-bf90-b0c7121ddc51", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "marissa.mayer@example.com", true, null, "Marissa", null, null, true, false, false, false, "Mayer", null, false, null, false, "MARISSA.MAYER@EXAMPLE.COM", "MARISSA.MAYER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGQJXhRO68GhPCXfqZjmVjqcycKuk08+LRD5f00NlDyyUKXxVyMYLd/X4oihvXU8MA==", null, false, null, null, "95df40e6-a45a-4737-981e-f30f6dcb41bb", null, null, false, "marissa.mayer@example.com" },
                    { "114", 0, null, null, null, null, "543416d0-6818-4179-9a11-f8ecbeb999b0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "elizabeth.holmes@example.com", true, null, "Elizabeth", null, null, true, false, false, false, "Holmes", null, false, null, false, "ELIZABETH.HOLMES@EXAMPLE.COM", "ELIZABETH.HOLMES@EXAMPLE.COM", "AQAAAAIAAYagAAAAELBzXPaUAp9oQKM35uTOK4A9zbuIyQ78mBovRML9rcBeKaERhdOaodAUt1YxO34c2A==", null, false, null, null, "adec1a07-884c-46cf-8a42-679633446304", null, null, false, "elizabeth.holmes@example.com" },
                    { "115", 0, null, null, null, null, "9abe64c5-b49d-4fc1-ba42-2adab615bd42", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "susan.wojcicki@example.com", true, null, "Susan", null, null, true, false, false, false, "Wojcicki", null, false, null, false, "SUSAN.WOJCICKI@EXAMPLE.COM", "SUSAN.WOJCICKI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE8toDo9IR64lAzPwueSdiwT4htWHWeoSjJ9pLWW0xi1G0+iBOukbd8dqoj/bPmmMA==", null, false, null, null, "dd8be479-7797-44b5-9257-df42ad006f88", null, null, false, "susan.wojcicki@example.com" },
                    { "116", 0, null, null, null, null, "a84e0d51-3523-4e3e-bf8e-ef1ae58b4607", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tim.arnold@example.com", true, null, "Tim", null, null, true, false, false, false, "Arnold", null, false, null, false, "TIM.ARNOLD@EXAMPLE.COM", "TIM.ARNOLD@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKrgn+WwIHQ/vukLzmJC7KoOj9qyDkMEyPhzqp4gHymwan0mN2sKHr194qKLMm11/g==", null, false, null, null, "e53306d4-14db-47a7-9713-2ffbbef5c4c6", null, null, false, "tim.arnold@example.com" },
                    { "117", 0, null, null, null, null, "50f05342-6170-4510-9bbb-37eb4e58a56a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.iger@example.com", true, null, "Bob", null, null, true, false, false, false, "Iger", null, false, null, false, "BOB.IGER@EXAMPLE.COM", "BOB.IGER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHRQkErJtN1d2sH0XYT+c/Z4fWqQibjcLYDhzBXGNPKkS1TXY3TVLfnfZimgo+JAew==", null, false, null, null, "64da48f7-aacb-43aa-900c-f39de4afc588", null, null, false, "bob.iger@example.com" },
                    { "118", 0, null, null, null, null, "697e4b94-eed8-4dda-a551-097db7789999", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "larry.ellison@example.com", true, null, "Larry", null, null, true, false, false, false, "Ellison", null, false, null, false, "LARRY.ELLISON@EXAMPLE.COM", "LARRY.ELLISON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPDK/o4Lsk5yUn6sSOf1b9TGexYT8duSk98twXZ7eq5ffDqvyBwnUV2ibn8dHwrOSw==", null, false, null, null, "29aec057-303f-4458-be02-3a21763abddf", null, null, false, "larry.ellison@example.com" },
                    { "119", 0, null, null, null, null, "9e076114-539b-49c6-b75b-27cb66df84e3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "richard.branson@example.com", true, null, "Richard", null, null, true, false, false, false, "Branson", null, false, null, false, "RICHARD.BRANSON@EXAMPLE.COM", "RICHARD.BRANSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOkXf//W7WzAA0zbVyMIL1kK+m0N6sVb3zQvTDbl5higkT7qkwceSy2uQat6CD0fcA==", null, false, null, null, "9f35aaf8-ecdd-45c7-b0cc-91e1facb3b1f", null, null, false, "richard.branson@example.com" },
                    { "120", 0, null, null, null, null, "5bbe580a-a83d-4d45-b2bd-6868709db028", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jack.ma@example.com", true, null, "Jack", null, null, true, false, false, false, "Ma", null, false, null, false, "JACK.MA@EXAMPLE.COM", "JACK.MA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEvUr+uolsPJX2p8H05Vx/a0DY0wJuqxWWzYBk9/PJAhWC0b7B4KIRib+yzWSkNiIA==", null, false, null, null, "c4d29559-c81b-4882-a8c8-61c5c3fa23f2", null, null, false, "jack.ma@example.com" },
                    { "121", 0, null, null, null, null, "b4a2cc40-5c1c-4bad-844e-8f8212c5bae6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "warren.buffett@example.com", true, null, "Warren", null, null, true, false, false, false, "Buffett", null, false, null, false, "WARREN.BUFFETT@EXAMPLE.COM", "WARREN.BUFFETT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOBGALVAVGAvhXQAu0ftFFG2sRiT3yuDo2VIOi8fgJUb/gOzfm4Mnzh2QkczrTYw1Q==", null, false, null, null, "eaf30c30-e7c9-4407-8811-03b77b1f1ef4", null, null, false, "warren.buffett@example.com" },
                    { "122", 0, null, null, null, null, "064b2a35-7594-4012-b0f0-8e97dca9c4d6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mary.barrett@example.com", true, null, "Mary", null, null, true, false, false, false, "Barrett", null, false, null, false, "MARY.BARRETT@EXAMPLE.COM", "MARY.BARRETT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJLwo2pKULB7Zb1YgX3SIJrpl9kOL1KvkMnsg4MxDFjbUJCd3sMK8+zdvbWB2AGyqg==", null, false, null, null, "f36618e2-d4b0-4bcf-937c-04d3e22134c5", null, null, false, "mary.barrett@example.com" },
                    { "123", 0, null, null, null, null, "0ff0b86b-36db-4dd4-a774-7047ba780473", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ginni.rometty@example.com", true, null, "Ginni", null, null, true, false, false, false, "Rometty", null, false, null, false, "GINNI.ROMETTY@EXAMPLE.COM", "GINNI.ROMETTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAESNVaW/ze9Lmlu97oS0QDmaWAEMOa9kt7o6idyROiwU43u4fFmwte6mRmZJaoFRg==", null, false, null, null, "329a54cf-1bfd-43f5-9380-1ec63a6fa430", null, null, false, "ginni.rometty@example.com" },
                    { "124", 0, null, null, null, null, "37dcbb2e-bff7-4126-aa22-d32ad352b013", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mark.benioff@example.com", true, null, "Mark", null, null, true, false, false, false, "Benioff", null, false, null, false, "MARK.BENIOFF@EXAMPLE.COM", "MARK.BENIOFF@EXAMPLE.COM", "AQAAAAIAAYagAAAAECMDObOBu/32FuZk2NY3gU1VooFQIQZnIjTvLcywjaaia2jVkWHUhsny+wH8ClXKVA==", null, false, null, null, "be4dfc77-b827-45c0-bb9f-f9369c8ae857", null, null, false, "mark.benioff@example.com" },
                    { "125", 0, null, null, null, null, "03078619-10fd-4e9e-8050-dfbbd32e52cf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kevin.systrom@example.com", true, null, "Kevin", null, null, true, false, false, false, "Systrom", null, false, null, false, "KEVIN.SYSTROM@EXAMPLE.COM", "KEVIN.SYSTROM@EXAMPLE.COM", "AQAAAAIAAYagAAAAENYMEqyGI3/xKZfexiT0pn6OsT2Zc1WE4pvDgJPYDjet+DOWgA+WVWvdHAOfAjPgMA==", null, false, null, null, "fdae9e4f-b89c-4205-834f-c53804b31a13", null, null, false, "kevin.systrom@example.com" },
                    { "126", 0, null, null, null, null, "58fdc678-3021-4438-9df7-67fa6b253175", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "evan.spiegel@example.com", true, null, "Evan", null, null, true, false, false, false, "Spiegel", null, false, null, false, "EVAN.SPIEGEL@EXAMPLE.COM", "EVAN.SPIEGEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMag4LwCq50kj5a8u3cSYAyvvA6xWEJUNQxdjG78kwy9PD+ofVSj+dRwvx0xcZ20AQ==", null, false, null, null, "7333c08f-19fb-4b5f-a227-3d966971a8ac", null, null, false, "evan.spiegel@example.com" },
                    { "127", 0, null, null, null, null, "41f14f35-6db1-44fb-9398-ea67fd19a487", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jan.koum@example.com", true, null, "Jan", null, null, true, false, false, false, "Koum", null, false, null, false, "JAN.KOUM@EXAMPLE.COM", "JAN.KOUM@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMeQsOwcn3JU8pZryLKzSpECRjtD3NHc518AgEE9Co0XaKTR8Zbm60OP8etC+Z5w9A==", null, false, null, null, "59a92561-88ba-4c5d-afb8-9972c5a776d9", null, null, false, "jan.koum@example.com" },
                    { "128", 0, null, null, null, null, "1d9a0e0d-2ae5-467c-9969-98dbd6b71c7e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "janice.fang@example.com", true, null, "Janice", null, null, true, false, false, false, "Fang", null, false, null, false, "JANICE.FANG@EXAMPLE.COM", "JANICE.FANG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOFhxOPfBDJIoudFjw/9lAkkapiSTKHZbmR7Yrpc6GdItZqhSLM7kPncBSPWf1E5HQ==", null, false, null, null, "9a74a432-4bb7-462c-8b3b-3f11f94fd5e7", null, null, false, "janice.fang@example.com" },
                    { "129", 0, null, null, null, null, "2cc43315-31fc-446a-8a02-c43745c6538a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sergey.gladkikh@example.com", true, null, "Sergey", null, null, true, false, false, false, "Gladkikh", null, false, null, false, "SERGEY.GLADKIKH@EXAMPLE.COM", "SERGEY.GLADKIKH@EXAMPLE.COM", "AQAAAAIAAYagAAAAENWsAvGthFbJ9TmVVP9NopdIFU2Le2yo2prtj7/RAjUpabJlRXktLuUFeBrk8QWD7Q==", null, false, null, null, "5bf47ac6-d799-465d-9655-10df433307f5", null, null, false, "sergey.gladkikh@example.com" },
                    { "130", 0, null, null, null, null, "4535cd25-2e44-4a21-894d-c2836c970eea", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tony.hsieh@example.com", true, null, "Tony", null, null, true, false, false, false, "Hsieh", null, false, null, false, "TONY.HSIEH@EXAMPLE.COM", "TONY.HSIEH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEApNAYjOgsOEH9SOY5dCQBMv7MG8+KQv+1ad7tTxW2+DAMeRwKxcSQPZESUGwhM63A==", null, false, null, null, "8883960f-0031-4520-94a1-458891fdd98c", null, null, false, "tony.hsieh@example.com" },
                    { "131", 0, null, null, null, null, "09c79613-7904-498f-b75b-8cc1b5bad0ea", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "richard.hyne@example.com", true, null, "Richard", null, null, true, false, false, false, "Hyne", null, false, null, false, "RICHARD.HYNE@EXAMPLE.COM", "RICHARD.HYNE@EXAMPLE.COM", "AQAAAAIAAYagAAAAELP1TF5gPudw2lHwFtRHWpIyUYNXzdNh2Em82F2p+gzaxfx7kEd+h81/Tzil+jb/9Q==", null, false, null, null, "fd8a3d26-3d62-4b73-b29e-5fa403d51651", null, null, false, "richard.hyne@example.com" },
                    { "132", 0, null, null, null, null, "1d54f5c7-7bb7-413c-8615-354dd53be8de", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "peter.thiel@example.com", true, null, "Peter", null, null, true, false, false, false, "Thiel", null, false, null, false, "PETER.THIEL@EXAMPLE.COM", "PETER.THIEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP1NtYaMwlLjzxdWDCZzwvR0G3w86X6PMV442zT+S0mN260vHb3tlO+CGWQN7tumVw==", null, false, null, null, "38273b19-dbe5-4633-87f6-68a38aeee573", null, null, false, "peter.thiel@example.com" },
                    { "133", 0, null, null, null, null, "1665f853-91bc-4c90-acd4-49c306a06563", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "steve.wozniak@example.com", true, null, "Steve", null, null, true, false, false, false, "Wozniak", null, false, null, false, "STEVE.WOZNIAK@EXAMPLE.COM", "STEVE.WOZNIAK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGR/v2e63hWTjCjxP2QYyRIPJKIUTOleduTPxVBX4jvOd5LmOe9zNyTd7Z7iVBdmnA==", null, false, null, null, "3c39db95-cb8f-4831-b67d-fbbd32106bd4", null, null, false, "steve.wozniak@example.com" },
                    { "134", 0, null, null, null, null, "4bd6078b-dffb-4bea-add9-52c4a698a0c1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.carmack@example.com", true, null, "John", null, null, true, false, false, false, "Carmack", null, false, null, false, "JOHN.CARMACK@EXAMPLE.COM", "JOHN.CARMACK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIhnrHzjhbnrQgkCmP/XMI/SWQiR84EFztxGurBrsEUfHgJNTsTPMG/PuxVWCYUaQQ==", null, false, null, null, "d8c3924d-3983-48d5-857e-658bf641c36d", null, null, false, "john.carmack@example.com" },
                    { "135", 0, null, null, null, null, "c317fc55-29e6-4373-9351-98441e45eb98", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mike.zyda@example.com", true, null, "Mike", null, null, true, false, false, false, "Zyda", null, false, null, false, "MIKE.ZYDA@EXAMPLE.COM", "MIKE.ZYDA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKQ9B4gh5DFTYCJrLn1f00JVu+9XfBylYC69HgpzZuTEqVpCrFLAST18J2xbbhCujg==", null, false, null, null, "bf691683-abe1-4e75-bcf4-2c17d2418682", null, null, false, "mike.zyda@example.com" },
                    { "136", 0, null, null, null, null, "17da5071-798e-4cb8-8dfc-ba08611d75d9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cheryl.sandberg@example.com", true, null, "Cheryl", null, null, true, false, false, false, "Sandberg", null, false, null, false, "CHERYL.SANDBERG@EXAMPLE.COM", "CHERYL.SANDBERG@EXAMPLE.COM", "AQAAAAIAAYagAAAAENXNTx6n4ZtpeE2Gecud+HsEbYQXqULhkYEX1gnY14EZaVIu+2i/fyLs6lBSaonmlw==", null, false, null, null, "9a2dc903-a410-4a91-ad31-45730430c029", null, null, false, "cheryl.sandberg@example.com" },
                    { "137", 0, null, null, null, null, "af35a8ac-993a-4728-ab17-9db62f9874ae", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "karen.smith@example.com", true, null, "Karen", null, null, true, false, false, false, "Smith", null, false, null, false, "KAREN.SMITH@EXAMPLE.COM", "KAREN.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ/7zr/xLtqdOmsN/XnBDBy03ARzy7WSoi4SpL4eelG22XA31rL+lRSRwRDpTu26hA==", null, false, null, null, "34a4f2ce-6c0f-46bb-931d-a18025ddd589", null, null, false, "karen.smith@example.com" },
                    { "138", 0, null, null, null, null, "2813d7c3-2c80-4039-a7e9-e01de5bd17c7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.lee@example.com", true, null, "David", null, null, true, false, false, false, "Lee", null, false, null, false, "DAVID.LEE@EXAMPLE.COM", "DAVID.LEE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPObxbTaE34o8H+lFmGauGy4CMmSjBFT+qV2tE75cvVokqXpfqhtViMcYKx6IRLDhQ==", null, false, null, null, "33b19ee2-53d7-4639-ad09-1826f337ad97", null, null, false, "david.lee@example.com" },
                    { "139", 0, null, null, null, null, "744cee08-d4a5-4822-8ed4-80b3abdbec7c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "james.taylor@example.com", true, null, "James", null, null, true, false, false, false, "Taylor", null, false, null, false, "JAMES.TAYLOR@EXAMPLE.COM", "JAMES.TAYLOR@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEYkj1Qc1ZrVivTWOHJfVttX4w+0Cbw3HHyOXiQrPHG/Ms/f2ZtwfJ0tgkPRb8cAYg==", null, false, null, null, "53afc29d-fc48-42d5-b65c-d8be19d91b19", null, null, false, "james.taylor@example.com" }
                });

            migrationBuilder.InsertData(
                table: "BillItems",
                columns: new[] { "BillItemsID", "AddedBy", "AddedOn", "Amount", "BillItemsModelBillItemsID", "Description", "IsDeleted", "PaymentDuration", "PaymentName", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 5, 9, 11, 56, 52, 106, DateTimeKind.Utc).AddTicks(2764), 2000.00m, null, "Monthly HOA dues for maintenance, security, and amenities.", false, "Monthly", "Homeowners Association (HOA) Fees", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(2025, 5, 9, 11, 56, 52, 106, DateTimeKind.Utc).AddTicks(2777), 350.00m, null, "Monthly water consumption charges.", false, "Monthly", "Water Bill", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, new DateTime(2025, 5, 9, 11, 56, 52, 106, DateTimeKind.Utc).AddTicks(2780), 200.00m, null, "Monthly fee for waste disposal services.", false, "Monthly", "Garbage Collection Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, new DateTime(2025, 5, 9, 11, 56, 52, 106, DateTimeKind.Utc).AddTicks(2783), 1000.00m, null, "Monthly fee for 24/7 subdivision security services.", false, "Monthly", "Security Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, new DateTime(2025, 5, 9, 11, 56, 52, 106, DateTimeKind.Utc).AddTicks(2785), 300.00m, null, "Monthly fee for streetlight maintenance and electricity.", false, "Monthly", "Street Lighting Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, new DateTime(2025, 5, 9, 11, 56, 52, 106, DateTimeKind.Utc).AddTicks(2787), 500.00m, null, "Monthly fee for clubhouse upkeep and utilities.", false, "Monthly", "Clubhouse Maintenance Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, new DateTime(2025, 5, 9, 11, 56, 52, 106, DateTimeKind.Utc).AddTicks(2788), 1000.00m, null, "Monthly contribution toward shared property tax obligations.", false, "Monthly", "Property Tax Contribution", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, new DateTime(2025, 5, 9, 11, 56, 52, 106, DateTimeKind.Utc).AddTicks(2790), 800.00m, null, "Monthly contribution to the long-term repair and reserve fund.", false, "Monthly", "Sinking Fund Contribution", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, new DateTime(2025, 5, 9, 11, 56, 52, 106, DateTimeKind.Utc).AddTicks(2792), 250.00m, null, "Monthly fee for regular pest control services.", false, "Monthly", "Pest Control Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, new DateTime(2025, 5, 9, 11, 56, 52, 106, DateTimeKind.Utc).AddTicks(2793), 700.00m, null, "Monthly fee for road repair and upkeep.", false, "Monthly", "Road Maintenance Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                    { 1, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9724), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9722), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9723), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9724), "111" },
                    { 2, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9727), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9726), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9727), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9728), "112" },
                    { 3, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9730), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9729), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9729), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9730), "113" },
                    { 4, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9732), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9731), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9732), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9733), "114" },
                    { 5, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9735), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9734), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9734), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9735), "115" },
                    { 6, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9737), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9736), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9737), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9738), "116" },
                    { 7, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9740), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9739), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9739), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9740), "117" },
                    { 8, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9742), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9741), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9741), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9742), "118" },
                    { 9, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9744), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9743), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9744), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9745), "119" },
                    { 10, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9747), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9746), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9746), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9747), "120" },
                    { 11, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9749), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9748), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9748), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9749), "121" },
                    { 12, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9751), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9750), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9751), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9752), "122" },
                    { 13, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9754), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9753), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9753), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9754), "123" },
                    { 14, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9756), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9755), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9755), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9756), "124" },
                    { 15, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9758), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9757), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9758), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9759), "125" },
                    { 16, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9760), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9759), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9760), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9761), "126" },
                    { 17, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9763), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9762), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9762), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9763), "127" },
                    { 18, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9765), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9764), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9764), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9765), "128" },
                    { 19, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9767), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9767), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9768), "129" },
                    { 20, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9770), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9769), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9769), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9770), "130" },
                    { 21, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9907), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9906), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9906), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9907), "131" },
                    { 22, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9910), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9909), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9909), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9910), "132" },
                    { 23, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9912), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9911), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9911), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9912), "133" },
                    { 24, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9914), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9913), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9913), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9914), "134" },
                    { 25, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9920), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9919), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9919), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9920), "135" },
                    { 26, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9925), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9924), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9924), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9925), "136" },
                    { 27, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9927), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9926), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9927), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9928), "137" },
                    { 28, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9930), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9929), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9929), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9930), "138" },
                    { 29, null, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9932), null, true, false, false, false, new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9931), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9931), new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9932), "139" }
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
                    { 1, "admin", new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9384), "123 Main St", 6, "Jane Doe", "1234567890", "Spouse", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Security Officer", 25000.00m, null, null, "100" },
                    { 2, "admin", new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9396), "456 Oak St", 5, "John Smith", "0987654321", "Brother", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Maintenance Supervisor", 30000.00m, null, null, "102" },
                    { 3, "admin", new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9409), "789 Pine St", 3, "Alice Brown", "5678901234", "Sister", new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "System Administrator", 35000.00m, null, null, "103" },
                    { 4, "admin", new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9418), "987 Cedar St", 2, "Bob White", "2345678901", "Father", new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Finance Manager", 40000.00m, null, null, "104" },
                    { 5, "admin", new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9426), "654 Birch St", 0, "Chris Green", "3456789012", "Friend", new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Amenities Coordinator", 28000.00m, null, null, "105" },
                    { 6, "admin", new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9434), "321 Maple St", 1, "Diana Blue", "4567890123", "Cousin", new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Customer Service Representative", 26000.00m, null, null, "106" },
                    { 7, "admin", new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9441), "159 Elm St", 4, "Evan Red", "5678901234", "Uncle", new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Head Gardener", 27000.00m, null, null, "107" },
                    { 8, "admin", new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9447), "123 Main St", 6, "Jane Doe", "1234567890", "Spouse", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Security Officer", 25000.00m, null, null, "108" },
                    { 9, "admin", new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9455), "456 Oak St", 5, "John Smith", "0987654321", "Brother", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Maintenance Supervisor", 30000.00m, null, null, "109" },
                    { 10, "admin", new DateTime(2025, 5, 9, 11, 56, 54, 231, DateTimeKind.Utc).AddTicks(9650), "789 Pine St", 3, "Alice Brown", "5678901234", "Sister", new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "System Administrator", 35000.00m, null, null, "110" }
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
                name: "IX_AspNetUsers_BillAssignModelBillAssignId",
                table: "AspNetUsers",
                column: "BillAssignModelBillAssignId");

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
                name: "IX_BillAssign_UserId",
                table: "BillAssign",
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
                name: "IX_BillFee_BillAssignmentId",
                table: "BillFee",
                column: "BillAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BillItems_BillItemsModelBillItemsID",
                table: "BillItems",
                column: "BillItemsModelBillItemsID");

            migrationBuilder.CreateIndex(
                name: "IX_BillPayment_BillAssignmentId",
                table: "BillPayment",
                column: "BillAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BillPayment_BillAssignmentModelBillAssignmentId",
                table: "BillPayment",
                column: "BillAssignmentModelBillAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BillPayment_BillId",
                table: "BillPayment",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_BillPayment_BillModelBillId",
                table: "BillPayment",
                column: "BillModelBillId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_UserId",
                table: "Bills",
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
                name: "FK_AspNetUsers_BillAssign_BillAssignModelBillAssignId",
                table: "AspNetUsers",
                column: "BillAssignModelBillAssignId",
                principalTable: "BillAssign",
                principalColumn: "BillAssignId");

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
                name: "FK_BillAssign_AspNetUsers_UserId",
                table: "BillAssign");

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
                name: "BillFee");

            migrationBuilder.DropTable(
                name: "BillItems");

            migrationBuilder.DropTable(
                name: "BillPayment");

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
                name: "BillAssign");

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
