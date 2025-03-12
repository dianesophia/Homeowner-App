using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hometown_Application.Areas.Identity.Data;

namespace Hometown_Application.Models
{
    public class PollModel
    {
        [Key]
        public int PollId { get; set; }

        [Required(ErrorMessage = "The Title field is required.")]
        [StringLength(100, ErrorMessage = "The Title cannot be longer than 100 characters.")]
        public string Title { get; set; }

        [StringLength(500, ErrorMessage = "The Description cannot be longer than 500 characters.")]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? ExpiryDate { get; set; }

        public bool IsActive { get; set; } = true;

        // Foreign key for creator (admin user)
        public string CreatorId { get; set; }

        [ForeignKey("CreatorId")]
        public ApplicationUser Creator { get; set; }

        // Navigation property for questions
        public virtual ICollection<PollQuestionModel> Questions { get; set; } = new List<PollQuestionModel>();
    }
} 