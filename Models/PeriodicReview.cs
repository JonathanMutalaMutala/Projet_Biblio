namespace Projet_Biblio.Models
{
    public class PeriodicReview : Document
    {
        public string PeriodicReviewId { get; set; }
        public string Description { get; set; }
        public DateTime ParitionDate { get; set; }
        public DateTime NextParitionDate { get; set; }
        public bool IsActive { get; set; }

    }
}
