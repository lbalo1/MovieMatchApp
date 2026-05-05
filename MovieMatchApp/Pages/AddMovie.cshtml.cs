using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieMatchApp.Data;
using MovieMatchApp.Models;

namespace MovieMatchApp.Pages
{

    // Handles adding a new movie to the database
    public class AddMovieModel : PageModel
    {
        private readonly AppDbContext _context;
        public AddMovieModel(AppDbContext context)
        {

            _context = context;

        }
         
        // Binds form inputs to Movie object
        [BindProperty]
        public Movie Movie { get; set; }

        // Temporary message to show success
        [TempData]
        public string SuccessMessage { get; set; }

        // Runs when page loads
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Adds movie to database
            _context.Movies.Add(Movie);
            _context.SaveChanges();
            

            // Redirects to watchlist page aftering movie is added 
            return RedirectToPage("/Watchlist");
        }
    }
}