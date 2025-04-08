namespace Hometown_Application.Models
{
    public class BillDetailModel
    {
        [Key]
        public int BillDetailId { get; set; }

        public int BillId { get; set; }
        [ForeignKey("BillId")]
        public BillModel Bill { get; set; }

        public int BillItemsID { get; set; }
        [ForeignKey("BillItemsID")]
        public BillItemsModel BillItemType { get; set; }

        public decimal? CustomAmount { get; set; }  // Optional override of default amount
        public decimal ActualAmount { get; set; }   // Final charge

        public string Status { get; set; } = "Pending"; // Optional: Paid, Waived, etc.
        public string? Notes { get; set; }  
    }
}
