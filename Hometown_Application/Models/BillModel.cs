using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Hometown_Application.Areas.Identity.Data;

namespace Hometown_Application.Models
{
    public class BillModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillId { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        public DateTime BillingDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; private set; } // Auto-calculated from BillItems

        [Column(TypeName = "decimal(18,2)")]
        public decimal PaidAmount { get; private set; } = 0;

        [Column(TypeName = "decimal(18,2)")]
        public decimal BalanceAmount { get; private set; } = 0;

        [Required]
        public string BillingPeriod { get; set; } // e.g., "January 2024"

        public DateTime? PaidDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; private set; } = "Pending"; // Auto-updated

        public bool IsPenaltyApplied { get; set; } = false;

        [Column(TypeName = "decimal(18,2)")]
        public decimal PenaltyAmount { get; set; } = 0;

        public string? PaymentReference { get; set; }
        public string? Notes { get; set; }
        public bool IsActive { get; set; } = true;

        [Required]
        public DateTime AddedOn { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedOn { get; set; }

        public string? AddedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public bool IsDeleted { get; set; } = false;

        // Navigation Property: A Bill can have multiple Bill Items
        public virtual ICollection<BillItemsModel> BillItems { get; set; } = new List<BillItemsModel>();

        // Method to Recalculate Total, Balance, and Update Status
        public void RecalculateBill()
        {
            TotalAmount = BillItems.Sum(item => item.Amount ?? 0);
            BalanceAmount = TotalAmount - PaidAmount;

            if (BalanceAmount <= 0)
            {
                Status = "Paid";
                PaidDate = DateTime.UtcNow;
            }
            else if (DateTime.UtcNow > DueDate)
            {
                Status = "Overdue";
            }
            else
            {
                Status = "Pending";
            }
        }

        // Method to Apply a Payment
        public void ApplyPayment(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Payment amount must be greater than zero.");

            PaidAmount += amount;
            RecalculateBill();
        }
    }
}
