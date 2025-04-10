﻿using System;
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

        public decimal TotalAmount { get; set; }
        public decimal RemainingBalance { get; set; }
         
        public string? Status { get; set; } = "Pending"; // Pending, Paid, Overdue

        public string? Remarks { get; set; }

        public bool IsPaid { get; set; }

        public ICollection<BillDetailModel> BillDetails { get; set; }

        public ICollection<BillPaymentModel> Payments { get; set; }

        public BillModel()
        {
            RemainingBalance = TotalAmount;
        }

        public void UpdateRemainingBalance(decimal paymentAmount)
        {
            RemainingBalance -= paymentAmount;

            if (RemainingBalance <= 0)
            {
                IsPaid = true;
                RemainingBalance = 0; // Ensure remaining balance doesn't go negative
            }
        }
    }
}
