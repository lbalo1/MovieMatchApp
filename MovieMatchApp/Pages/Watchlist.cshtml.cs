using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieMatchApp.Data;
using MovieMatchApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieMatchApp.Pages
{
    public class WatchlistModel : PageModel
    {
        private readonly AppDbContext _context;

        public WatchlistModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Movie> Movies { get; set; }

        public void OnGet()
        {
            Movies = _context.Movies.ToList();
        }
    }
}
