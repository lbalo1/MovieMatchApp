using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieMatchApp.Data;
using MovieMatchApp.Models;
using System;
using System.Linq;

namespace MovieMatchApp.Pages
{
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
            var movies = _context.Movies.ToList();

            if (movies.Count > 0)
            {
                Random rand = new Random();
                int index = rand.Next(movies.Count);

                SelectedMovie = movies[index];
            }
        }
    }
}