using System.ComponentModel.DataAnnotations;

namespace Projet_Biblio.ViewModel.Book
{
    public class BookDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Title { get; set; }


        [Required]
        [StringLength(25)]
        public string Author { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime DatePublication { get; set; }
        public string Category { get; set; }

        [Required]
        [StringLength(25)]
        public string ISBN { get; set; }
        public string NumberOfPages { get; set; }
        public bool IsActive { get; set; }
    }
}
