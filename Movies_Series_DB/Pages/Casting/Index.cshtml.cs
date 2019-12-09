using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Movies_Series_DB.Data;
using Movies_Series_DB.Models;

namespace Movies_Series_DB
{
    public class IndexModel : PageModel
    {
        private readonly Movies_Series_DB.Data.Movies_Series_DBContext _context;

        public IndexModel(Movies_Series_DB.Data.Movies_Series_DBContext context)
        {
            _context = context;
        }

        public IList<Casting> Casting { get;set; }

        public async Task OnGetAsync()
        {
            Casting = await _context.Casting.ToListAsync();
        }
    }
}
