using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hometown_Application.Models
{
    public class ServiceStaffAssignmentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int ServiceRequestId { get; set; } // Foreign key to ServiceRequest

        [Required]
        [StringLength(450)]
        public string StaffId { get; set; } // Foreign key to Staff

        public bool IsAccepted { get; set; } = false; // Default: Not accepted

        public bool IsUnavailable { get; set; } = false; // Default: Available

        [Required]
        public DateTime AssignedAt { get; set; } = DateTime.UtcNow;

        public DateTime? AcceptedAt { get; set; }
    }
}
