using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hometown_Application.Migrations
{
    /// <inheritdoc />
    public partial class AEEWRAWREAG : Migration
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
                    { "100", 0, null, null, null, null, "54e1d056-cf64-449a-966d-2708f6ea4900", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "elon.musk@example.com", true, null, "Elon", null, null, true, false, false, false, "Musk", null, false, null, false, "ELON.MUSK@EXAMPLE.COM", "ELON.MUSK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPJjVLvLDaBhg56Bv5V0N7fsHLWYifv55dI7J1g42RrM36Xlpk4HyLOJSEuudGYbbA==", null, false, null, "wwwroot/images/picc.png", "c2815c4f-ffd6-42de-a897-8c582b651877", null, null, false, "elon.musk@example.com" },
                    { "102", 0, null, null, null, null, "9f01029a-0b8a-4c03-9b90-e5cc67f1b888", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bill.gates@example.com", true, null, "Bill", null, null, true, false, false, false, "Gates", null, false, null, false, "BILL.GATES@EXAMPLE.COM", "BILL.GATES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEK4IJWF3K7yWmLIIIM82dbvUXshmzLErmzQeR5palwYYy43LZFLZuyDNpnJxfcSxaA==", null, false, null, null, "931c51fa-8932-4bd2-9781-2afb2f3630ef", null, null, false, "bill.gates@example.com" },
                    { "103", 0, null, null, null, null, "ef3fef54-0b56-4f97-ae6e-8135f42b1b40", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mark.zuckerberg@example.com", true, null, "Mark", null, null, true, false, false, false, "Zuckerberg", null, false, null, false, "MARK.ZUCKERBERG@EXAMPLE.COM", "MARK.ZUCKERBERG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMC28px9Q22apVHkEuPAlxrkYmz9YrchqQ1T9UrcnpM93+m1jg5UtLBxtYrJLDdZNQ==", null, false, null, null, "45eab230-7986-4e70-9dda-a28fe5cfd70e", null, null, false, "mark.zuckerberg@example.com" },
                    { "104", 0, null, null, null, null, "845a95b3-e724-4759-8514-4c24c72b69f4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sundar.pichai@example.com", true, null, "Sundar", null, null, true, false, false, false, "Pichai", null, false, null, false, "SUNDAR.PICHAI@EXAMPLE.COM", "SUNDAR.PICHAI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOxN8Y62EaP4v6aaUrFdvHRcWaRocIjE6utOcq2bwYtON2+fV5QLKxge8YiSTsa4Nw==", null, false, null, null, "df4c1d94-d236-4ba7-b3c8-38cdebc03be8", null, null, false, "sundar.pichai@example.com" },
                    { "105", 0, null, null, null, null, "73fc9466-b9f8-4abf-a38e-db0192e52261", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tim.cook@example.com", true, null, "Tim", null, null, true, false, false, false, "Cook", null, false, null, false, "TIM.COOK@EXAMPLE.COM", "TIM.COOK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEDhxJUuJGgmWTWEj5ffEnto9dmHUD0mYnJ5iMVDCPbSyOD5mdO3tHnaLeqQjCPNkw==", null, false, null, null, "967344bf-5f16-472d-a5bd-cba8cc6d9317", null, null, false, "tim.cook@example.com" },
                    { "106", 0, null, null, null, null, "c72e172d-f9af-45d1-9375-74803ed6ff34", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "satya.nadella@example.com", true, null, "Satya", null, null, true, false, false, false, "Nadella", null, false, null, false, "SATYA.NADELLA@EXAMPLE.COM", "SATYA.NADELLA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDq9SH6Gj3/crd0hCuPVifWWc0uWa9tmYvPMfst29e5PicrsHq4K4MFrrfuakReg3A==", null, false, null, null, "7a565f88-8990-41a8-abf8-d7d2395e91dd", null, null, false, "satya.nadella@example.com" },
                    { "107", 0, null, null, null, null, "5e6dba81-7fc5-4128-8273-cb68e0ae0506", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jack.dorsey@example.com", true, null, "Jack", null, null, true, false, false, false, "Dorsey", null, false, null, false, "JACK.DORSEY@EXAMPLE.COM", "JACK.DORSEY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPdPIfcwnXFAGiKA+UF8lkObHbxbeboDFPgITIY/eIwnHJlz45RBSZLF/9PnUvm5ig==", null, false, null, null, "80802708-5429-4561-ac5a-c6fd27bb4866", null, null, false, "jack.dorsey@example.com" },
                    { "108", 0, null, null, null, null, "2900b5d0-a79a-4d00-a333-03d403961b4f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "larry.page@example.com", true, null, "Larry", null, null, true, false, false, false, "Page", null, false, null, false, "LARRY.PAGE@EXAMPLE.COM", "LARRY.PAGE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBO9IJ2n1COtZ1JZ0cysbm1oM8hPD+byxm/NdCi2PGB0ujnZxuWvwcleUlTCOu0TPw==", null, false, null, null, "716e643a-47b8-4d99-9700-08b50a44bc7d", null, null, false, "larry.page@example.com" },
                    { "109", 0, null, null, null, null, "8c285212-a462-4f9d-b83d-fd8b8e0bacc6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sergey.brin@example.com", true, null, "Sergey", null, null, true, false, false, false, "Brin", null, false, null, false, "SERGEY.BRIN@EXAMPLE.COM", "SERGEY.BRIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFOnsMJ2P1DUNbhwUMp32RCNaymHyVR4IK+gGC/SejpLIOPJ+KkeFx7y5JtxnoOQuw==", null, false, null, null, "87d75c41-e7d5-4be2-af2a-b0708a1e9a87", null, null, false, "sergey.brin@example.com" },
                    { "110", 0, null, null, null, null, "3322fe4d-6245-46ae-8012-a5e61544330a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "steve.jobs@example.com", true, null, "Steve", null, null, true, false, false, false, "Jobs", null, false, null, false, "STEVE.JOBS@EXAMPLE.COM", "STEVE.JOBS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBYhV1DtrYbx0Z5K82OJFY3LHNsuIsiqzE3NeUeIidZ3srcTdVB1pGFgd/JQjK9ioA==", null, false, null, null, "6d405964-8d0d-4166-9c1c-267ef9837777", null, null, false, "steve.jobs@example.com" },
                    { "111", 0, null, null, null, null, "4e328443-1d22-4fbe-b59f-f718d9b9eac9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sheryl.sandberg@example.com", true, null, "Sheryl", null, null, true, false, false, false, "Sandberg", null, false, null, false, "SHERYL.SANDBERG@EXAMPLE.COM", "SHERYL.SANDBERG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMU5Lq++tYzgYtEVZKQ5rgLaZPrAYoL9y8bwdrEjqufIg/yrVRaD5eSnntZlaRcI4w==", null, false, null, null, "171dfbca-a291-4767-a176-9505e0f51e76", null, null, false, "sheryl.sandberg@example.com" },
                    { "112", 0, null, null, null, null, "bcb47824-0961-4b85-8d1b-e666eee277b8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "reed.hastings@example.com", true, null, "Reed", null, null, true, false, false, false, "Hastings", null, false, null, false, "REED.HASTINGS@EXAMPLE.COM", "REED.HASTINGS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEA17D7LM84wiUCCIeNYVwapRZGW9/Djuptb7y1DJMvsplH5CK9OTkWabvECl0PmaBw==", null, false, null, null, "513ac0b1-1c6f-4495-88b2-3b9fa764a1fa", null, null, false, "reed.hastings@example.com" },
                    { "113", 0, null, null, null, null, "d86ed202-0c0a-4c30-a10c-b2f46eec58b6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "marissa.mayer@example.com", true, null, "Marissa", null, null, true, false, false, false, "Mayer", null, false, null, false, "MARISSA.MAYER@EXAMPLE.COM", "MARISSA.MAYER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ6fXF7DQUukmdOSx0aPOHOXlGTzEm7O7B54De/gqs1ADKGIgZ3pqJLNp64EHDBp5Q==", null, false, null, null, "477eed5e-3ed6-4bb7-9f4d-e3e7080dba1a", null, null, false, "marissa.mayer@example.com" },
                    { "114", 0, null, null, null, null, "e5f1c9ce-9733-42c0-a9b0-5ee278cf44b9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "elizabeth.holmes@example.com", true, null, "Elizabeth", null, null, true, false, false, false, "Holmes", null, false, null, false, "ELIZABETH.HOLMES@EXAMPLE.COM", "ELIZABETH.HOLMES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE13oegCMyES5cudt99ndC8ycFwDlfhkPABnl1qRhFqwrJh/+mfiLxudQTs+Bpq08A==", null, false, null, null, "69d38184-5c19-4210-86f7-dae34e6519b6", null, null, false, "elizabeth.holmes@example.com" },
                    { "115", 0, null, null, null, null, "8a2cb779-6d57-48cf-b696-d32600a075fc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "susan.wojcicki@example.com", true, null, "Susan", null, null, true, false, false, false, "Wojcicki", null, false, null, false, "SUSAN.WOJCICKI@EXAMPLE.COM", "SUSAN.WOJCICKI@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOeT5UPc0vILOiUVWyX20VPL7ED98UMml+7Rv0ylXiaXGIl6v7p+NgJgDxutI7wSfw==", null, false, null, null, "51c2bc54-bc7d-4cd1-ae0f-8429db7a68ce", null, null, false, "susan.wojcicki@example.com" },
                    { "116", 0, null, null, null, null, "7fecb311-21ed-4954-b93d-9a23fe6455cf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tim.arnold@example.com", true, null, "Tim", null, null, true, false, false, false, "Arnold", null, false, null, false, "TIM.ARNOLD@EXAMPLE.COM", "TIM.ARNOLD@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJFCXf6qLP1NTwq1pSmMwTcqY7JiM5Jy+oYNYBNt4AHhwEWdxxAC7JuPOHaW93WkGg==", null, false, null, null, "de4e2d44-95d4-4f23-b999-9ac9f7c5b9fc", null, null, false, "tim.arnold@example.com" },
                    { "117", 0, null, null, null, null, "fc3555f8-1a11-408e-bcec-252f7418898b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob.iger@example.com", true, null, "Bob", null, null, true, false, false, false, "Iger", null, false, null, false, "BOB.IGER@EXAMPLE.COM", "BOB.IGER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEK3DBG5PIHJPe/ioHfZrrw2AKIcfmQHMzNJqZQFt2mi97ayFyrY86cqTVYogEbRcdQ==", null, false, null, null, "c6c11932-7bbc-485e-a038-173f7e58ab4f", null, null, false, "bob.iger@example.com" },
                    { "118", 0, null, null, null, null, "7d6af487-432d-4cac-84b8-4fa0367f7748", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "larry.ellison@example.com", true, null, "Larry", null, null, true, false, false, false, "Ellison", null, false, null, false, "LARRY.ELLISON@EXAMPLE.COM", "LARRY.ELLISON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPbGyHhdmBHKnANjldViMan3aJOQO3VVtk7tDm7j7VLzuxBfnJOwJQjrdi/NdMtgrA==", null, false, null, null, "c1138d35-a0d4-4e5e-a5f6-6acb2797f1c3", null, null, false, "larry.ellison@example.com" },
                    { "119", 0, null, null, null, null, "e4ff4581-1cb7-4b3a-9e27-10fe72e2863b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "richard.branson@example.com", true, null, "Richard", null, null, true, false, false, false, "Branson", null, false, null, false, "RICHARD.BRANSON@EXAMPLE.COM", "RICHARD.BRANSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEA/0qbAs8uMOmN6NhUH8XELaMegO9piuh+9sgBcmNf+n1JWxXoENT94a2avbrROfBA==", null, false, null, null, "7626d2b2-3e68-4ebe-8009-5e0926cc9277", null, null, false, "richard.branson@example.com" },
                    { "120", 0, null, null, null, null, "9dfbfe51-add9-4381-9180-b4dcdbcb20ea", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jack.ma@example.com", true, null, "Jack", null, null, true, false, false, false, "Ma", null, false, null, false, "JACK.MA@EXAMPLE.COM", "JACK.MA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAK+IJgj1p/OTLFXy2Ums3zrvEX2WdQozbpIo478imPcNGiRLYYmDSSmSTWsQytqew==", null, false, null, null, "d448f68f-b7e8-4910-8a81-0919da86478d", null, null, false, "jack.ma@example.com" },
                    { "121", 0, null, null, null, null, "d2ed6c5b-1b51-4002-b821-ec6f2c32b9f3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "warren.buffett@example.com", true, null, "Warren", null, null, true, false, false, false, "Buffett", null, false, null, false, "WARREN.BUFFETT@EXAMPLE.COM", "WARREN.BUFFETT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPjlZ+ZiSeF1JCaJcW7p4AE+AmdDuYM+mzBXqt3QQKKCHd+CvVmwxMjrB1d2gsYTVA==", null, false, null, null, "5e04d087-d302-4e75-bfa1-1163b3fb5989", null, null, false, "warren.buffett@example.com" },
                    { "122", 0, null, null, null, null, "7a260dba-e2a9-445b-8952-878a7462bd8a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mary.barrett@example.com", true, null, "Mary", null, null, true, false, false, false, "Barrett", null, false, null, false, "MARY.BARRETT@EXAMPLE.COM", "MARY.BARRETT@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJadAtxIDKanaP+BEAfgvnZWWlbjuptJiHl6/8dyujg+Hnf1FpL0rLRj6bGXBSzCWQ==", null, false, null, null, "a73e4af0-c7c9-432a-9c7c-ea34972902af", null, null, false, "mary.barrett@example.com" },
                    { "123", 0, null, null, null, null, "4a583b5f-e28d-45ae-840c-f8c1e0b2101f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ginni.rometty@example.com", true, null, "Ginni", null, null, true, false, false, false, "Rometty", null, false, null, false, "GINNI.ROMETTY@EXAMPLE.COM", "GINNI.ROMETTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAw5T9SQsXKx0bTERdCypZ9gSBOjSXYSU947zgoZeQkvw+RlpYP03if86u1SWMQvsg==", null, false, null, null, "bdf11b33-b1f3-41ed-86e7-5ebdb15a8357", null, null, false, "ginni.rometty@example.com" },
                    { "124", 0, null, null, null, null, "d6f210bf-56f9-4d56-ab31-40f183e6f2d1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mark.benioff@example.com", true, null, "Mark", null, null, true, false, false, false, "Benioff", null, false, null, false, "MARK.BENIOFF@EXAMPLE.COM", "MARK.BENIOFF@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE8ZpQvq/mAutzB6s9O0HJs6RDn8RHxZPo5pj5qSL5XHqB5dbYmIWzy3V4O45G7Oyg==", null, false, null, null, "f2be8204-471f-43da-9e6f-9bbab1a8ed9b", null, null, false, "mark.benioff@example.com" },
                    { "125", 0, null, null, null, null, "745c87ef-137b-4e9f-b61e-dbf1faca68a7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kevin.systrom@example.com", true, null, "Kevin", null, null, true, false, false, false, "Systrom", null, false, null, false, "KEVIN.SYSTROM@EXAMPLE.COM", "KEVIN.SYSTROM@EXAMPLE.COM", "AQAAAAIAAYagAAAAELogxPaOo2oauNPUcpDgn0X3hMJSlEb/I9LTGfjald3NsN+ddmCFfkD3BV2YKgXWug==", null, false, null, null, "7b319357-16af-446a-bdbe-a4a46c22d15c", null, null, false, "kevin.systrom@example.com" },
                    { "126", 0, null, null, null, null, "29e21a65-be16-4b20-85fb-8ce669e64b67", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "evan.spiegel@example.com", true, null, "Evan", null, null, true, false, false, false, "Spiegel", null, false, null, false, "EVAN.SPIEGEL@EXAMPLE.COM", "EVAN.SPIEGEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEiR/t9DD5Io3+i6BZ3XgFDjuAnrAh3HSodJyRiT6xlNQ4rk884GdSleoX7mL6w8KA==", null, false, null, null, "7b9ae7cb-78bd-4467-b0d2-61a3c5686a25", null, null, false, "evan.spiegel@example.com" },
                    { "127", 0, null, null, null, null, "c89971f7-5890-4503-ae81-f54d674b0877", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jan.koum@example.com", true, null, "Jan", null, null, true, false, false, false, "Koum", null, false, null, false, "JAN.KOUM@EXAMPLE.COM", "JAN.KOUM@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMNYAaQd3JEvPc7vX/PudoW9O+jBgt2ww7/8ZFQ6Q6RTVnkVepb7FfoeDXdpXMCxxA==", null, false, null, null, "7977517d-5437-47db-a48b-c4b175202b60", null, null, false, "jan.koum@example.com" },
                    { "128", 0, null, null, null, null, "41308137-d23a-42f1-9334-6cfc6304c8b1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "janice.fang@example.com", true, null, "Janice", null, null, true, false, false, false, "Fang", null, false, null, false, "JANICE.FANG@EXAMPLE.COM", "JANICE.FANG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEZaPS8nu5Ws5QVrDdH0Wli6BhBWNuQbSQ9h5uO1KzlXHgi715G93dB5i3iwMgIHNQ==", null, false, null, null, "ded6bbc0-27f1-4731-babe-dca0495c9b38", null, null, false, "janice.fang@example.com" },
                    { "129", 0, null, null, null, null, "33258229-7fc7-4143-924e-79350a83659d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sergey.gladkikh@example.com", true, null, "Sergey", null, null, true, false, false, false, "Gladkikh", null, false, null, false, "SERGEY.GLADKIKH@EXAMPLE.COM", "SERGEY.GLADKIKH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKKurhUjommeEJBoEkoXparzYYn2pUJjTdrkYgYrkmSdutdt1vORnFJ21X0MeCHxXw==", null, false, null, null, "8a8812a8-ed5e-4f87-a881-168e823df40f", null, null, false, "sergey.gladkikh@example.com" },
                    { "130", 0, null, null, null, null, "568b1972-9323-41cd-a594-bb94aaf22471", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tony.hsieh@example.com", true, null, "Tony", null, null, true, false, false, false, "Hsieh", null, false, null, false, "TONY.HSIEH@EXAMPLE.COM", "TONY.HSIEH@EXAMPLE.COM", "AQAAAAIAAYagAAAAECIQqTskbi9Q71a5RqEmnaA+AgZJ3kGwNssDnsw34wPdIfasSbMuHHjhKGuq0pWw0w==", null, false, null, null, "fa47764a-4e49-4a12-983f-72b8e8146766", null, null, false, "tony.hsieh@example.com" },
                    { "131", 0, null, null, null, null, "81aa2f02-a79f-4e9c-947d-5e2eb137e7ff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "richard.hyne@example.com", true, null, "Richard", null, null, true, false, false, false, "Hyne", null, false, null, false, "RICHARD.HYNE@EXAMPLE.COM", "RICHARD.HYNE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHpphigrI/h+67J5uDBv4Ui+YK8pBn09lcfnlp8Xr+SkISCJC2wM+NA5x8wuhDaW7w==", null, false, null, null, "fa3eefb4-406d-4db1-a539-042b6147d8ad", null, null, false, "richard.hyne@example.com" },
                    { "132", 0, null, null, null, null, "2076afcc-3522-42d9-bdb9-2de843e2b0f9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "peter.thiel@example.com", true, null, "Peter", null, null, true, false, false, false, "Thiel", null, false, null, false, "PETER.THIEL@EXAMPLE.COM", "PETER.THIEL@EXAMPLE.COM", "AQAAAAIAAYagAAAAEABB32pFf99uQtyEO23fuPfYsDXzAElRWNcg8mwThk2vLWIzWypfV8i6/V7v+Ftehg==", null, false, null, null, "ec041e8b-62ec-45a7-87c9-2a302a4d80e3", null, null, false, "peter.thiel@example.com" },
                    { "133", 0, null, null, null, null, "5bae11e4-2360-4d47-9489-e86e2f4fc970", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "steve.wozniak@example.com", true, null, "Steve", null, null, true, false, false, false, "Wozniak", null, false, null, false, "STEVE.WOZNIAK@EXAMPLE.COM", "STEVE.WOZNIAK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ4GnDso16eIs7NA+FxqQ1DsL7ycP8tPk+3t2BSCoWxvDEXlJAWyQLcKhQgjuY84qw==", null, false, null, null, "29dc7683-4296-48af-a70e-c1ce103badec", null, null, false, "steve.wozniak@example.com" },
                    { "134", 0, null, null, null, null, "dcea1b7d-9ff5-4099-98c1-a16d1ac8e92b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.carmack@example.com", true, null, "John", null, null, true, false, false, false, "Carmack", null, false, null, false, "JOHN.CARMACK@EXAMPLE.COM", "JOHN.CARMACK@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKKoIcWxlkfd7XcAzrd2TbjFTYtzM0CENd6Xw/+MJcehlWEOQmUF5fmcEioOO0YSFg==", null, false, null, null, "98111f17-ad0a-44ca-a811-9a249a444fe5", null, null, false, "john.carmack@example.com" },
                    { "135", 0, null, null, null, null, "93dc7379-56d8-49a6-8c8a-6898dce427d0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mike.zyda@example.com", true, null, "Mike", null, null, true, false, false, false, "Zyda", null, false, null, false, "MIKE.ZYDA@EXAMPLE.COM", "MIKE.ZYDA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHvfZArFLcuHgbBdc4NBv2z1fEaqRooowlwM9bmOaIvUUZhE+i2pcboiFqCVKkZBJA==", null, false, null, null, "bad0b129-7f98-4ca1-9075-64b452f87425", null, null, false, "mike.zyda@example.com" },
                    { "136", 0, null, null, null, null, "fac03560-9b16-45d7-a6cd-3f7ff8fea31b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cheryl.sandberg@example.com", true, null, "Cheryl", null, null, true, false, false, false, "Sandberg", null, false, null, false, "CHERYL.SANDBERG@EXAMPLE.COM", "CHERYL.SANDBERG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAbDZSbXISERWIRR4T3+WyNGTYcM37CEa3sz6B2kZlnlW0EhQ8FQ+Vh/X4nfxV0cAQ==", null, false, null, null, "d2305a84-e40b-4e4f-bde7-f19e8c455502", null, null, false, "cheryl.sandberg@example.com" },
                    { "137", 0, null, null, null, null, "137940f1-4234-4e4f-b2cd-3c1b05fcf52a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "karen.smith@example.com", true, null, "Karen", null, null, true, false, false, false, "Smith", null, false, null, false, "KAREN.SMITH@EXAMPLE.COM", "KAREN.SMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJixhJ0Pd/hTJiVGodLHNB7VJyQrDW+tmwFIG6sZf4kyV+JyNYL9VbRWnaITxxqluA==", null, false, null, null, "7c387265-a69d-46a5-af38-f942c1743d64", null, null, false, "karen.smith@example.com" },
                    { "138", 0, null, null, null, null, "a90cec74-7067-4ca2-9315-beda04862ffe", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "david.lee@example.com", true, null, "David", null, null, true, false, false, false, "Lee", null, false, null, false, "DAVID.LEE@EXAMPLE.COM", "DAVID.LEE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJ7GXiN54uxr1EGCvVSv2eGRBTK/kiIDkV3Wq9QhuMNP91UceyVtD9JN8a3VlMnY6A==", null, false, null, null, "7ba569fa-1cdd-4738-be9c-2e5f331fdfb9", null, null, false, "david.lee@example.com" },
                    { "139", 0, null, null, null, null, "050e34c9-4021-481f-a5bb-8a3d968b3300", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "james.taylor@example.com", true, null, "James", null, null, true, false, false, false, "Taylor", null, false, null, false, "JAMES.TAYLOR@EXAMPLE.COM", "JAMES.TAYLOR@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEMfVA0HPAi1/YA8IpCaVvtSP0RPpCEc3zialnCK8wvQtYJ3YzN0HboeDGehuauBJg==", null, false, null, null, "a628e8d8-3a70-4e60-9f34-b588d511ac78", null, null, false, "james.taylor@example.com" }
                });

            migrationBuilder.InsertData(
                table: "BillItems",
                columns: new[] { "BillItemsID", "AddedBy", "AddedOn", "Amount", "BillItemsModelBillItemsID", "Description", "IsDeleted", "PaymentDuration", "PaymentName", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 5, 1, 17, 0, 10, 864, DateTimeKind.Utc).AddTicks(866), 2000.00m, null, "Monthly HOA dues for maintenance, security, and amenities.", false, "Monthly", "Homeowners Association (HOA) Fees", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(2025, 5, 1, 17, 0, 10, 864, DateTimeKind.Utc).AddTicks(877), 350.00m, null, "Monthly water consumption charges.", false, "Monthly", "Water Bill", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, new DateTime(2025, 5, 1, 17, 0, 10, 864, DateTimeKind.Utc).AddTicks(879), 200.00m, null, "Monthly fee for waste disposal services.", false, "Monthly", "Garbage Collection Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, new DateTime(2025, 5, 1, 17, 0, 10, 864, DateTimeKind.Utc).AddTicks(882), 1000.00m, null, "Monthly fee for 24/7 subdivision security services.", false, "Monthly", "Security Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, new DateTime(2025, 5, 1, 17, 0, 10, 864, DateTimeKind.Utc).AddTicks(884), 300.00m, null, "Monthly fee for streetlight maintenance and electricity.", false, "Monthly", "Street Lighting Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, new DateTime(2025, 5, 1, 17, 0, 10, 864, DateTimeKind.Utc).AddTicks(886), 500.00m, null, "Monthly fee for clubhouse upkeep and utilities.", false, "Monthly", "Clubhouse Maintenance Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, new DateTime(2025, 5, 1, 17, 0, 10, 864, DateTimeKind.Utc).AddTicks(888), 1000.00m, null, "Monthly contribution toward shared property tax obligations.", false, "Monthly", "Property Tax Contribution", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, new DateTime(2025, 5, 1, 17, 0, 10, 864, DateTimeKind.Utc).AddTicks(890), 800.00m, null, "Monthly contribution to the long-term repair and reserve fund.", false, "Monthly", "Sinking Fund Contribution", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, new DateTime(2025, 5, 1, 17, 0, 10, 864, DateTimeKind.Utc).AddTicks(891), 250.00m, null, "Monthly fee for regular pest control services.", false, "Monthly", "Pest Control Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, new DateTime(2025, 5, 1, 17, 0, 10, 864, DateTimeKind.Utc).AddTicks(892), 700.00m, null, "Monthly fee for road repair and upkeep.", false, "Monthly", "Road Maintenance Fee", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                    { 1, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4843), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4841), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4842), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4843), "111" },
                    { 2, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4849), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4848), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4848), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4849), "112" },
                    { 3, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4853), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4852), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4852), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4854), "113" },
                    { 4, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4856), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4855), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4855), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4856), "114" },
                    { 5, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4858), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4857), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4858), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4859), "115" },
                    { 6, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4861), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4860), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4860), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4861), "116" },
                    { 7, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4864), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4863), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4863), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4865), "117" },
                    { 8, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4867), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4866), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4866), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4867), "118" },
                    { 9, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4869), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4868), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4868), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4870), "119" },
                    { 10, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4872), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4871), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4871), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4872), "120" },
                    { 11, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4875), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4874), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4874), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4876), "121" },
                    { 12, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4878), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4877), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4877), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4878), "122" },
                    { 13, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4880), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4879), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4879), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4881), "123" },
                    { 14, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4883), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4881), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4882), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4883), "124" },
                    { 15, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4887), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4886), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4886), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4887), "125" },
                    { 16, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4889), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4888), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4889), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4890), "126" },
                    { 17, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4892), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4891), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4891), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4892), "127" },
                    { 18, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4894), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4893), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4893), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4895), "128" },
                    { 19, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4898), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4897), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4897), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4898), "129" },
                    { 20, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4900), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4899), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4899), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4901), "130" },
                    { 21, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4903), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4901), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4902), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4903), "131" },
                    { 22, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4905), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4904), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4904), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4905), "132" },
                    { 23, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4908), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4907), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4908), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4909), "133" },
                    { 24, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4911), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4910), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4910), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4911), "134" },
                    { 25, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4913), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4912), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4912), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4914), "135" },
                    { 26, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4918), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4917), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4918), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4919), "136" },
                    { 27, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4922), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4921), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4921), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4922), "137" },
                    { 28, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4924), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4923), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4924), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4925), "138" },
                    { 29, null, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4927), null, true, false, false, false, new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4926), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4926), new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4927), "139" }
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
                    { 1, "admin", new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4038), "123 Main St", 6, "Jane Doe", "1234567890", "Spouse", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Security Officer", 25000.00m, null, null, "100" },
                    { 2, "admin", new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4068), "456 Oak St", 5, "John Smith", "0987654321", "Brother", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Maintenance Supervisor", 30000.00m, null, null, "102" },
                    { 3, "admin", new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4086), "789 Pine St", 3, "Alice Brown", "5678901234", "Sister", new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "System Administrator", 35000.00m, null, null, "103" },
                    { 4, "admin", new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4101), "987 Cedar St", 2, "Bob White", "2345678901", "Father", new DateTime(2019, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Finance Manager", 40000.00m, null, null, "104" },
                    { 5, "admin", new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4117), "654 Birch St", 0, "Chris Green", "3456789012", "Friend", new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Amenities Coordinator", 28000.00m, null, null, "105" },
                    { 6, "admin", new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4136), "321 Maple St", 1, "Diana Blue", "4567890123", "Cousin", new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Customer Service Representative", 26000.00m, null, null, "106" },
                    { 7, "admin", new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4150), "159 Elm St", 4, "Evan Red", "5678901234", "Uncle", new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Head Gardener", 27000.00m, null, null, "107" },
                    { 8, "admin", new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4162), "123 Main St", 6, "Jane Doe", "1234567890", "Spouse", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Security Officer", 25000.00m, null, null, "108" },
                    { 9, "admin", new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4176), "456 Oak St", 5, "John Smith", "0987654321", "Brother", new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "Maintenance Supervisor", 30000.00m, null, null, "109" },
                    { 10, "admin", new DateTime(2025, 5, 1, 17, 0, 13, 77, DateTimeKind.Utc).AddTicks(4420), "789 Pine St", 3, "Alice Brown", "5678901234", "Sister", new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, false, false, "System Administrator", 35000.00m, null, null, "110" }
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
