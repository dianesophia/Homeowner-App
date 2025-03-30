using Hometown_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{

    public class StaffProfileModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffId { get; set; }

        [Required]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }

        // Correctly retrieving ProfilePicture as a byte array
        [NotMapped]
        public byte[]? ProfilePicture => ApplicationUser?.ProfilePicture ?? Array.Empty<byte>();

        [NotMapped]
        public string FirstName => ApplicationUser?.FirstName ?? string.Empty;

        [NotMapped]
        public string LastName => ApplicationUser?.LastName ?? string.Empty;

        [PersonalData]
        [Required]
        public StaffDepartment Department { get; set; } // Enum for department names

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Position { get; set; } // e.g., Security Officer, Maintenance Supervisor

        [PersonalData]
        public DateTime? HireDate { get; set; }

        [PersonalData]
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Salary { get; set; }

        [PersonalData]
        public bool IsActiveEmployee { get; set; } = true;

        [PersonalData]
        public bool IsAlsoHomeOwner { get; set; } = false;

       /* public int? HouseId { get; set; }
        [ForeignKey("HouseId")]
        public HouseModel? House { get; set; }
       */
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

        [PersonalData]
        public bool? IsFired { get; set; } = false;

        public string? AccountCreatedBy { get; set; }

        public DateTime? AccountCreatedOn { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string? UpdatedBy { get; set; }

        public bool IsDeleted { get; set; } = false;

       

    }
}
