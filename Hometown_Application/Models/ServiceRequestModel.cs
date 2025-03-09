using Hometown_Application.Areas.Identity.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Hometown_Application.Models;

    public class ServiceRequestModel
    {
        [Key]
        public int ServiceRequestId { get; set; }

  /*  [Required]
    public string UserId { get; set; }

    [ForeignKey("UserId")]
    public ApplicationUser ApplicationUser { get; set; }
  */


    [Required]
        public string? Category { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public string? Urgency { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        public string? Status { get; set; } = "Pending"; 
        public DateTime? RequestDate { get; set; } = DateTime.Now;

        [StringLength(50)]
        public string? AddedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string? UpdatedBy { get; set; }

        public bool? IsDeleted { get; set; } = false;

    public int? StaffId { get; set; }

    // Navigation Property
    public StaffProfileModel? AssignedStaff { get; set; }

    
}


