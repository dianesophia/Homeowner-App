using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class FacilityModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

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

        [StringLength(255)]
        public string? ImagePath { get; set; } // Stores the file path of the uploaded image
    }
}