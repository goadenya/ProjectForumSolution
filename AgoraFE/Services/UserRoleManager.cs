using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using AgoraFE.Areas.Identity.Data;
using AgoraFE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace AgoraFE.Services
{
    public class UserRoleManager : IUserRoleManager
    {
        private readonly UserManager<AgoraFEUser> _userManager;

        public UserRoleManager(UserManager<AgoraFEUser> userManager)
        {
            _userManager = userManager;
        }
        public bool UserIsRole(string userName, string role)
        {
            var user = _userManager.FindByNameAsync(userName).Result;
            return _userManager.IsInRoleAsync(user, role).Result;
        }
    }
}
