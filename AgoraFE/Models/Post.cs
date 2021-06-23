using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Models
{

    public class Post
    {
        public int id { get; set; }
        public string userID { get; set; }
        public string headline { get; set; }
        public string text { get; set; }
        public string author { get; set; }
        public DateTime datePosted { get; set; }
        public Post post { get; set; }
        public List<Comment> comments { get; set; }
        public List<PostLike> postLikes { get; set; }
    }
}
