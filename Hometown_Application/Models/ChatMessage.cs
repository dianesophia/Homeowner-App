using System.ComponentModel.DataAnnotations;

namespace Hometown_Application.Models
{
    public class ChatMessage
    {
        [Key]
        public int ChatId { get; set; }

        public string SenderId { get; set; }
        public string RecipientId { get; set; }
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
    }
}
