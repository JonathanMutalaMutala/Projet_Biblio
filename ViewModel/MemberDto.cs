using System.ComponentModel.DataAnnotations;

namespace Projet_Biblio.ViewModel
{
    public class MemberDto
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

    }
}
