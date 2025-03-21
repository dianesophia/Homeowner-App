using Hometown_Application.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class VehicleGatepassModel
    {
        [Key]
        public int VehicleId { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }
        public string VehicleBrand { get; set; }

        public string VehicleColor { get; set; }
        public string VehiclePlateNumber { get; set; }

        public bool IsDeleted { get; set; }



    }
}
