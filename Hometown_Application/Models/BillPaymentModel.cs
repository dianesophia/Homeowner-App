using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hometown_Application.Models
{
    public class BillPaymentModel
    {
        [Key]
        public int PaymentId { get; set; }

        public int BillId { get; set; }
        [ForeignKey("BillId")]
        public BillModel Bill { get; set; }

        public string? PaymentMethod { get; set; }  // e.g., Cash, GCash, PayPal

        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        public decimal AmountPaid { get; set; }

        public string? ReferenceNumber { get; set; } // For GCash/Bank transfer ref no.
    }
}
