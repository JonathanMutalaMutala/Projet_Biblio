using Microsoft.AspNetCore.Identity;

namespace Projet_Biblio.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public bool IsActive { get; set; }

    }
}
