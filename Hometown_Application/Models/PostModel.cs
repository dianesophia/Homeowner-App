using Hometown_Application.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class PostModel
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public byte[]? Image { get; set; }
        public DateTime AddedOn { get; set; } = DateTime.Now;
        public string AddedBy { get; set; }
        public bool IsDeleted { get; set; }
        //public virtual List<Comment> Comments { get; set; } = new();

        public virtual List<CommentModel> Comments { get; set; } = new();
        public virtual List<ReactionModel> Reactions { get; set; } = new();
    }
}
