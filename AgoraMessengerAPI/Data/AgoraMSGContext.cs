using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AgoraMessengerAPI.Data
{
    public class AgoraMSGContext : DbContext
    {
        public AgoraMSGContext (DbContextOptions<AgoraMSGContext> options)
            : base(options)
        {
        }

        public DbSet<AgoraMessengerAPI.Data.Message> Message { get; set; }
    }
}
