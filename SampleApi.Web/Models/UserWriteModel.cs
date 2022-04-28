using System.ComponentModel.DataAnnotations;

namespace SampleApi.Web.Models
{
    public class UserWriteModel
    {
        [Required, MinLength(5)]
        public string Username { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(50, MinimumLength = 7)]
        public string Password { get; set; }
    }
}
