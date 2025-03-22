using Hometown_Application.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class VehicleGatepassModel
    {
        [Key]
        public int VehicleId { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }

        public string VehicleType { get; set; }
        public string VehicleBrand { get; set; }

        public string VehicleColor { get; set; }
        public string VehiclePlateNumber { get; set; }

        public bool IsDeleted { get; set; }

        public bool? IsApproved { get; set; }

        public bool? IsRejected { get; set; }


        public DateTime? ApprovalDate { get; set; }


        public byte[]? VehicleImage { get; set; }

        public string ApprovalStatus { get; set; } = "Pending";
        public string? RejectionReason { get; set; }

        // Gate pass document path (URL or file path to the generated gate pass document)
        public string? GatePassDocument { get; set; }

        // Gate pass QR code (file path or base64 string representing the QR code image)
        public string? QRCode { get; set; }

        // Date when the gate pass was issued (i.e., when the document or QR code was generated)
        public DateTime? GatePassIssuedDate { get; set; }

        // Expiry date of the gate pass (optional)
        public DateTime? GatePassExpiryDate { get; set; }

        public DateTime AddedOn { get; set; } = DateTime.UtcNow;


        [StringLength(50)]
        public string? AddedBy { get; set; }
        
        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string? UpdatedBy { get; set; }


       
    }
}
