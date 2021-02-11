using System.ComponentModel.DataAnnotations;

namespace FizzAPI.Domain.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
