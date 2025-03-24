using Hometown_Application.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class CommentModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; } = string.Empty;

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        public int PostId { get; set; }

        [ForeignKey("PostId")]
        public PostModel Post { get; set; }

        public DateTime AddedOn { get; set; } = DateTime.Now;
        public string AddedBy { get; set; }
    }
}
