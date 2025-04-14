using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Hometown_Application.Areas.Identity.Data;

namespace Hometown_Application.Models
{
    public class ServiceStaffAssignmentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int ServiceRequestId { get; set; } // FK to ServiceRequest

        [Required]
        [StringLength(450)]
        public string StaffId { get; set; } // FK to ApplicationUser

        [ForeignKey("StaffId")]
        public ApplicationUser Staff { get; set; }

        public bool IsAccepted { get; set; } = false;

        public bool IsUnavailable { get; set; } = false;

        [Required]
        public DateTime AssignedAt { get; set; } = DateTime.UtcNow;

        public DateTime? AcceptedAt { get; set; }
    }

}
