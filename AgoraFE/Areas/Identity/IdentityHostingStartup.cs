using System;
using AgoraFE.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AgoraFE.Areas.Identity.IdentityHostingStartup))]
namespace AgoraFE.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AgoraFEContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AgoraFEContextConnection")));

                services.AddDefaultIdentity<AgoraFEUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<AgoraFEContext>();
            });
        } 
    }
}