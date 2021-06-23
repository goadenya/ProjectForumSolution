using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgoraFE.Services;
using AgoraFE.Services.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgoraFE.Pages
{
    public class CategoryModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Category { get; set; }

        public List<Models.Post> Posts { get; set; }

        private readonly CategoryManager _categoryManager;

        public Tools _tools;
        public CategoryModel(CategoryManager categoryManager, Tools tools)
        {
            _categoryManager = categoryManager;
            _tools = tools;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            if (Category != null)
            {
                var category = await _categoryManager.GetCategoryByName(Category);

                Posts = category.posts;

                if (Posts == null)
                {
                    return NotFound();
                }
            }
            return Page();
        }
    }
}
