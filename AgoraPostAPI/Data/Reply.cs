using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraPostAPI.Data
{
    [Table("Replies")]
    public class Reply
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public string UserId { get; set; }
        public DateTime DatePosted { get; set; }

        [ForeignKey("Comment")]
        public string CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
