using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPracite.Data;
using RazorPracite.Models;

namespace RazorPracite.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPraciteContext _context;

        public IndexModel(RazorPraciteContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
