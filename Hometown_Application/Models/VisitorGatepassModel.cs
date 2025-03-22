using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Hometown_Application.Areas.Identity.Data;

namespace Hometown_Application.Models
{
    public class VisitorGatepassModel
    {
        [Key]
        public int VisitorId { get; set; }

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

        [StringLength(50)]
        public string? VehicleType { get; set; }  // Example: Car, Motorcycle, Truck

        [StringLength(20)]
        public string? VehiclePlateNumber { get; set; }  // License Plate Number

        [StringLength(20)]
        public string? VehicleColor { get; set; }  // Example: Red, Blue, Black



        [StringLength(50)]
        public string? ContactNumber { get; set; }

        public DateTime? GatePassIssuedDate { get; set; }

        // Expiry date of the gate pass (optional)
        public DateTime? GatePassExpiryDate { get; set; }


        public bool? IsApproved { get; set; }

        public bool? IsRejected { get; set; }
        public string ApprovalStatus { get; set; } = "Pending";

        public string? AdminNotes { get; set; }

        [StringLength(50)]
        public string? ApprovedBy { get; set; }  // Admin ID or Name

        public DateTime? ApprovedDate { get; set; }
      
        public DateTime? AddedOn { get; set; } = DateTime.UtcNow;
        public string AddedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? UpdatedBy { get; set; }

        public bool? IsDeleted { get; set; } = false;

    }
}
