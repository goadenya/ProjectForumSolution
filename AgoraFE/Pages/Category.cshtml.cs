using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgoraFE.Pages
{
    public class CategoryModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Category { get; set; }

        public List<Models.Post> Posts { get; set; }

        public void OnGet()
        {
        }
    }
}
