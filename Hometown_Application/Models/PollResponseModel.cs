using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hometown_Application.Areas.Identity.Data;

namespace Hometown_Application.Models
{
    public class PollResponseModel
    {
        [Key]
        public int ResponseId { get; set; }

        // For open-ended questions
        [StringLength(2000)]
        public string? TextResponse { get; set; }

        // For multiple choice questions
        public int? SelectedOptionId { get; set; }

        [ForeignKey("SelectedOptionId")]
        public QuestionOptionModel? SelectedOption { get; set; }

        // Foreign key for question
        public int QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        public PollQuestionModel Question { get; set; }

        // Foreign key for poll
        public int PollId { get; set; }

        [ForeignKey("PollId")]
        public PollModel Poll { get; set; }

        // Foreign key for respondent (user)
        public string? RespondentId { get; set; }

        [ForeignKey("RespondentId")]
        public ApplicationUser? Respondent { get; set; }

        // For anonymous responses
        public bool IsAnonymous { get; set; } = false;

        [Required]
        public DateTime SubmissionDate { get; set; } = DateTime.Now;
    }
} 