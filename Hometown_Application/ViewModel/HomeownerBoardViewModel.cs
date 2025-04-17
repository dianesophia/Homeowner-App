namespace Hometown_Application.ViewModel
{
    public class HomeownerBoardViewModel
    {
        // Bill Information
        public int BillId { get; set; }
        public decimal RemainingBalance { get; set; }
        public string Status { get; set; }
        public string BillName { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        // Payment Information
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal AmountPaid { get; set; }
        public string PaymentMethod { get; set; }
        public string ReferenceNumber { get; set; }

        public bool IsApproved { get; set; }
    }
}
    