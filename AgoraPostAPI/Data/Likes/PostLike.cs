using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraPostAPI.Data.Likes
{
    public class PostLike
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public Post Post { get; set; }
        
        [ForeignKey("Post")]
        public int PostId  { get; set; }
    }
}
