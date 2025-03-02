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

    public DbSet<HomeownerProfileModel> HomeownerProfiles { get; set; }

    public DbSet<FeedbackComplaintModel> FeedbackComplaints { get; set; }
    public DbSet<EventModel> Events { get; set; }
    public DbSet<DocumentModel> Documents { get; set; }
    public DbSet<ContactModel> Contacts { get; set; }
    public DbSet<StatusModel> Status { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

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

        builder.Entity<HomeownerProfileModel>()
          .HasOne(fc => fc.ApplicationUser)
          .WithMany()
          .HasForeignKey(fc => fc.UserId)
          .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<StaffProfileModel>()
        .HasOne(fc => fc.ApplicationUser)
        .WithMany()
        .HasForeignKey(fc => fc.UserId)
        .OnDelete(DeleteBehavior.Cascade);

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


        builder.Entity<FeedbackComplaintModel>()
        .HasOne(fc => fc.Status)
        .WithMany()
        .HasForeignKey(fc => fc.StatusId)
        .OnDelete(DeleteBehavior.Restrict);

       
    }
}
