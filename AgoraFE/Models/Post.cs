using AgoraFE.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string Headline { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime DatePosted { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
