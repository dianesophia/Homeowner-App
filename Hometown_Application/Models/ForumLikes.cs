using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hometown_Application.Models
{
    public class ForumLikes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(450)]
        public string UserId { get; set; } // Foreign key to Users table

        public int? PostId { get; set; } // Nullable, a like can be for a post

        public int? CommentId { get; set; } // Nullable, a like can be for a comment

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
