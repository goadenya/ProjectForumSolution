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

        public DbSet<AgoraPostAPI.Data.Post> Post { get; set; }
        public DbSet<AgoraPostAPI.Data.Category> Category { get; set; }
        public DbSet<AgoraPostAPI.Data.PostCategory> PostCategory { get; set; }
        public DbSet<AgoraPostAPI.Data.Comment> Comment { get; set; }
        public DbSet<AgoraPostAPI.Data.Reply> Reply { get; set; }
    }
}
