using LinkedIn_RazorPages.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LinkedIn_RazorPages.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
