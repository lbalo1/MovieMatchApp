using Microsoft.EntityFrameworkCore;
using MovieMatchApp.Models;

namespace MovieMatchApp.Data
{
    //Databse context class 
    public class MovieAppContext : DbContext
    {
        //Constuctor for the database context
        public MovieAppContext(DbContextOptions<MovieAppContext> options) : base(options) { }

         // Attributes for the class 
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Mood> Moods { get; set; }
        public DbSet<Watchlist> Watchlists { get; set; }
        public DbSet<RandomSelection> RandomSelections { get; set; }
    }
}