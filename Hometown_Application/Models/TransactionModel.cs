using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }

        [Required]
        public int BillItemsID { get; set; }

        [ForeignKey("BillItemsID")]
        public BillItemsModel BillItem { get; set; }

        [Required]
        public decimal AmountPaid { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        [Required]
        [StringLength(50)]
        public string PaidBy { get; set; } // User who made the payment

        public string? PaymentReference { get; set; } // Optional transaction reference

        public bool IsDeleted { get; set; } = false;
    }
}
