using System;
using System.Collections.Generic;

namespace AgoraFE.Models
{
    public class Comment
    {
        public int id { get; set; }
        public string userId { get; set; }
        public string author { get; set; }
        public string text { get; set; }
        public DateTime datePosted { get; set; }
        public int postId { get; set; }
        public string profilePicUrl { get; set; }
        public List<Reply> replies { get; set; }
        public List<CommentLike> commentLikes { get; set; }
    }
}
