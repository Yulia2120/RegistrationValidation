

using System.ComponentModel.DataAnnotations;

namespace RegistrationValidation.Model
{
    public class UsersL
    {

        public int Id { get; set; }

        [Required, RegularExpression(@"^.*[a-zA-Z]", ErrorMessage = "Please enter a valid Name.")]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public UsersL() { }

    }
}
