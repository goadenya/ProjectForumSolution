using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgoraFE.Models;
using AgoraFE.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgoraFE.Pages.Admin.Manage.Categories
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
