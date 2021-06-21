using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgoraFE.Pages
{
    public class ProfileModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public IActionResult OnGet()
        {
            if (Name == null)
            {
                return RedirectToPage("/Error", new { code = 404 });
            }


            return Page();
        }
    }
}
