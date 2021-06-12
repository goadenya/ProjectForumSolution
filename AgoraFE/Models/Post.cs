using AgoraFE.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Models
{
    [Table("Posts")]
    public class Post
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public DateTime DatePosted { get; set; }
        
        public List<Comment> Comments { get; set; }
        public AgoraFEUser User { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
    }
}
