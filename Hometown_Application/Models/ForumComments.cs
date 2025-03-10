using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hometown_Application.Models
{
    public class ForumComments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Content { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public bool IsDeleted { get; set; } = false;

        [Required]
        [StringLength(450)]
        public string AuthorId { get; set; }  // Foreign key to User (Identity)

        [Required]
        public int PostId { get; set; }  // Foreign key to ForumPost

        public int? ParentCommentId { get; set; }  // Nullable for top-level comments

        // Navigation properties (optional)
        // public virtual IdentityUser Author { get; set; }
        // public virtual ForumPost Post { get; set; }
        // public virtual ForumComment ParentComment { get; set; }
    }
}
