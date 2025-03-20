using Hometown_Application.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hometown_Application.ViewModel
{
    public class PollViewModel
    {
        public int PollId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
        public string Title { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string Description { get; set; }

        [Display(Name = "Expiry Date")]
        [DataType(DataType.Date)]
        public DateTime? ExpiryDate { get; set; }

        public bool IsActive { get; set; } = true;

        public string CreatorId { get; set; }

        public List<QuestionViewModel> Questions { get; set; } = new List<QuestionViewModel>();
    }

    public class QuestionViewModel
    {
        public int QuestionId { get; set; }

        [Required(ErrorMessage = "Question text is required")]
        [StringLength(500, ErrorMessage = "Question text cannot exceed 500 characters")]
        [Display(Name = "Question")]
        public string QuestionText { get; set; }

        [Required(ErrorMessage = "Question type is required")]
        [Display(Name = "Question Type")]
        public QuestionType QuestionType { get; set; }

        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }

        [Display(Name = "Required")]
        public bool IsRequired { get; set; } = true;

        public int PollId { get; set; }

        public List<OptionViewModel> Options { get; set; } = new List<OptionViewModel>();
    }

    public class OptionViewModel
    {
        public int OptionId { get; set; }

        [Required(ErrorMessage = "Option text is required")]
        [StringLength(500, ErrorMessage = "Option text cannot exceed 500 characters")]
        [Display(Name = "Option")]
        public string OptionText { get; set; }

        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }

        public int QuestionId { get; set; }
    }

    public class PollResponseViewModel
    {
        public int PollId { get; set; }
        public string PollTitle { get; set; }
        public string PollDescription { get; set; }
        public List<QuestionResponseViewModel> Questions { get; set; } = new List<QuestionResponseViewModel>();
    }

    public class QuestionResponseViewModel
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public QuestionType QuestionType { get; set; }
        public bool IsRequired { get; set; }
        public int DisplayOrder { get; set; }

        [CustomValidation(typeof(QuestionResponseViewModel), nameof(ValidateTextResponse))]
        public string TextResponse { get; set; }

        public int? SelectedOptionId { get; set; }
        public List<OptionViewModel> Options { get; set; } = new List<OptionViewModel>();

        public static ValidationResult ValidateTextResponse(string textResponse, ValidationContext context)
        {
            var instance = (QuestionResponseViewModel)context.ObjectInstance;
            if (instance.IsRequired && instance.QuestionType == QuestionType.OpenEnded && string.IsNullOrWhiteSpace(textResponse))
            {
                return new ValidationResult("The TextResponse field is required.");
            }
            return ValidationResult.Success;
        }
    }

    public class PollResultsViewModel
    {
        public int PollId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public int TotalResponses { get; set; }
        public List<QuestionResultViewModel> Questions { get; set; } = new List<QuestionResultViewModel>();
    }

    public class QuestionResultViewModel
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public QuestionType QuestionType { get; set; }
        public int ResponseCount { get; set; }

        public List<OptionResultViewModel> Options { get; set; } = new List<OptionResultViewModel>();

        public List<string> TextResponses { get; set; } = new List<string>();
    }

    public class OptionResultViewModel
    {
        public int OptionId { get; set; }
        public string OptionText { get; set; }
        public int Count { get; set; }
        public double Percentage { get; set; }
    }
}