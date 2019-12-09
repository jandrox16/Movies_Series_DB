using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Movies_Series_DB.Data;
using Movies_Series_DB.Models;

namespace Movies_Series_DB.Pages.Peliculas
{
    public class DetailsModel : PageModel
    {
        private readonly Movies_Series_DB.Data.Movies_Series_DBContext _context;

        public DetailsModel(Movies_Series_DB.Data.Movies_Series_DBContext context)
        {
            _context = context;
        }

        public Pelicula Pelicula { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pelicula = await _context.Pelicula.FirstOrDefaultAsync(m => m.ID == id);

            if (Pelicula == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
