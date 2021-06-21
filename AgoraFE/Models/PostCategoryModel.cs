using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Models
{
    public class PostCategoryModel
    {
        public string Id { get; set; }

        public string PostId { get; set; }
        public Post Post { get; set; }
        
        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
