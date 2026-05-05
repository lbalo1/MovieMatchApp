using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieMatchApp.Data;
using MovieMatchApp.Models;
using System.Linq;
using System.Collections.Generic;

namespace MovieMatchApp.Pages
{
    public class MoodQuizModel : PageModel
    {
        private readonly AppDbContext _context;

        public MoodQuizModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<string> Answers { get; set; }

        public Movie RecommendedMovie { get; set; }

        public void OnGet() { }

        public void OnPost()
        {
            // Count moods
            var moodScores = new Dictionary<string, int>();

            foreach (var answer in Answers)
            {
                var mood = MapToMovieMood(answer);

                if (!moodScores.ContainsKey(mood))
                    moodScores[mood] = 0;

                moodScores[mood]++;
            }

            // Get top mood
            var topMood = moodScores.OrderByDescending(x => x.Value).First().Key;

            // Get movie with that mood
            var movies = _context.Movies
                .Where(m => m.Mood == topMood)
                .ToList();

            var random = new Random();

            if (movies.Any())
            {
                RecommendedMovie = movies[random.Next(movies.Count)];
            }
        }

        private string MapToMovieMood(string answer)
        {
            return answer switch
            {
                "Happy" => "FeelGood",
                "Relaxed" => "Chill",
                "Excited" => "Action",
                "Sad" => "Depressing",

                "Funny" => "Funny",
                "Dark" => "Dark",
                "Romantic" => "Romantic",
                "Action" => "Action",

                "Lighthearted" => "FeelGood",
                "Suspenseful" => "Suspenseful",
                "MindBlowing" => "MindBlowing",
                "Calm" => "Chill",

                "TearJerker" => "Depressing",
                "Heartwarming" => "FeelGood",
                "Thriller" => "Suspenseful",
                "Comedy" => "Funny",

                "Depressing" => "Depressing",
                "FeelGood" => "FeelGood",
                "Intense" => "Action",
                "Chill" => "Chill",

                _ => "FeelGood"
            };
        }
    }
}
