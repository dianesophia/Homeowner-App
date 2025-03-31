using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Hometown_Application.Data;

public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
    }
    public DbSet<HouseModel> Houses { get; set; }
    public DbSet<HomeownerProfileModel> HomeownerProfiles { get; set; }
    public DbSet<StaffProfileModel> StaffProfiles { get; set; }
    public DbSet<AdminProfileModel> AdminProfiles { get; set; }

    public DbSet<FeedbackComplaintModel> FeedbackComplaints { get; set; }
    public DbSet<EventModel> Events { get; set; }
    public DbSet<DocumentModel> Documents { get; set; }
    public DbSet<ContactModel> Contacts { get; set; }
    public DbSet<StatusModel> Status { get; set; }
    public DbSet<ReservationModel> Reservation { get; set; }
    public DbSet<FacilityModel> Facility { get; set; }
    public DbSet<VisitorGatepassModel> VisitorGatepasses { get; set; }
    public DbSet<VehicleGatepassModel> VehicleGatepasses { get; set; }

    //Community Forum
    public DbSet<PostModel> Posts { get; set; }
    public DbSet<CommentModel> Comments { get; set; }
    public DbSet<ReactionModel> Reactions { get; set; }

    //Chat
    public DbSet<ChatMessageModel> Chats { get; set; }


    //Billing
    public DbSet<BillModel> Bills { get; set; }
    public DbSet<BillItemsModel> BillItems { get; set; }
    public DbSet<BillAccountModel> BillAccounts { get; set; }
    public DbSet<BillTransactionModel> BillTransactions { get; set; }

    // Add Poll and Survey related DbSets
    public DbSet<PollModel> Polls { get; set; }
    public DbSet<PollQuestionModel> PollQuestions { get; set; }
    public DbSet<QuestionOptionModel> QuestionOptions { get; set; }
    public DbSet<PollResponseModel> PollResponses { get; set; }
    
    public DbSet<ServiceRequestModel> ServiceRequests { get; set; }

    public DbSet<RequestTypeModel> RequestTypes { get; set; }
    public DbSet<ServiceStaffAssignmentModel> ServiceStaffAssignments { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
            base.OnModelCreating(builder);

        builder.Entity<HouseModel>()
            .HasIndex(h => new { h.BlockNumber, h.LotNumber, h.StreetName })
            .IsUnique();

       

        builder.Entity<FacilityModel>()
                .HasMany(f => f.Reservations)
                .WithOne(r => r.Facility)
                .HasForeignKey(r => r.FacilityId)
                .OnDelete(DeleteBehavior.Cascade);

        
        builder.Entity<ReservationModel>()
           .HasOne(fc => fc.ApplicationUser)
           .WithMany()
           .HasForeignKey(fc => fc.UserId)
           .OnDelete(DeleteBehavior.Cascade);

        
        builder.Entity<FeedbackComplaintModel>()
           .HasOne(fc => fc.ApplicationUser)
           .WithMany()
           .HasForeignKey(fc => fc.UserId)
           .OnDelete(DeleteBehavior.Cascade);


        builder.Entity<VehicleGatepassModel>()
           .HasOne(fc => fc.ApplicationUser)
           .WithMany()
           .HasForeignKey(fc => fc.UserId)
           .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<VisitorGatepassModel>()
           .HasOne(fc => fc.ApplicationUser)
           .WithMany()
           .HasForeignKey(fc => fc.UserId)
           .OnDelete(DeleteBehavior.Cascade);


        // Community Forum
        builder.Entity<PostModel>()
            .HasOne(p => p.ApplicationUser)
            .WithMany()
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<ReactionModel>()
            .HasOne(r => r.ApplicationUser)
            .WithMany()
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<ReactionModel>()
            .HasOne(r => r.Post)
            .WithMany(p => p.Reactions)  // Allow multiple reactions per post
            .HasForeignKey(r => r.PostId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<CommentModel>()
            .HasOne(c => c.ApplicationUser)
            .WithMany()
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<CommentModel>()
            .HasOne(c => c.Post)
            .WithMany(p => p.Comments)  // Allow multiple comments per post
            .HasForeignKey(c => c.PostId)
            .OnDelete(DeleteBehavior.NoAction);

        //Chat

        builder.Entity<ChatMessageModel>()
       .HasOne(c => c.Sender)
       .WithMany()  // No navigation property in ApplicationUser
       .HasForeignKey(c => c.SenderId)
       .OnDelete(DeleteBehavior.NoAction); // Prevent cascading delete


        //Billing
        builder.Entity<BillModel>()
           .HasOne(p => p.ApplicationUser)
           .WithMany()
           .HasForeignKey(p => p.UserId)
           .OnDelete(DeleteBehavior.NoAction);

       

        builder.Entity<BillAccountModel>()
           .HasOne(c => c.ApplicationUser)
           .WithMany()
           .HasForeignKey(c => c.UserId)
           .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<BillTransactionModel>()
         .HasOne(c => c.ApplicationUser)
         .WithMany()
         .HasForeignKey(c => c.UserId)
         .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<BillTransactionModel>()
        .HasOne(c => c.BillItemsModel)
        .WithMany()
        .HasForeignKey(c => c.BillItemsId)
        .OnDelete(DeleteBehavior.NoAction);

        // Relationship for Recipient
        builder.Entity<ChatMessageModel>()
            .HasOne(c => c.Recipient)
            .WithMany()  // No navigation property in ApplicationUser
            .HasForeignKey(c => c.RecipientId)
            .OnDelete(DeleteBehavior.NoAction); // Prevent cascading delete


        builder.Entity<StatusModel>().HasData(
            new StatusModel { StatusId = 1, StatusName = "Available" },
            new StatusModel { StatusId = 2, StatusName = "Unavailable" },
            new StatusModel { StatusId = 3, StatusName = "Pending" },
            new StatusModel { StatusId = 4, StatusName = "In Progress" },
            new StatusModel { StatusId = 5, StatusName = "Resolved" },
            new StatusModel { StatusId = 6, StatusName = "Closed" }
        );

        builder.Entity<RequestTypeModel>().HasData(
                new RequestTypeModel { RequestTypeId = 1, Name = "Pool Cleaning", AssignedDepartment = StaffDepartment.Amenities, Description = "Request for pool maintenance." },
                new RequestTypeModel { RequestTypeId = 2, Name = "Lost and Found Inquiry", AssignedDepartment = StaffDepartment.CustomerSupport, Description = "Report or ask about lost items." },
                new RequestTypeModel { RequestTypeId = 3, Name = "Billing Issue", AssignedDepartment = StaffDepartment.Finance, Description = "Concerns about billing and payments." },
                new RequestTypeModel { RequestTypeId = 4, Name = "Internet Issue", AssignedDepartment = StaffDepartment.IT, Description = "Report issues with internet connectivity." },
                new RequestTypeModel { RequestTypeId = 5, Name = "Lawn Mowing", AssignedDepartment = StaffDepartment.Landscaping, Description = "Request lawn maintenance services." },
                new RequestTypeModel { RequestTypeId = 6, Name = "Plumbing Repair", AssignedDepartment = StaffDepartment.Maintenance, Description = "Report plumbing issues like leaks." },
                new RequestTypeModel { RequestTypeId = 7, Name = "Suspicious Activity", AssignedDepartment = StaffDepartment.Security, Description = "Report security concerns or suspicious activity." }
            );

        builder.Entity<BillItemsModel>().HasData(
       new BillItemsModel { BillItemsID = 1, PaymentName = "Homeowners Association (HOA) Fees", Amount = 3500.00m, Description = "Monthly HOA dues covering maintenance, security, and amenities.", PaymentDuration = "Monthly" },
       new BillItemsModel { BillItemsID = 2, PaymentName = "Water Bill", Amount = 100.00m, Description = "Monthly water consumption charges.", PaymentDuration = "Monthly" },
       new BillItemsModel { BillItemsID = 3, PaymentName = "Electricity Bill", Amount = 2500.00m, Description = "Monthly payment for electricity consumption.", PaymentDuration = "Monthly" },
       new BillItemsModel { BillItemsID = 4, PaymentName = "Garbage Collection Fee", Amount = 300.00m, Description = "Monthly fee for waste disposal services.", PaymentDuration = "Monthly" },
       new BillItemsModel { BillItemsID = 5, PaymentName = "Security Fee", Amount = 1500.00m, Description = "Monthly fee for subdivision security services.", PaymentDuration = "Monthly" },
       new BillItemsModel { BillItemsID = 6, PaymentName = "Street Lighting Fee", Amount = 500.00m, Description = "Monthly fee for streetlight maintenance.", PaymentDuration = "Monthly" },
       new BillItemsModel { BillItemsID = 7, PaymentName = "Clubhouse Maintenance Fee", Amount = 800.00m, Description = "Annual fee for maintaining the clubhouse and shared spaces.", PaymentDuration = "Yearly" },
       new BillItemsModel { BillItemsID = 8, PaymentName = "Property Tax Contribution", Amount = 5000.00m, Description = "Annual contribution for property tax remittance.", PaymentDuration = "Yearly" },
       new BillItemsModel { BillItemsID = 9, PaymentName = "Sinking Fund Contribution", Amount = 1200.00m, Description = "Quarterly contribution for major subdivision repairs.", PaymentDuration = "Quarterly" },
       new BillItemsModel { BillItemsID = 10, PaymentName = "Pest Control Fee", Amount = 600.00m, Description = "Quarterly fee for pest control services in the subdivision.", PaymentDuration = "Quarterly" },
       new BillItemsModel { BillItemsID = 11, PaymentName = "Road Maintenance Fee", Amount = 1000.00m, Description = "Annual fee for road maintenance and repairs.", PaymentDuration = "Yearly" }
   );


        // ✅ Seeding Roles
         var roles = new List<IdentityRole>
         {
             new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
             new IdentityRole { Id = "2", Name = "HomeOwner", NormalizedName = "HOMEOWNER" },
             new IdentityRole { Id = "3", Name = "Staff", NormalizedName = "STAFF" }
         };
         builder.Entity<IdentityRole>().HasData(roles);

        // ✅ Seeding Users

       /* var adminRole = new IdentityRole("Admin") { Id = "1", NormalizedName = "ADMIN" };
        var homeOwnerRole = new IdentityRole("HomeOwner") { Id = "2", NormalizedName = "HOMEOWNER" };
        var staffRole = new IdentityRole("Staff") { Id = "3", NormalizedName = "STAFF" };
       */
        var hasher = new PasswordHasher<ApplicationUser>();

      /*  var adminUser = new ApplicationUser
        {
            Id = "999", // Unique ID for Admin
            UserName = "admin@admin.com",
            NormalizedUserName = "ADMIN@ADMIN.COM",
            Email = "admin@admin.com",
            NormalizedEmail = "ADMIN@ADMIN.COM",
            EmailConfirmed = true,
            FirstName = "System",
            LastName = "Admin",
            PasswordHash = hasher.HashPassword(null, "Admin1234*") // Secure password
        };

        // ✅ Add Admin User
        builder.Entity<ApplicationUser>().HasData(adminUser);

        builder.Entity<IdentityUserRole<string>>().HasData(
   new IdentityUserRole<string> { UserId = "999", RoleId = "1" } // Assigning Admin Role
);*/

        builder.Entity<ApplicationUser>().HasData(
    new ApplicationUser { Id = "100", UserName = "elon.musk@example.com", NormalizedUserName = "ELON.MUSK@EXAMPLE.COM", Email = "elon.musk@example.com", NormalizedEmail = "ELON.MUSK@EXAMPLE.COM", EmailConfirmed = true, FirstName = "Elon", LastName = "Musk", PasswordHash = hasher.HashPassword(null, "ElonMusk123*") },
    new ApplicationUser { Id = "102", UserName = "bill.gates@example.com", NormalizedUserName = "BILL.GATES@EXAMPLE.COM", Email = "bill.gates@example.com", NormalizedEmail = "BILL.GATES@EXAMPLE.COM", EmailConfirmed = true, FirstName = "Bill", LastName = "Gates", PasswordHash = hasher.HashPassword(null, "BillGates123*") },
    new ApplicationUser { Id = "103", UserName = "mark.zuckerberg@example.com", NormalizedUserName = "MARK.ZUCKERBERG@EXAMPLE.COM", Email = "mark.zuckerberg@example.com", NormalizedEmail = "MARK.ZUCKERBERG@EXAMPLE.COM", EmailConfirmed = true, FirstName = "Mark", LastName = "Zuckerberg", PasswordHash = hasher.HashPassword(null, "MarkZuck123*") },
    new ApplicationUser { Id = "104", UserName = "sundar.pichai@example.com", NormalizedUserName = "SUNDAR.PICHAI@EXAMPLE.COM", Email = "sundar.pichai@example.com", NormalizedEmail = "SUNDAR.PICHAI@EXAMPLE.COM", EmailConfirmed = true, FirstName = "Sundar", LastName = "Pichai", PasswordHash = hasher.HashPassword(null, "SundarPichai123*") },
    new ApplicationUser { Id = "105", UserName = "tim.cook@example.com", NormalizedUserName = "TIM.COOK@EXAMPLE.COM", Email = "tim.cook@example.com", NormalizedEmail = "TIM.COOK@EXAMPLE.COM", EmailConfirmed = true, FirstName = "Tim", LastName = "Cook", PasswordHash = hasher.HashPassword(null, "TimCook123*") },
    new ApplicationUser { Id = "106", UserName = "satya.nadella@example.com", NormalizedUserName = "SATYA.NADELLA@EXAMPLE.COM", Email = "satya.nadella@example.com", NormalizedEmail = "SATYA.NADELLA@EXAMPLE.COM", EmailConfirmed = true, FirstName = "Satya", LastName = "Nadella", PasswordHash = hasher.HashPassword(null, "SatyaNadella123*") },
    new ApplicationUser { Id = "107", UserName = "jack.dorsey@example.com", NormalizedUserName = "JACK.DORSEY@EXAMPLE.COM", Email = "jack.dorsey@example.com", NormalizedEmail = "JACK.DORSEY@EXAMPLE.COM", EmailConfirmed = true, FirstName = "Jack", LastName = "Dorsey", PasswordHash = hasher.HashPassword(null, "JackDorsey123*") },
    new ApplicationUser { Id = "108", UserName = "larry.page@example.com", NormalizedUserName = "LARRY.PAGE@EXAMPLE.COM", Email = "larry.page@example.com", NormalizedEmail = "LARRY.PAGE@EXAMPLE.COM", EmailConfirmed = true, FirstName = "Larry", LastName = "Page", PasswordHash = hasher.HashPassword(null, "LarryPage123*") },
    new ApplicationUser { Id = "109", UserName = "sergey.brin@example.com", NormalizedUserName = "SERGEY.BRIN@EXAMPLE.COM", Email = "sergey.brin@example.com", NormalizedEmail = "SERGEY.BRIN@EXAMPLE.COM", EmailConfirmed = true, FirstName = "Sergey", LastName = "Brin", PasswordHash = hasher.HashPassword(null, "SergeyBrin123*") },
    new ApplicationUser { Id = "110", UserName = "steve.jobs@example.com", NormalizedUserName = "STEVE.JOBS@EXAMPLE.COM", Email = "steve.jobs@example.com", NormalizedEmail = "STEVE.JOBS@EXAMPLE.COM", EmailConfirmed = true, FirstName = "Steve", LastName = "Jobs", PasswordHash = hasher.HashPassword(null, "SteveJobs123*") });



        builder.Entity<HouseModel>().HasData(
        new HouseModel { HouseId = 1, UserId = "100", BlockNumber = "A1", LotNumber = 101, StreetName = "Main St", IsOccupied = true },
        new HouseModel { HouseId = 2, UserId = "102", BlockNumber = "B2", LotNumber = 202, StreetName = "Oak St", IsOccupied = true },
        new HouseModel { HouseId = 3, UserId = "103", BlockNumber = "C3", LotNumber = 303, StreetName = "Pine St", IsOccupied = true },
        new HouseModel { HouseId = 4, UserId = "104", BlockNumber = "D4", LotNumber = 404, StreetName = "Cedar St", IsOccupied = true },
        new HouseModel { HouseId = 5, UserId = "105", BlockNumber = "E5", LotNumber = 505, StreetName = "Birch St", IsOccupied = true },
        new HouseModel { HouseId = 6, UserId = "106", BlockNumber = "F6", LotNumber = 606, StreetName = "Maple St", IsOccupied = true },
        new HouseModel { HouseId = 7, UserId = "107", BlockNumber = "G7", LotNumber = 707, StreetName = "Elm St", IsOccupied = true }
    );
        
        builder.Entity<StaffProfileModel>().HasData(
    new StaffProfileModel { StaffId = 1, UserId = "100", Department = StaffDepartment.Security, Position = "Security Officer", HireDate = DateTime.Parse("2022-01-10"), Salary = 25000.00m, IsActiveEmployee = true, IsAlsoHomeOwner = true, Address = "123 Main St", EmergencyContactName = "Jane Doe", EmergencyContactNumber = "1234567890", EmergencyContactRelation = "Spouse", AccountCreatedBy = "admin", AccountCreatedOn = DateTime.UtcNow },
    new StaffProfileModel { StaffId = 2, UserId = "102", Department = StaffDepartment.Maintenance, Position = "Maintenance Supervisor", HireDate = DateTime.Parse("2021-06-15"), Salary = 30000.00m, IsActiveEmployee = true, IsAlsoHomeOwner = true,  Address = "456 Oak St", EmergencyContactName = "John Smith", EmergencyContactNumber = "0987654321", EmergencyContactRelation = "Brother", AccountCreatedBy = "admin", AccountCreatedOn = DateTime.UtcNow },
    new StaffProfileModel { StaffId = 3, UserId = "103", Department = StaffDepartment.IT, Position = "System Administrator", HireDate = DateTime.Parse("2020-09-20"), Salary = 35000.00m, IsActiveEmployee = true, IsAlsoHomeOwner = true, Address = "789 Pine St", EmergencyContactName = "Alice Brown", EmergencyContactNumber = "5678901234", EmergencyContactRelation = "Sister", AccountCreatedBy = "admin", AccountCreatedOn = DateTime.UtcNow },
    new StaffProfileModel { StaffId = 4, UserId = "104", Department = StaffDepartment.Finance, Position = "Finance Manager", HireDate = DateTime.Parse("2019-04-05"), Salary = 40000.00m, IsActiveEmployee = true, IsAlsoHomeOwner = true,  Address = "987 Cedar St", EmergencyContactName = "Bob White", EmergencyContactNumber = "2345678901", EmergencyContactRelation = "Father", AccountCreatedBy = "admin", AccountCreatedOn = DateTime.UtcNow },
    new StaffProfileModel { StaffId = 5, UserId = "105", Department = StaffDepartment.Amenities, Position = "Amenities Coordinator", HireDate = DateTime.Parse("2021-11-12"), Salary = 28000.00m, IsActiveEmployee = true, IsAlsoHomeOwner = true, Address = "654 Birch St", EmergencyContactName = "Chris Green", EmergencyContactNumber = "3456789012", EmergencyContactRelation = "Friend", AccountCreatedBy = "admin", AccountCreatedOn = DateTime.UtcNow },
    new StaffProfileModel { StaffId = 6, UserId = "106", Department = StaffDepartment.CustomerSupport, Position = "Customer Service Representative", HireDate = DateTime.Parse("2023-02-20"), Salary = 26000.00m, IsActiveEmployee = true, IsAlsoHomeOwner = true, Address = "321 Maple St", EmergencyContactName = "Diana Blue", EmergencyContactNumber = "4567890123", EmergencyContactRelation = "Cousin", AccountCreatedBy = "admin", AccountCreatedOn = DateTime.UtcNow },
    new StaffProfileModel { StaffId = 7, UserId = "107", Department = StaffDepartment.Landscaping, Position = "Head Gardener", HireDate = DateTime.Parse("2020-06-30"), Salary = 27000.00m, IsActiveEmployee = true, IsAlsoHomeOwner = true, Address = "159 Elm St", EmergencyContactName = "Evan Red", EmergencyContactNumber = "5678901234", EmergencyContactRelation = "Uncle", AccountCreatedBy = "admin", AccountCreatedOn = DateTime.UtcNow }
);


        builder.Entity<IdentityUserRole<string>>().HasData(
    new IdentityUserRole<string> { UserId = "100", RoleId = "3" }, // Elon Musk -> Staff
    new IdentityUserRole<string> { UserId = "102", RoleId = "3" }, // Bill Gates -> Staff
    new IdentityUserRole<string> { UserId = "103", RoleId = "3" }, // Mark Zuckerberg -> Staff
    new IdentityUserRole<string> { UserId = "104", RoleId = "3" }, // Sundar Pichai -> Staff
    new IdentityUserRole<string> { UserId = "105", RoleId = "3" }, // Tim Cook -> Staff
    new IdentityUserRole<string> { UserId = "106", RoleId = "3" }, // Satya Nadella -> Staff
    new IdentityUserRole<string> { UserId = "107", RoleId = "3" }  // Jack Dorsey -> Staff
);

        builder.Entity<HomeownerProfileModel>()
          .HasOne(fc => fc.ApplicationUser)
          .WithMany()
          .HasForeignKey(fc => fc.UserId)
          .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<HomeownerProfileModel>()
        .HasOne(h => h.House)
        .WithMany(h => h.Homeowners)
        .HasForeignKey(h => h.HouseId)
        .OnDelete(DeleteBehavior.Restrict);

        


        builder.Entity<StaffProfileModel>()
        .HasOne(fc => fc.ApplicationUser)
        .WithMany()
        .HasForeignKey(fc => fc.UserId)
        .OnDelete(DeleteBehavior.Cascade);

       /* builder.Entity<StaffProfileModel>()
     .HasOne(s => s.House)
     .WithMany()
     .HasForeignKey(s => s.HouseId)
     .OnDelete(DeleteBehavior.Restrict);
*/
        builder.Entity<AdminProfileModel>()
        .HasOne(fc => fc.ApplicationUser)
        .WithMany()
        .HasForeignKey(fc => fc.UserId)
        .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<FeedbackComplaintModel>()
           .HasOne(fc => fc.ApplicationUser)
           .WithMany()
           .HasForeignKey(fc => fc.UserId)
           .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<HouseModel>()
           .HasOne(fc => fc.ApplicationUser)
           .WithMany()
           .HasForeignKey(fc => fc.UserId)
           .OnDelete(DeleteBehavior.Cascade);


        builder.Entity<FeedbackComplaintModel>()
        .HasOne(fc => fc.Status)
        .WithMany()
        .HasForeignKey(fc => fc.StatusId)
        .OnDelete(DeleteBehavior.Restrict);


        /*  builder.Entity<ServiceRequestModel>()
             .HasOne(s => s.AssignedStaff)
             .WithMany()
             .HasForeignKey(s => s.StaffId)
             .OnDelete(DeleteBehavior.SetNull);
        */

        /* modelBuilder.Entity<ServiceRequestModel>()
         .HasOne(sr => sr.User) // Assuming ServiceRequestModel has a User navigation property
         .WithMany() // A User can have many service requests
         .HasForeignKey(sr => sr.UserId)
         .OnDelete(DeleteBehavior.Restrict);  // Prevent cascade delete


         // You can also configure other relationships the same way
        builder.Entity<StaffProfileModel>()
             .HasOne(sp => sp.UserId)
             .WithMany()
             .HasForeignKey(sp => sp.UserId)
             .OnDelete(DeleteBehavior.Restrict);
        */
   
     

        // 🔹 ServiceRequest ↔ Status (FK)
        builder.Entity<ServiceRequestModel>()
            .HasOne(sr => sr.Status)
            .WithMany() // No navigation property in StatusModel
            .HasForeignKey(sr => sr.StatusId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

        // 🔹 ServiceRequest ↔ RequestType (FK)
        builder.Entity<ServiceRequestModel>()
            .HasOne(sr => sr.RequestType)
            .WithMany()
            .HasForeignKey(sr => sr.RequestTypeId)
            .OnDelete(DeleteBehavior.Cascade);

        // 🔹 ServiceRequest ↔ Homeowner (FK)
        builder.Entity<ServiceRequestModel>()
            .HasOne(sr => sr.Homeowner)
            .WithMany()
            .HasForeignKey(sr => sr.HomeownerId)
            .OnDelete(DeleteBehavior.SetNull);

        // Configure Poll-related relationships
        builder.Entity<PollModel>()
            .HasOne(p => p.Creator)
            .WithMany()
            .HasForeignKey(p => p.CreatorId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<PollQuestionModel>()
            .HasOne(q => q.Poll)
            .WithMany(p => p.Questions)
            .HasForeignKey(q => q.PollId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<QuestionOptionModel>()
            .HasOne(o => o.Question)
            .WithMany(q => q.Options)
            .HasForeignKey(o => o.QuestionId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<PollResponseModel>()
            .HasOne(r => r.Question)
            .WithMany(q => q.Responses)
            .HasForeignKey(r => r.QuestionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<PollResponseModel>()
            .HasOne(r => r.Respondent)
            .WithMany()
            .HasForeignKey(r => r.RespondentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<PollResponseModel>()
            .HasOne(r => r.Poll)
            .WithMany()
            .HasForeignKey(r => r.PollId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<PollResponseModel>()
            .HasOne(r => r.SelectedOption)
            .WithMany(o => o.Responses)
            .HasForeignKey(r => r.SelectedOptionId)
            .OnDelete(DeleteBehavior.Restrict);

       
    }
}
