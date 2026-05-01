using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieMatchApp.Data;
using MovieMatchApp.Models;

namespace MovieMatchApp.Pages
{
    public class AddMovieModel : PageModel
    {
        [TempData]
        public string SuccessMessage { get; set; }
        private readonly AppDbContext _context;

        public AddMovieModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movies.Add(Movie);
            _context.SaveChanges();

            SuccessMessage = "Movie added successfully! 🎬";

            return RedirectToPage("/Watchlist");
        }
    }
}