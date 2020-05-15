using Microsoft.EntityFrameworkCore;
using RazorPracite.Models;

namespace RazorPracite.Data
{
    public class RazorPraciteContext : DbContext
    {
        public RazorPraciteContext (DbContextOptions<RazorPraciteContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
