using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Frist_app.Models
{
    public class User
    {
        [Key]
        public int SSN { get; set; }
        [Required]
        public string fname { get; set; }
        [Required]
        public string lname { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
    }
}
