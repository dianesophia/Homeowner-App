using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class BillFeeModel
    {
        [Key]
        public int BillFeeID { get; set; }

        public int BillAssignmentId { get; set; }
        [ForeignKey("BillAssignmentId")]
        public BillAssignmentModel BillAssignment { get; set; }


        public decimal AmountPaid { get; set; }
        public string PaymentMethod { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;

    }
}
