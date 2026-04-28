namespace MovieMatchApp.Models
{
    public class Mood
    {
        public int MoodID { get; set; }
        public string MoodName { get; set; }

        public ICollection<Watchlist> Watchlists { get; set; }
    }
}