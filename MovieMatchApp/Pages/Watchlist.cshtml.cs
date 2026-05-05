using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieMatchApp.Data;
using MovieMatchApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MovieMatchApp.Pages
{
    // Displays all movies and handles delete
    public class WatchlistModel : PageModel
    {
        private readonly AppDbContext _context;

        public WatchlistModel(AppDbContext context)
        {
            _context = context;
        }

       // List of movies displayed on page 
        public List<Movie> Movies { get; set; }

        public void OnGet()
        {
            Movies = _context.Movies.ToList();
        }

        public IActionResult OnPostDelete(int id)
        { 
            var movie = _context.Movies.Find(id);

            // Remove if it exist
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
            //to refresh the page
            return RedirectToPage();
        }
    }
}
