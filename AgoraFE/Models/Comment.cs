using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgoraFE.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public DateTime DatePosted { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public List<Reply> Replies { get; set; }
    }
}