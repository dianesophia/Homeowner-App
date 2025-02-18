using System.ComponentModel.DataAnnotations;

namespace Hometown_Application.Models
{
    public class StatusModel
    {
        [Key]
        public int StatusId { get; set; }
        public string StatusName { get; set; }
    }


}
