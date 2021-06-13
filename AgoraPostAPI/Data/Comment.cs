using System.ComponentModel.DataAnnotations.Schema;

namespace AgoraPostAPI.Data
{
    [Table("Comments")]
    public class Comment
    {
        public string Id { get; set; }
        public string Author { get; set; }
        public Post Post { get; set; }
        [ForeignKey("Post")]
        public string PostId { get; set; }
    }
}