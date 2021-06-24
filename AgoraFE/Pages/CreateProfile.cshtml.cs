using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AgoraFE.Areas.Identity.Data;
using AgoraFE.Services;
using AgoraFE.Services.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AgoraFE.Pages
{
    public class CreateProfileModel : PageModel
    {
        [Required(ErrorMessage = "Please enter first name")]
        [Display(Name = "First Name")]
        [BindProperty]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name")]
        [Display(Name = "Last Name")]
        [BindProperty]
        public string LastName { get; set; }

        [Display(Name = "About")]
        [BindProperty]
        public string About { get; set; }

        [Required(ErrorMessage = "Please choose profile image")]
        [Display(Name = "Profile Picture")]
        [BindProperty]
        public IFormFile ProfileImage { get; set; }


        private readonly UserManager<AgoraFEUser> _userManager;
        private readonly SignInManager<AgoraFEUser> _signInManager;
        private readonly AgoraFEContext _agoraFEContext;
        private readonly FileManager _fileManager;
        private readonly ProfileManager _profileManager;

        public CreateProfileModel(
            UserManager<AgoraFEUser> userManager,
            SignInManager<AgoraFEUser> signInManager,
            AgoraFEContext agoraFEContext,
            FileManager fileManager,
            ProfileManager profileManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _agoraFEContext = agoraFEContext;
            _fileManager = fileManager;
            _profileManager = profileManager;
        }

        public IActionResult OnGet()
        {
            if(!_signInManager.IsSignedIn(User))
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return NotFound();
                }

                user.FirstName = FirstName;
                user.LastName = LastName;
                user.About = About;
                user.ProfileURL = _fileManager.UploadFile(ProfileImage);

                _profileManager.CreateProfile(user);

                return RedirectToPage("Profile", new { name = user.UserName });
            }
            return Page();
        }
    }
}
