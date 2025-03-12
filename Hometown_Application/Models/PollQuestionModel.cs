using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hometown_Application.Data;
using Hometown_Application.Models;

namespace Hometown_Application.Models
{
    public class PollQuestionModel
    {
        [Key]
        public int QuestionId { get; set; }

        [Required]
        [StringLength(500)]
        public string QuestionText { get; set; }

        // Question type (Multiple choice, Open-ended, etc.)
       
        public QuestionType QuestionType { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsRequired { get; set; } = true;

        // Foreign key for poll
        public int PollId { get; set; }

        [ForeignKey("PollId")]
        public PollModel Poll { get; set; }

        // Navigation property for options (only for multiple choice questions)
        public virtual ICollection<QuestionOptionModel> Options { get; set; } = new List<QuestionOptionModel>();

        // Navigation property for responses
        public virtual ICollection<PollResponseModel> Responses { get; set; } = new List<PollResponseModel>();
    }
} 