using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraPostAPI.Data
{
    [Table("Posts")]
    public class Post
    {
        public string Id { get; set; }
        public string Author { get; set; }
        public DateTime DatePosted { get; set; }
        public List<Comment> Comments { get; set; }
        public string UserID { get; set; }
    }
}
