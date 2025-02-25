using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hometown_Application.Areas.Identity.Data;

namespace Hometown_Application.Models
{
    public class ReservationModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        public int FacilityId { get; set; } // Consider changing to ForeignKey if it references the Facility table.
  
        [ForeignKey("FacilityId")]
        public FacilityModel Facility { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public DateTime AddedOn { get; set; } = DateTime.UtcNow;

        [StringLength(50)]
        public string AddedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

        [StringLength(50)]
        public string? UpdatedBy { get; set; }

        [StringLength(50)]
        public string? ApprovedBy { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
