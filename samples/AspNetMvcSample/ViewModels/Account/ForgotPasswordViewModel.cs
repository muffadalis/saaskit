using System.ComponentModel.DataAnnotations;

namespace AspNetMvcSample.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
