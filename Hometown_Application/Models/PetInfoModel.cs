using Hometown_Application.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;

public class PetInfoModel
{
    public int PetInfoId { get; set; }
    public string UserId { get; set; } // Foreign key to ApplicationUser
    public string PetName { get; set; }
    public string PetType { get; set; } // Dog, Cat, etc.
    public string Breed { get; set; }
    public string Color { get; set; }

    [ForeignKey("UserId")]
    public virtual ApplicationUser User { get; set; }
}