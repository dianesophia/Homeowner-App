using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hometown_Application.Data;

public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
    }
    public DbSet<FeedbackComplaintModel> FeedbackComplaints { get; set; }
    public DbSet<EventModel> Events { get; set; }
    public DbSet<DocumentModel> Documents { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<FeedbackComplaintModel>()
           .HasOne(fc => fc.ApplicationUser)
           .WithMany()
           .HasForeignKey(fc => fc.UserId)
           .OnDelete(DeleteBehavior.Cascade);
    }

   
}
