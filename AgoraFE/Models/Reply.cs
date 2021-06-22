using System;
using System.Collections.Generic;

namespace AgoraFE.Models
{
    public class Reply
    {
        public int id { get; set; }
        public string userId { get; set; }
        public string text { get; set; }
        public string author { get; set; }
        public DateTime datePosted { get; set; }
        public int commentId { get; set; }
        public List<ReplyLike> replyLikes { get; set; }
    }
}
