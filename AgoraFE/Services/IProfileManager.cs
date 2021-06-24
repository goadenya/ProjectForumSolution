using AgoraFE.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Services
{
    interface IProfileManager
    {
        void CreateProfile(AgoraFEUser user);
        Task<Models.ProfileModel> GetProfileAsync(string userName);
        Task<string> GetProfilePictureAsync(string userName);
    }
}
