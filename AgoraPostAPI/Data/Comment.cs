using System.ComponentModel.DataAnnotations.Schema;

namespace AgoraPostAPI.Data
{
    [Table("Comments")]
    public class Comment
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public Post Post { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
    }
}