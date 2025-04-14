namespace Hometown_Application.ViewModel
{
    public class HomeownerBoardViewModel
    {
        public int BillId { get; set; }
        public decimal RemainingBalance { get; set; }
        public string Status { get; set; }
        public string BillName { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
    }

}
