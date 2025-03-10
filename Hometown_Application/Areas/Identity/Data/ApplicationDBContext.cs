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
    public DbSet<HouseModel> House { get; set; }
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
    public DbSet<ServiceRequestModel> ServiceRequests { get; set; }

    public DbSet<RequestTypeModel> RequestTypes { get; set; }
    public DbSet<ServiceStaffAssignmentModel> ServiceStaffAssignments { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
            base.OnModelCreating(builder);
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

        builder.Entity<IdentityRole>().ToTable("AspNetRoles").HasKey(r => r.Id);
        builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(u => u.Id);

  
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



        // ✅ Seeding Roles
       /* var roles = new List<IdentityRole>
        {
            new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
            new IdentityRole { Id = "2", Name = "HomeOwner", NormalizedName = "HOMEOWNER" },
            new IdentityRole { Id = "3", Name = "Staff", NormalizedName = "STAFF" }
        };
        builder.Entity<IdentityRole>().HasData(roles);*/

        // ✅ Seeding Users
        var hasher = new PasswordHasher<ApplicationUser>();

        var users = new List<ApplicationUser>
        {
            new ApplicationUser
            {
                Id = "100",  // Unique GUID
                UserName = "elon.musk@example.com",
                NormalizedUserName = "ELON.MUSK@EXAMPLE.COM",
                Email = "elon.musk@example.com",
                NormalizedEmail = "ELON.MUSK@EXAMPLE.COM",
                EmailConfirmed = true,
                FirstName = "Elon",
                LastName = "Musk",
                PasswordHash = hasher.HashPassword(null, "ElonMusk123*")
            },
            /*new ApplicationUser
            {
                Id = "101",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                FirstName = "Admin",
                LastName = "User",
                PasswordHash = hasher.HashPassword(null, "Admin123*")
            }*/
        };
        builder.Entity<ApplicationUser>().HasData(users);

        // ✅ Seeding User Roles
        var userRoles = new List<IdentityUserRole<string>>
        {
          //  new IdentityUserRole<string> { UserId = "100", RoleId = "2" },  // Elon Musk → Staff
          //  new IdentityUserRole<string> { UserId = "101", RoleId = "1" }   // Admin → Admin
        };


        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
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

        builder.Entity<StaffProfileModel>()
     .HasOne(s => s.House)
     .WithMany()
     .HasForeignKey(s => s.HouseId)
     .OnDelete(DeleteBehavior.Restrict);

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
   
        base.OnModelCreating(builder);

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

    }
}
