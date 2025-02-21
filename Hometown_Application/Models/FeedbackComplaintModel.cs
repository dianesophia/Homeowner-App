using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hometown_Application.Areas.Identity.Data;

namespace Hometown_Application.Models
{
    public class FeedbackComplaintModel
    {
        [Key]
        public int FeedbackComplaintId { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        public string Type { get; set; } // "Feedback" or "Complaint"


        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public byte[]? Image { get; set; }

        [Required]
        [StringLength(5000)]
        public string Message { get; set; }

        [Required]
        [ForeignKey("StatusModel")]
        public int? StatusId { get; set; } = 3;  

        public StatusModel Status { get; set; }

        public string? AdminReply { get; set; }

        public string? AdminNote { get; set; }

        public string AddedBy { get; set; } 
        public DateTime AddedOn { get; set; } = DateTime.UtcNow; 

        public string? UpdatedBy { get; set; } 

        public DateTime? UpdatedOn { get; set; } 

        public bool IsDeleted { get; set; } = false; 
    }
}
