namespace MovieMatchApp.Models
{
    public class RandomSelection
    {
        public int RandomselectionID { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public int MovieID { get; set; }
        public Movie Movie { get; set; }

        public string SelectionType { get; set; }
    }
}