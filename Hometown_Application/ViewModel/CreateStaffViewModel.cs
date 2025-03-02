using System.ComponentModel.DataAnnotations;

namespace Hometown_Application.ViewModel
{
    public class CreateStaffViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // StaffProfileModel properties
        [Required]
        public string Position { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        [Required]
        public decimal Salary { get; set; }
    }
}
