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
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime DatePosted { get; set; }
        public string UserID { get; set; }
        [ForeignKey("Category")]
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
