using Hometown_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class AdminProfileModel
    {
        [Key]
        public int AdminId { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string AdminRole { get; set; } // Super Admin, Community Manager, etc.

        [PersonalData]
        public DateTime? AppointedDate { get; set; } = DateTime.UtcNow;

        [PersonalData]
        public bool IsSuperAdmin { get; set; } = false;
    }
}
