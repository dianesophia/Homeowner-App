using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hometown_Application.Models
{
    public class PaymentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int BillId { get; set; } // Foreign key to Bills table

        [Required]
        public string HomeownerId { get; set; } // Foreign key to Homeowners table

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Required]
        public int PaymentMethodId { get; set; } // Foreign key to PaymentMethods table

        [StringLength(100)]
        public string TransactionReference { get; set; }

        public string Notes { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public string PaymentProofFile { get; set; }

        public string VerifiedBy { get; set; }

        public DateTime? VerifiedAt { get; set; }

        public bool IsActive { get; set; } = true;

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        // Navigation properties
        //[ForeignKey("BillId")]
       // public virtual Bill Bill { get; set; }

       // [ForeignKey("PaymentMethodId")]
       // public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
