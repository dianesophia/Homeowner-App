using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Hometown_Application.Areas.Identity.Data;

namespace Hometown_Application.Models
{
    public class GatepassModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GatepassId { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }

       
        [StringLength(100)]
        public string? VisitorName { get; set; }

        
        public string? Purpose { get; set; }

       
        public DateTime VisitDate { get; set; }

       
        public DateTime? ExpectedArrivalTime { get; set; }

        
        public int? NumberOfVisitors { get; set; }

        [StringLength(100)]
        public string? VisitorVehicleDetails { get; set; }

        
        [StringLength(50)]
        public string? ContactNumber { get; set; }

        
        [StringLength(50)]
        public string? PassNumber { get; set; }

        public DateTime? ExpirationDate { get; set; }

        
        public int? Status { get; set; }  // Enum recommended

        public string? AdminNotes { get; set; }

        [StringLength(50)]
        public string? ApprovedBy { get; set; }  // Admin ID or Name

        public DateTime? ApprovedDate { get; set; }

      
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public bool? IsDeleted { get; set; } = false;

        public DateTime? DeletedAt { get; set; }

        [StringLength(255)]
        public string? PdfPath { get; set; }
    }
}
