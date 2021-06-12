using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgoraFE.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgoraFE.Areas.Identity.Data
{
    public class AgoraFEContext : IdentityDbContext<AgoraFEUser>
    {
        public AgoraFEContext(DbContextOptions<AgoraFEContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            const string adminId = "admin-c0-aa65-4af8-bd17-00bd9344e575";
            const string userRoleId = "user-2c0-aa65-4af8-bd17-00bd9344e575";
            const string roleId = "root-0c0-aa65-4af8-bd17-00bd9344e575";

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = roleId,
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = userRoleId,
                Name = "User",
                NormalizedName = "USER"
            });

            var hasher = new PasswordHasher<IdentityUser>();

            builder.Entity<AgoraFEUser>().HasData(new AgoraFEUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@core.api",
                NormalizedEmail = "ADMIN@CORE.API",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "AdminPass1!"),
                SecurityStamp = Guid.NewGuid().ToString(),
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = adminId,
                RoleId = roleId
            });
        }
    }
}
