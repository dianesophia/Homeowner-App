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

        public DateTime IssueDate { get; set; } = DateTime.UtcNow;
        public DateTime DueDate { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Total Amount must be a positive value.")]
        public decimal TotalAmount { get; set; }

        public decimal RemainingBalance { get; set; }

        public string? Status { get; set; } = "Pending"; // Pending, Paid, Overdue

        public string? Remarks { get; set; }

        public bool IsPaid { get; set; }

        public ICollection<BillPaymentModel> Payments { get; set; }

        public BillModel()
        {
            // Initialize the remaining balance with the total amount
            RemainingBalance = TotalAmount;
        }

        // Calculate the total amount of BillItems for this bill
        public void CalculateTotalAmount(IEnumerable<BillItemsModel> billItems)
        {
            // Calculate the total amount by summing the amounts of all bill items
            TotalAmount = billItems.Sum(b => b.Amount ?? 0);
            RemainingBalance = TotalAmount;  // Set the remaining balance to total amount initially
        }

        public void UpdateRemainingBalance(decimal paymentAmount)
        {
            RemainingBalance -= paymentAmount;

            if (RemainingBalance <= 0)
            {
                IsPaid = true;
                RemainingBalance = 0; // Ensure remaining balance doesn't go negative
                Status = "Paid"; // Update status to Paid
            }
            else if (DueDate < DateTime.UtcNow && !IsPaid)
            {
                Status = "Overdue"; // If the due date is past and the bill is not paid, mark as Overdue
            }
        }
    }
}
