using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieMatchApp.Data;
using MovieMatchApp.Models;

namespace MovieMatchApp.Pages
{

// Handles editing an existing movie
    public class EditMovieModel : PageModel
    {
        private readonly AppDbContext _context;

        public EditMovieModel(AppDbContext context)
        {
            _context = context;
        }
        // Binds form data to Movie object 
        [BindProperty]
        public Movie Movie { get; set; }

        public IActionResult OnGet(int id)
        {
            Movie = _context.Movies.Find(id);

            if (Movie == null)
            {
                return RedirectToPage("/Watchlist");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            // Updates movie in database 
            _context.Movies.Update(Movie);
            _context.SaveChanges();

            return RedirectToPage("/Watchlist");
        }
    }
}