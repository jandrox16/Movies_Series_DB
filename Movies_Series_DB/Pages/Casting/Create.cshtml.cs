using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Movies_Series_DB.Data;
using Movies_Series_DB.Models;

namespace Movies_Series_DB
{
    public class CreateModel : PageModel
    {
        private readonly Movies_Series_DB.Data.Movies_Series_DBContext _context;

        public CreateModel(Movies_Series_DB.Data.Movies_Series_DBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Casting Casting { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Casting.Add(Casting);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}