using System.Collections.Generic;

namespace Hometown_Application.Models
{
    public class ReservationListViewModel
    {
        public List<ReservationModel> Reservations { get; set; } = new List<ReservationModel>();
        public string SearchQuery { get; set; }
        public string StatusFilter { get; set; }
        public int PageNumber { get; set; } = 1;
        public int TotalPages { get; set; } = 1;
    }
}