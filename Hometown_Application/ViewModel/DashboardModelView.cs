using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hometown_Application.Models;

namespace Hometown_Application.ViewModel
{
    public class DashboardViewModel
    {
        public int TotalUsers { get; set; }
        public int ActiveIssues { get; set; }
        public int TotalDocuments { get; set; }
        public List<string> RecentActivities { get; set; } = new List<string>();
        public List<EventModel> UpcomingEvents { get; set; } = new List<EventModel>();

    }
}