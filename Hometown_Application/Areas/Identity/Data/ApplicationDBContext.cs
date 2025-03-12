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
    
    // Add Poll and Survey related DbSets
    public DbSet<PollModel> Polls { get; set; }
    public DbSet<PollQuestionModel> PollQuestions { get; set; }
    public DbSet<QuestionOptionModel> QuestionOptions { get; set; }
    public DbSet<PollResponseModel> PollResponses { get; set; }
    
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
