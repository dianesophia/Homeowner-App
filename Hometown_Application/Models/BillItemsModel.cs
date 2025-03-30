using System.ComponentModel.DataAnnotations;

namespace Hometown_Application.Models
{
    public class BillItemsModel
    {
        [Key]
        public int BillItemsID { get; set; }
        public string? PaymentName { get; set; }
        public decimal? Amount { get; set; }
        public string? Description { get; set; }
        public string? PaymentDuration { get; set; } //one time or monthly

        public DateTime AddedOn { get; set; } = DateTime.UtcNow;

        [StringLength(50)]
        public string? AddedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

        [StringLength(50)]
        public string? UpdatedBy { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
