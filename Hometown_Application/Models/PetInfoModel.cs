using Hometown_Application.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class PetInfoModel
{
    [Key]
    public int PetInfoId { get; set; }

    [Required]
    public string UserId { get; set; }
    [ForeignKey("UserId")]
    public ApplicationUser ApplicationUser { get; set; }
    public string PetName { get; set; }
    public string PetType { get; set; } // Dog, Cat, etc.
    public string Breed { get; set; }
    public string Color { get; set; }

    [ForeignKey("UserId")]
    public virtual ApplicationUser User { get; set; }
}