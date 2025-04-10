namespace Hometown_Application.ViewModel
{
    public class BillAssignmentViewModel
    {
        public string BillName { get; set; }
        public decimal AmountDue { get; set; }
        public decimal RemainingBalance { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime DueDate { get; set; }
        public int BillId { get; set; }
        public bool IsPaid { get; set; }
    }
}
