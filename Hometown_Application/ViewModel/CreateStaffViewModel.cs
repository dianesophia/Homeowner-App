using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Hometown_Application.Models; // Import for StaffDepartment Enum

namespace Hometown_Application.ViewModel
{
    public class CreateStaffViewModel
    {
        public byte[]? ProfilePicture { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Phone]
        [StringLength(15, ErrorMessage = "Phone number must be at most 15 characters long")]
        public string? PhoneNumber { get; set; } // Added from AspNetUsers table

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string? BlockNumber { get; set; }


        public int? LotNumber { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string? StreetName { get; set; }

        [Required]
        public StaffDepartment Department { get; set; } // Use Enum for department names

        [Required]
        public string Position { get; set; } // e.g., Security Officer, Maintenance Supervisor

        [Required]
        public DateTime HireDate { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Salary must be a positive value")]
        public decimal Salary { get; set; }

        public bool IsActiveEmployee { get; set; } = true;

        public bool IsAlsoHomeOwner { get; set; } = false;

        [StringLength(255)]
        public string? Address { get; set; }

        [StringLength(100)]
        public string? EmergencyContactName { get; set; }

        [StringLength(15)]
        public string? EmergencyContactNumber { get; set; }

        [StringLength(100)]
        public string? EmergencyContactRelation { get; set; }

        public string? AccountCreatedBy { get; set; }

        public DateTime? AccountCreatedOn { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string? UpdatedBy { get; set; }

        public bool IsDeleted { get; set; } = false;

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
        public string Password { get; set; }
    }
}
