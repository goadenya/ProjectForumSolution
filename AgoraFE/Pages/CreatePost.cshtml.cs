using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgoraFE.Models;
using AgoraFE.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgoraFE.Pages
{
    public class CreatePostModel : PageModel
    {
        [BindProperty]
        public Models.Post Post { get; set; }

        [BindProperty]
        public int CategoryId { get; set; }

        public List<Models.Category> Categories { get; set; }
        public Models.Category SelectedCategory { get; set; }

        private readonly CategoryManager _categoryManager;
        private readonly PostManager _postManager;
        public CreatePostModel(CategoryManager categoryManager, PostManager postManager)
        {
            _categoryManager = categoryManager;
            _postManager = postManager;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Categories = await _categoryManager.GetAllCategories();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Post.categoryId = CategoryId;
            await _postManager.AddPost(Post);
            //SelectedCategory = Categories.Where(x => x.id == Post.categoryId).FirstOrDefault();
            //return RedirectToPage("Post", new { Category = SelectedCategory.name, PostId = Post.id });
            return RedirectToPage("/Index");
        }
    }
}
