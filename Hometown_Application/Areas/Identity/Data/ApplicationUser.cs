using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Hometown_Application.Models;
using Microsoft.AspNetCore.Identity;

namespace Hometown_Application.Areas.Identity.Data;

public class ApplicationUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string FirstName { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string LastName { get; set; }

    public byte[]? ProfilePicture { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(50)")]
    public string? Gender { get; set; }  // Male, Female, Other
    public bool IsGenderPublic { get; set; } = false;

    [PersonalData]
    public DateTime DateOfBirth { get; set; }
    public bool IsBirthdayPublic { get; set; } = false;

    [PersonalData]
    [Column(TypeName = "nvarchar(500)")]
    public string? Bio { get; set; }

    public bool IsActiveUser { get; set; } = true;

    // ✅ Social Media & Communication Preferences
    [PersonalData]
    [Column(TypeName = "nvarchar(255)")]
    public string? FacebookProfile { get; set; }
    public bool MakeFacebookPublic { get; set;} = false;

    [PersonalData]
    [Column(TypeName = "nvarchar(255)")]
    public string? TwitterProfile { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(255)")]
    public string? LinkedInProfile { get; set; }

    //[PersonalData]
    //public bool ReceiveNewsletter { get; set; } = true; // If they want email updates

    //[PersonalData]
    //public bool ReceiveSMSAlerts { get; set; } = true; // If they want SMS notifications

   
    //[PersonalData]
    //[Column(TypeName = "nvarchar(15)")]
    //public string? AlternatePhoneNumber { get; set; } // Additional contact number

  

    // ✅ Homeowner-Specific Information
  /* [PersonalData]
    [Column(TypeName = "nvarchar(50)")]
    public string? BlockNumber { get; set; }

    [PersonalData]
    public int? LotNumber { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(150)")]
    public string? StreetName { get; set; }

    [PersonalData]
    public DateTime? MoveInDate { get; set; } // When the homeowner moved in

    [PersonalData]
    public DateTime? MoveOutDate { get; set; } // When the homeowner moved in


    [PersonalData]
    public bool IsPromotedToStaff { get; set; } = false; // homeOwner to staff

    [PersonalData]
    public bool IsPromotedToAdmin { get; set; } = false; // homeOwner or staff to admin
  


    // ✅ Staff & Admin Information
    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string? Position { get; set; } // Manager, Maintenance Staff, Security, etc.

    [PersonalData]
    public DateTime? HireDate { get; set; } // Staff employment date

    [PersonalData]
    public decimal? Salary { get; set; } // Salary for staff roles

    [PersonalData]
    public bool IsActiveEmployee { get; set; } = true; // Check if still working

    [PersonalData]
    public bool IsAlsoHomeOwner { get; set; } = false; // if the staff or admin also lived in the subdivision

    [PersonalData]
    [Column(TypeName = "nvarchar(255)")]
    public string? Address { get; set; } // Full address field for the staff/ admin

    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string? EmergencyContactName { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(15)")]
    public string? EmergencyContactNumber { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string? EmergencyContactRelation { get; set; }

    // ✅ Position History Tracking
   // public virtual ICollection<PositionHistory> PositionHistories { get; set; } = new List<PositionHistory>();

    // ✅ Timestamps
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // When user was created
    public DateTime? UpdatedAt { get; set; } // Last updated timestamp
  */




}

