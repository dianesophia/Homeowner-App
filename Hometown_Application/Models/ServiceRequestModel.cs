using Hometown_Application.Areas.Identity.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public enum UrgencyLevel
    {
        Low,
        Medium,
        High
    }

    public class ServiceRequestModel
    {
        [Key]
        public int ServiceRequestId { get; set; }

        [Required]
        [StringLength(500)]
        public string Details { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }

        [Required]
        public UrgencyLevel Urgency { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime Schedule { get; set; }

        [StringLength(500)]
        public string? RejectedReason { get; set; }

        public DateTime? RejectedOn { get; set; }

        [StringLength(500)]
        public string? CancelReason { get; set; }

        public DateTime? CancelledOn { get; set; }

        public DateTime? CompletedOn { get; set; }

        public DateTime AddedOn { get; set; } = DateTime.UtcNow;

        [StringLength(50)]
        public string? AddedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string? UpdatedBy { get; set; }

        public bool IsDeleted { get; set; } = false;

        [Required]
        public int RequestTypeId { get; set; }

        [ForeignKey("RequestTypeId")]
        public RequestTypeModel? RequestType { get; set; }

        public int? HomeownerId { get; set; }

        [ForeignKey("HomeownerId")]
        public HomeownerProfileModel? Homeowner { get; set; }

        [Required]
        public int StatusId { get; set; }

        [ForeignKey("StatusId")]
        public StatusModel? Status { get; set; }

        public string? UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser? User { get; set; }
    }
}