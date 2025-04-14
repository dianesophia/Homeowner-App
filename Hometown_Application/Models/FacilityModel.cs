using System;
using System.ComponentModel.DataAnnotations;

namespace Hometown_Application.Models
{
    public class FacilityModel
    {
        [Key]
        public int FacilityId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public string? OtherType { get; set; }

        [Required]
        public int Capacity { get; set; }

        [StringLength(252)]
        public string Description { get; set; }

        public DateTime AddedOn { get; set; } = DateTime.UtcNow;

        [StringLength(50)]
        public string AddedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

        [StringLength(50)]
        public string? UpdatedBy { get; set; }

        [StringLength(50)]
        public string? ApprovedBy { get; set; }

        public bool IsDeleted { get; set; } = false;

        public bool IsAvailable { get; set; } = true; // New availability status

        public byte[]? Image { get; set; }

        public virtual ICollection<ReservationModel> Reservations { get; set; } = new List<ReservationModel>();
    }
}