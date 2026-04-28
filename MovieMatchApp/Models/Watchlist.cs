namespace MovieMatchApp.Models
{
    public class Watchlist
    {
        public int WatchlistID { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public int MovieID { get; set; }
        public Movie Movie { get; set; }

        public int MoodID { get; set; }
        public Mood Mood { get; set; }

        public bool WatchStatus { get; set; }
        public DateTime DateAdded { get; set; }
    }
}