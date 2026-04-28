using Microsoft.EntityFrameworkCore;
using MovieMatchApp.Models;

namespace MovieMatchApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Mood> Moods { get; set; }
        public DbSet<Watchlist> Watchlists { get; set; }
        public DbSet<RandomSelection> RandomSelections { get; set; }
    }
}
