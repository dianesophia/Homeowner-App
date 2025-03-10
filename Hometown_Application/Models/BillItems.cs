using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hometown_Application.Models
{
    public class BillItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int BillId { get; set; } // Foreign key to Bills table

        [Required]
        public int FeeTypeId { get; set; } // Foreign key to FeeTypes table

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public string Notes { get; set; }

        public bool IsActive { get; set; } = true;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
     /*   [ForeignKey("BillId")]
        public virtual Bill Bill { get; set; }

        [ForeignKey("FeeTypeId")]
        public virtual FeeType FeeType { get; set; }
     */
    }
}
