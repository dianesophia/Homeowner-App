using Hometown_Application.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class BillAccountModel
    {
        [Key]
        public int BillAccountId { get; set; }

        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }


        public decimal OutstandingBalance { get; set; } // Total balance

        public DateTime UpdatedOn { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
