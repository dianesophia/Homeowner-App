using Hometown_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class HomeownerProfileModel
    {
        [Key]
        public int HomeownerId { get; set; }

        [Required]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string? BlockNumber { get; set; }

        [PersonalData]
        public int? LotNumber { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(150)")]
        public string? StreetName { get; set; }

        [PersonalData]
        public DateTime? MoveInDate { get; set; } = DateTime.MinValue;

        [PersonalData]
        public DateTime? MoveOutDate { get; set; } = DateTime.MinValue;

        [PersonalData]
        public bool? IsPromotedToStaff { get; set; } = false;

        public bool? IsPromotedToAdmin { get; set; } = false;

        public bool IsApproved { get; set; } = false;

        public DateTime? ApprovedOn { get; set; } = DateTime.UtcNow;

        public string? ApoprovedBy { get; set; }

        public DateTime? RegisteredOn { get; set; } = DateTime.UtcNow;

    }

}
