using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hometown_Application.Models
{
    public class DocumentModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DocumentName { get; set; }

        public string DocumentType { get; set; }

        [Required]
        public string FilePath { get; set; } 

        public long FileSize { get; set; } 

        public DateTime UploadedOn { get; set; } = DateTime.Now;

        [StringLength(50)]
        public string UploadedBy { get; set; }

        public DateTime UpdatedOn { get; set; } = DateTime.Now;

        [StringLength(50)]
        public string? UpdatedBy { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
