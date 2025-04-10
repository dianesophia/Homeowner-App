using System.ComponentModel.DataAnnotations;

namespace Hometown_Application.ViewModel
{
    public class PaymentViewModel
    {
        public int BillId { get; set; }

        [Display(Name = "Amount Paid")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public decimal AmountPaid { get; set; }

        [Display(Name = "Payment Method")]
        [Required]
        public string PaymentMethod { get; set; }

        [Display(Name = "Reference Number")]
        [Required]
        public string ReferenceNumber { get; set; }

        [Display(Name = "Remaining Balance")]
        public decimal RemainingBalance { get; set; }
    }
}
    