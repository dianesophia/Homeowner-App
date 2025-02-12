using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{

    public class EventModel
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Title { get; set; }

        [Required]
        public DateTime DateTimeStart { get; set; }

        public DateTime? DateTimeEnd { get; set; }

        [StringLength(255)]
        public string Location { get; set; }

     //   public int Organizer { get; set; } 

        public DateTime AddedOn { get; set; } = DateTime.UtcNow;

        [StringLength(50)]
        public string AddedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
