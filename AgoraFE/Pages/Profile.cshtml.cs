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
    public class ProfileModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }

        public Models.ProfileModel Profile { get; set; }

        private readonly ProfileManager _profileManager;
        public ProfileModel(ProfileManager profileManager)
        {
            _profileManager = profileManager;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            if (Name == null)
            {
                return RedirectToPage("/Error", new { code = 404 });
            }
            Profile = await _profileManager.GetProfileAsync(Name);
            return Page();
        }
    }
}
