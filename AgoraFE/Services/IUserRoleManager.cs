using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Services
{
    interface IUserRoleManager
    {
        bool UserIsRole(string UserName, string role);
    }
}
