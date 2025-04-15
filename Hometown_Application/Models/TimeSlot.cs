namespace Hometown_Application.Models
{
    public class TimeSlot
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string DisplayText { get; set; }

        // Static list of allowed time slots
        public static List<TimeSlot> AvailableTimeSlots { get; } = new List<TimeSlot>
        {
            new TimeSlot { StartTime = new TimeSpan(8, 0, 0), EndTime = new TimeSpan(9, 0, 0), DisplayText = "8:00 AM - 9:00 AM" },
            new TimeSlot { StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(11, 0, 0), DisplayText = "10:00 AM - 11:00 AM" },
            new TimeSlot { StartTime = new TimeSpan(12, 0, 0), EndTime = new TimeSpan(13, 0, 0), DisplayText = "12:00 PM - 1:00 PM" },
            new TimeSlot { StartTime = new TimeSpan(14, 0, 0), EndTime = new TimeSpan(15, 0, 0), DisplayText = "2:00 PM - 3:00 PM" },
            new TimeSlot { StartTime = new TimeSpan(16, 0, 0), EndTime = new TimeSpan(17, 0, 0), DisplayText = "4:00 PM - 5:00 PM" }
        };
    }
}