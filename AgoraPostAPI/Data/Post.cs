using AgoraPostAPI.Data.Likes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraPostAPI.Data
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string UserID { get; set; }
        public string Headline { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime DatePosted { get; set; }

        public List<PostCategory> PostCategories { get; set; }
        public List<Comment> Comments { get; set; }
        public List<PostLike> PostLikes { get; set; }
    }
}
