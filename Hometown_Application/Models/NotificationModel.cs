using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hometown_Application.Models
{
    public class NotificationModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Message { get; set; }

        public string? Link { get; set; }

        [Required]
        [StringLength(450)]
        public string RecipientId { get; set; }  // Assuming this maps to a UserId in Identity

        [Required]
        [StringLength(450)]
        public string SenderId { get; set; }  // Assuming this maps to a UserId in Identity

        public bool IsRead { get; set; } = false;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? ReadAt { get; set; }

        public bool IsDeleted { get; set; } = false;

        public DateTime? DeletedAt { get; set; }

        [Required]
        public int Type { get; set; } 
    }
}
