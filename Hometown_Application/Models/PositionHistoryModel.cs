using Hometown_Application.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;

public class PositionHistoryModel
{
    public int Id { get; set; }
    public string UserId { get; set; } // Foreign key to ApplicationUser
    public string PreviousPosition { get; set; }
    public string NewPosition { get; set; }
    public DateTime ChangedAt { get; set; } = DateTime.UtcNow;

    [ForeignKey("UserId")]
    public virtual ApplicationUser User { get; set; }
}