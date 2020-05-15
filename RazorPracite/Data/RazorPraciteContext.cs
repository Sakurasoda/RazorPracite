using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<RazorPracite.Models.Movie> Movie { get; set; }
    }
}
