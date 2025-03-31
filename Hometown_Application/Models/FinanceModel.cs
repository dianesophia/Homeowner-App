using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class FinanceModel
    {
        [Key]
        public int FinanceID { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int Month { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalRevenue { get; set; } // Sum of all paid bills

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalExpenses { get; set; } // Subdivision expenses

        [NotMapped] // Remove from database, calculate when needed
        public decimal NetBalance => TotalRevenue - TotalExpenses;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public string? AddedBy { get; set; } // User who created the record
        public string? UpdatedBy { get; set; } // User who last modified it

        public bool IsDeleted { get; set; } = false;
    }
}
