using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieMatchApp.Data;
using MovieMatchApp.Models;
using System;
using System.Linq;

namespace MovieMatchApp.Pages
{
    // Completely selects a random movie from the watchlist 
    public class RandomMovieModel : PageModel
    {
        private readonly AppDbContext _context;

        public RandomMovieModel(AppDbContext context)
        {
            _context = context;
        }

        public Movie SelectedMovie { get; set; }

        public void OnGet()
        {
            // Get all movies
            var movies = _context.Movies.ToList();

            // IF there are movies, pick random one 
            if (movies.Count > 0)
            {
                Random rand = new Random();
                int index = rand.Next(movies.Count);

                SelectedMovie = movies[index];
            }
        }
    }
}