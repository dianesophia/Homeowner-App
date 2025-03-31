using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class PaymentModel
    {
        [Key]
        public int PaymentID { get; set; }

        [ForeignKey("BillItemsModel")]
        public int BillItemsID { get; set; }

        public decimal AmountPaid { get; set; }
        public string PaymentMethod { get; set; } = "Cash"; // Cash or Online
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
        public string PaidBy { get; set; } = string.Empty; // Homeowner's Name
        public string ReceiptNumber { get; set; } = Guid.NewGuid().ToString(); // Unique Receipt

        public virtual BillItemsModel? BillItem { get; set; }
    }
}
