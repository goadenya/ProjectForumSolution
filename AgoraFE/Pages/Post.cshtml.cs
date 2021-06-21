using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgoraFE.Pages
{
    public class PostModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string PostId { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string Category { get; set; }

        public Models.Post Post { get; set; }

        public void OnGet()
        {
        }
    }
}
