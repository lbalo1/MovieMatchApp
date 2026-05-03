using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieMatchApp.Data;
using MovieMatchApp.Models;

namespace MovieMatchApp.Pages
{
    public class AddMovieModel : PageModel
    {
        private readonly AppDbContext _context;
        public AddMovieModel(AppDbContext context)
        {

            _context = context;

        }

        [BindProperty]
        public Movie Movie { get; set; }

        [TempData]
        public string SuccessMessage { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            _context.Movies.Add(Movie);
            _context.SaveChanges();

            SuccessMessage = "Movie added successfully!";

            return RedirectToPage("/Watchlist");
        }
    }
}