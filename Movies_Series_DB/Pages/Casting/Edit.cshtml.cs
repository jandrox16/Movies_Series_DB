using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Movies_Series_DB.Data;
using Movies_Series_DB.Models;

namespace Movies_Series_DB
{
    public class EditModel : PageModel
    {
        private readonly Movies_Series_DB.Data.Movies_Series_DBContext _context;

        public EditModel(Movies_Series_DB.Data.Movies_Series_DBContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Casting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CastingExists(Casting.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CastingExists(int id)
        {
            return _context.Casting.Any(e => e.ID == id);
        }
    }
}
