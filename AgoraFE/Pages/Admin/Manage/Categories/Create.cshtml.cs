using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using AgoraFE.Areas.Identity.Data;
using AgoraFE.Models;
using AgoraFE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgoraFE.Pages.Admin.Manage.Categories
{
    public class CreateModel : PageModel
    {
        private readonly HttpClient _client;
        private readonly UserRoleManager _userRoleManager;
        public CreateModel(HttpClient client, UserRoleManager userRoleManager)
        {
            _client = client;
            _userRoleManager = userRoleManager;
        }
        public IActionResult OnGet()
        {
            if (_userRoleManager.UserIsRole(User.Identity.Name, "Admin"))
            {
                return Page();
            }
            else
            {
                return RedirectToPage("/Admin/Info");
            }
        }

        [BindProperty]
        public Models.Category category { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _client.BaseAddress = new Uri("https://localhost:44337/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            

            var url = await CreateCategoryAsync(category);

            return RedirectToPage("./Index");
        }

        public async Task<Uri> CreateCategoryAsync(Models.Category category)
        {
            HttpResponseMessage response = await _client.PostAsJsonAsync(
                "api/Categories", category);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }
    }
}
