using System.ComponentModel.DataAnnotations;

namespace CleanArch.BaseApi.Application.ServiceModel.Auth
{
    public class RegistrationRequest
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string UserName { get; set; }

        [Required]
        [MinLength(6)]
        [RegularExpression("^(?=.*[A-Z])(?=.*\\d)(?=.*[!@#$%^&*()_+~\\-=?<>]).*$", 
            ErrorMessage = "Your password must have at least one uppercase letter, number and special character")]
        public string Password { get; set; }
    }
}
