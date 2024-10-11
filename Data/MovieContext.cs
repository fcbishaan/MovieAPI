using JobAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace JobAPI.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext>options) : base(options)
        {

        }
        public DbSet<Movie> Movies {get; set;} = null;
    }
    
}