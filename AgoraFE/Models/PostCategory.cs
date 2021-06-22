namespace AgoraFE.Models
{
    public class PostCategory
    {
        public int id { get; set; }
        public int postId { get; set; }
        public Post post { get; set; }
        public int categoryId { get; set; }
        public Category Category { get; set; }
    }
}
