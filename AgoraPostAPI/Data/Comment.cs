using AgoraPostAPI.Data.Likes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgoraPostAPI.Data
{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Author { get; set; }
        public string ProfilePicUrl { get; set; }
        public string Text { get; set; }
        public DateTime DatePosted { get; set; }
        public Post Post { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public List<Reply> Replies { get; set; }
        public List<CommentLike> CommentLikes { get; set; }
    }
}