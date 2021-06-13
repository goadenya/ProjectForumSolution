using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgoraPostAPI.Data
{
    [Table("Comments")]
    public class Comment
    {
        public string Id { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public DateTime DatePosted { get; set; }
        public Post Post { get; set; }
        [ForeignKey("Post")]
        public string PostId { get; set; }
        public List<Reply> Replies { get; set; }
    }
}