using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraPostAPI.Data
{
    public class PostCategory
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("Post")]
        public string PostId { get; set; }
        public Post Post { get; set; }
        
        [ForeignKey("Category")]
        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
