using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AgoraFE.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AgoraFEUser class
    public class AgoraFEUser : IdentityUser
    {
        public string About { get; set; }
        public DateTime DateJoined { get; set; }
        public string ProfileURL { get; set; }
    }
}
