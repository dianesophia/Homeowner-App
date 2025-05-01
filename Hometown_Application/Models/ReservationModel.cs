using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hometown_Application.Areas.Identity.Data;

namespace Hometown_Application.Models
{
    public class ReservationModel
    {
        [Key]
        public int ReservationId { get; set; }

        [Required(ErrorMessage = "Please select a facility")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid facility")]
        public int FacilityId { get; set; }

        [ForeignKey("FacilityId")]
        public FacilityModel? Facility { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser? ApplicationUser { get; set; }

        [Required(ErrorMessage = "Reservation date is required")]
        [DataType(DataType.Date)]
        public DateTime ReservationDate { get; set; }

        [Required(ErrorMessage = "Start time is required")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "End time is required")]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

        public DateTime AddedOn { get; set; } = DateTime.UtcNow;

        [StringLength(50)]
        public string? AddedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string? UpdatedBy { get; set; }

        public bool IsDeleted { get; set; } = false;

        public string? Status { get; set; }

        // New property to hold the selected time slot index from the dropdown
        [Required(ErrorMessage = "Please select a time slot")]
        public int SelectedTimeSlotIndex { get; set; }
    }
}