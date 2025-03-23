using Hometown_Application.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class ReactionModel
    {
        [Key]
        public int ReactionId { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        public int PostId { get; set; }

        [ForeignKey("PostId")]
        public PostModel Post { get; set; }

        [Required]
        public string Type { get; set; } = "Like"; // Example: Like, Love, Haha, etc.
    }
}
