using Hometown_Application.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class VehicleModel
    {
        [Key]
        public int VehicleId { get; set; }
        //public string UserId { get; set; }
        public string PlateNumber { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.UtcNow; 

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}
