using Microsoft.AspNetCore.Identity;

namespace Projet_Biblio.Models
{
    public class Role: IdentityRole
    {
        public string? Description { get; set; }

    }
}
