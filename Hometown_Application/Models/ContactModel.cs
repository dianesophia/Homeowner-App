using System;
using System.ComponentModel.DataAnnotations;

namespace Hometown_Application.Models
{
    public class ContactModel
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string UserId { get; set; }

        [Required, StringLength(50)]    
        public string ContactType { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public DateTime AddedOn { get; set; } = DateTime.UtcNow;

        [StringLength(50)]
        public string AddedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
