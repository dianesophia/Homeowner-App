using Hometown_Application.Areas.Identity.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class BillTransactionModel
    {
        [Key]
        public int BillTransactionId { get; set; }
        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }


        [Required]
        public int BillItemsId { get; set; }

        [ForeignKey("BillItemsId")]
        public BillItemsModel BillItemsModel { get; set; }


        public decimal AmountPaid { get; set; }
        public string PaymentMethod { get; set; } 
        public DateTime PaymentDate { get; set; } = DateTime.Now;

        [Required]
        [StringLength(50)]
        public string PaidBy { get; set; } // User who made the payment

        public string? PaymentReference { get; set; } // Optional transaction reference

        public bool IsDeleted { get; set; } = false;
    }
}
