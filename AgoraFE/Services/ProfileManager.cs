using AgoraFE.Areas.Identity.Data;
using AgoraFE.Models;
using Humanizer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Services
{
    public class ProfileManager : IProfileManager
    {
        private readonly AgoraFEContext _agoraFEContext;
        private readonly UserManager<AgoraFEUser> _userManager;
        public ProfileManager(AgoraFEContext agoraFEContext, UserManager<AgoraFEUser> userManager)
        {
            _agoraFEContext = agoraFEContext;
            _userManager = userManager;
        }
        public async void CreateProfile(AgoraFEUser user)
        {
            _agoraFEContext.Entry(user).State = EntityState.Modified;

            try
            {
                await _agoraFEContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

            }
        }

        public async Task<Models.ProfileModel> GetProfileAsync(string userName)
        {
            ProfileModel profile = new();
            var user = await _agoraFEContext.AgoraFEUser.Where(x => x.UserName == userName).FirstOrDefaultAsync();
            if (user != null)
            {
                profile.UserName = user.UserName;
                profile.FirstName = user.FirstName;
                profile.LastName = user.LastName;
                profile.About = user.About;
                profile.DateJoined = user.DateJoined;
                profile.ProfileURL = user.ProfileURL;
            }
            return profile;
        }

        public async Task<string> GetProfilePictureAsync(string userName)
        {
            DateTime.UtcNow.AddDays(0).Humanize();
            var user = await _agoraFEContext.AgoraFEUser.Where(x => x.UserName == userName).FirstOrDefaultAsync();
            var profilePicUrl = user.ProfileURL;
            return profilePicUrl;
        }

    }
}
