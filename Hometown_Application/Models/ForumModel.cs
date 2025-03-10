using System.ComponentModel.DataAnnotations;

namespace Hometown_Application.Models
{
    public class ForumModel
    {
        public int ForumId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public HomeownerProfileModel HomeownerId { get; set; }

        public DateTime UpdatedOn { get; set; }

        [StringLength(50)]
        public string? UpdatedBy { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
