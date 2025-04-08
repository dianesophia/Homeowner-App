using Hometown_Application.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class HouseModel
    {
        [Key]
        public int? HouseId { get; set; }

        [Required, ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Column(TypeName = "nvarchar(50)"), Required]
        public string BlockName { get; set; }

        [Required]
        public int LotNumber { get; set; }

        [Column(TypeName = "nvarchar(150)"), Required]
        public string StreetName { get; set; }

        public bool? IsOccupied { get; set; } = false;

        public ICollection<HomeownerProfileModel> Homeowners { get; set; } = new List<HomeownerProfileModel>();
    }
}
