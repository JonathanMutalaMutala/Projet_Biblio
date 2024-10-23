using System.ComponentModel.DataAnnotations;

namespace Projet_Biblio.ViewModel
{
    public class LoginDto
    {
        public string UserName { get; set; }

        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }
        [StringLength(255)]
        public string LastName { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string? ConfirmPassword { get; set; }

        public bool RememberMe { get; set; }

        public string? ReturnUrl { get; set; }

        public string Role { get; set; }
    }
}
