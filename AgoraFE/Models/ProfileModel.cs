using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Models
{
    public class ProfileModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public DateTime DateJoined { get; set; }
        public string ProfileURL { get; set; }
    }
}
