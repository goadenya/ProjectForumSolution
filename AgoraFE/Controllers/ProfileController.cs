using AgoraFE.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AgoraFE.Controllers
{
    public class ProfileController : Controller
    {
        private readonly AgoraFEContext _context;
        private readonly SignInManager<AgoraFEUser> _signInManager;
        private readonly UserManager<AgoraFEUser> _userManager;
        public ProfileController(AgoraFEContext context, SignInManager<AgoraFEUser> signInManager, UserManager<AgoraFEUser> userManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        
        public IActionResult Index()
        {
            var user = _userManager.FindByNameAsync(User.Claims.FirstOrDefault(x => x.Type.Equals(ClaimTypes.Name)).Value);
            return View(user);
        }
    }
}
