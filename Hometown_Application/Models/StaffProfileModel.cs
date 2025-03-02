using Hometown_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class StaffProfileModel
    {
        [Key]
        public int StaffId { get; set; }

        [Required]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Position { get; set; } // e.g., Security, Maintenance, Manager

        [PersonalData]
        public DateTime? HireDate { get; set; }

        [PersonalData]
        public decimal? Salary { get; set; }

        [PersonalData]
        public bool IsActiveEmployee { get; set; } = true;

        [PersonalData]
        public bool IsAlsoHomeOwner { get; set; } = false;

        [PersonalData]
        [Column(TypeName = "nvarchar(255)")]
        public string? Address { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string? EmergencyContactName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(15)")]
        public string? EmergencyContactNumber { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string? EmergencyContactRelation { get; set; }
    }
}
