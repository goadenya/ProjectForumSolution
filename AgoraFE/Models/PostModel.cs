using AgoraFE.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public DateTime DatePosted { get; set; }
        public AgoraFEUser User { get; set; }
        public int UserID { get; set; }
        public List<CommentModel> Comments { get; set; }
    }
}
