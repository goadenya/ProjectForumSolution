using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraPostAPI.Data.Likes
{
    public class CommentLike
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public Comment Comment { get; set; }
        
        [ForeignKey("Comment")]
        public int CommentId { get; set; }
    }
}
