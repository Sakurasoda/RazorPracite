﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPracite.Data;
using RazorPracite.Models;

namespace RazorPracite.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPracite.Data.RazorPraciteContext _context;

        public IndexModel(RazorPracite.Data.RazorPraciteContext context)
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
