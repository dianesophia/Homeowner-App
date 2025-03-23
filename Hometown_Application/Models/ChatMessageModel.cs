using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hometown_Application.Areas.Identity.Data; // Import your user model

namespace Hometown_Application.Models
{
    public class ChatMessageModel
    {
        [Key]
        public int ChatId { get; set; }

        // Foreign Key for Sender
        [ForeignKey("Sender")]
        public string SenderId { get; set; }
        public ApplicationUser Sender { get; set; }

        // Foreign Key for Recipient
        [ForeignKey("Recipient")]
        public string RecipientId { get; set; }
        public ApplicationUser Recipient { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
