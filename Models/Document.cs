namespace Projet_Biblio.Models
{
    public abstract class Document
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }
        public DateTime DatePublication { get; set; }

        public string? Category { get; set; }

        public bool IsActive { get; set; }
    }
}
