using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AgoraPostAPI.Data
{
    public class AgoraPostContext : DbContext
    {
        public AgoraPostContext (DbContextOptions<AgoraPostContext> options)
            : base(options)
        {
        }

        public DbSet<Data.Post> Post { get; set; }
        public DbSet<Data.Category> Category { get; set; }
        public DbSet<Data.Comment> Comment { get; set; }
        public DbSet<Data.Reply> Reply { get; set; }
        public DbSet<Data.Likes.PostLike> PostLike { get; set; }
        public DbSet<Data.Likes.CommentLike> CommentLike { get; set; }
        public DbSet<Data.Likes.ReplyLike> ReplyLike { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Data.Category>()
                .HasIndex(b => b.Name)
                .IsUnique();
        }
    }
}
