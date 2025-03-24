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

    public bool IsApproved { get; set; }

    public AdminProfileModel? AdminProfiles { get; set; }
    public HomeownerProfileModel? HomeownerProfiles { get; set; }
    public StaffProfileModel? StaffProfiles { get; set; }

    public virtual ICollection<ChatMessageModel> SentMessages { get; set; }
    public virtual ICollection<ChatMessageModel> ReceivedMessages { get; set; }

}

