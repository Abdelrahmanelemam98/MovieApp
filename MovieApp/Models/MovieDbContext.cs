using Microsoft.EntityFrameworkCore;

namespace MovieApp.Models
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext>option):base(option)
        {}
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> genres { get; set; }
    }
}
