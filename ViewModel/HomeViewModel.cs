using Projet_Biblio.Models;
using Projet_Biblio.ViewModel.Book;

namespace Projet_Biblio.ViewModel
{
    public class HomeViewModel
    {
        public List<BookDto>? BookDtos { get; set; } 
        public List<User>? AllUsers { get; set; }
    }
}
