using System.ComponentModel;
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
        [RegularExpression(@"^[A-Za-z][A-Za-z0-9 ]*$",
        ErrorMessage = "First name must start with a letter.")]
        [DisplayName("First Name")]
        public string fname { get; set; }


         
        [Required]
        [RegularExpression(@"^[A-Za-z][A-Za-z0-9 ]*$",
        ErrorMessage = "Last name must start with a letter.")]
        [DisplayName("Last Name")]
        public string lname { get; set; }


        public DateTime createdAt { get; set; } = DateTime.Now;
    }
}
