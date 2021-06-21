using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraPostAPI.Data.Likes
{
    public class ReplyLike
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public Reply Reply { get; set; }
        
        [ForeignKey("Reply")]
        public int ReplyId { get; set; }
    }
}
