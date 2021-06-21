using AgoraFE.Models;
using AgoraFE.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CategoryManager _categoryManager;
        public IndexModel(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public List<Category> Categories { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Categories = await _categoryManager.GetAllCategories();
            return Page();
        }
    }
}
