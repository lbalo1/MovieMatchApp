namespace MovieMatchApp.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string Mood { get; set; }
        public string Description { get; set; }
        public int ReleaseYear { get; set; }
        public int Runtime { get; set; }

        public ICollection<Watchlist> Watchlists { get; set; }
    }
}