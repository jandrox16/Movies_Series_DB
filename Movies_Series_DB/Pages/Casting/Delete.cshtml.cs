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
    public class DeleteModel : PageModel
    {
        private readonly Movies_Series_DB.Data.Movies_Series_DBContext _context;

        public DeleteModel(Movies_Series_DB.Data.Movies_Series_DBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Casting Casting { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Casting = await _context.Casting.FirstOrDefaultAsync(m => m.ID == id);

            if (Casting == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Casting = await _context.Casting.FindAsync(id);

            if (Casting != null)
            {
                _context.Casting.Remove(Casting);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
