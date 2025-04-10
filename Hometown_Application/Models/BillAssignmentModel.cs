using Hometown_Application.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class BillAssignmentModel
    {
        [Key]
        public int BillAssignmentId { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser ApplicationUser { get; set; }

        public int? BillId { get; set; }  // Foreign Key to Bill model
        [ForeignKey("BillId")]
        public BillModel Bill { get; set; }

        public string BillName { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; } 

        public DateTime IssuedDate { get; set; } = DateTime.UtcNow;
        public string? Remarks { get; set; }

        public bool IsPaid { get; set; } = false;

        public DateTime? PaidDate { get; set; }

        public DateTime AddedOn { get; set; } = DateTime.UtcNow;

        [StringLength(50)]
        public string AddedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        [StringLength(50)]
        public string? UpdatedBy { get; set; }

        public bool IsDeleted { get; set; } = false;

        public IEnumerable<ApplicationUser> Users { get; set; }
    }
}
