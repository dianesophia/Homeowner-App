using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class RequestTypeModel
    {
        [Key]
        public int RequestTypeId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string? Description { get; set; } // Optional details about the request type

        [Required]
        public StaffDepartment AssignedDepartment { get; set; } // Enum for fixed departments

        public bool IsActive { get; set; } = true;
    }
}
