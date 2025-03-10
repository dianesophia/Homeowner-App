using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hometown_Application.Models
{
    public class GatepassModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(450)]
        public string HomeownerId { get; set; }  // Foreign key to Homeowner (IdentityUser)

        [Required]
        [StringLength(100)]
        public string VisitorName { get; set; }

        [Required]
        public string Purpose { get; set; }

        [Required]
        public DateTime VisitDate { get; set; }

        [Required]
        public DateTime ExpectedArrivalTime { get; set; }

        [Required]
        public int NumberOfVisitors { get; set; }

        [StringLength(100)]
        public string? VisitorVehicleDetails { get; set; }

        [Required]
        [StringLength(50)]
        public string ContactNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string PassNumber { get; set; }

        public DateTime? ExpirationDate { get; set; }

        [Required]
        public int Status { get; set; }  // Enum recommended

        public string? AdminNotes { get; set; }

        [StringLength(50)]
        public string? ApprovedBy { get; set; }  // Admin ID or Name

        public DateTime? ApprovedDate { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public bool IsDeleted { get; set; } = false;

        public DateTime? DeletedAt { get; set; }

        [StringLength(255)]
        public string? PdfPath { get; set; }
    }
}
