using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class QuestionOptionModel
    {
        [Key]
        public int OptionId { get; set; }

        [Required]
        [StringLength(500)]
        public string OptionText { get; set; }

        public int DisplayOrder { get; set; }

        // Foreign key for question
        public int QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        public PollQuestionModel Question { get; set; }

        // Navigation property for responses
        public virtual ICollection<PollResponseModel> Responses { get; set; } = new List<PollResponseModel>();
    }
} 