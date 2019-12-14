using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Movies_Series_DB.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Msg { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            try
            {
                if (Username.Equals("admin") && Password.Equals("admin"))
                {
                    HttpContext.Session.SetString("username", Username);
                    return RedirectToPage("Welcome");
                }
                else
                {
                    Msg = "Invalid";
                    return Page();
                }

            }catch(NullReferenceException e)
            {
                Console.Write(e);
                return Page();
            }
        }
    }
}
