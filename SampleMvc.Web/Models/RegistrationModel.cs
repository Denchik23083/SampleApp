using System.ComponentModel.DataAnnotations;

namespace SampleMvc.Web.Models
{
    public class RegistrationModel
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }
        
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Phone]
        public string Phone { get; set; }

        [Required, StringLength(50, MinimumLength = 7), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
