using AgoraFE.Areas.Identity.Data;
using AgoraFE.Services;
using AgoraFE.Services.Tools;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AgoraFE
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            

            services.AddRazorPages(options =>
            {
                // options.Conventions.AuthorizePage("/Privacy", "MustBeUser");
                options.Conventions.AuthorizeFolder("/Admin");
                options.Conventions.AllowAnonymousToPage("/Admin/Info");
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential 
                // cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                // requires using Microsoft.AspNetCore.Http;
                options.MinimumSameSitePolicy = SameSiteMode.None;
                options.ConsentCookie.Name = "AgoraForumConsentCookie";
                options.ConsentCookie.Expiration = TimeSpan.FromMinutes(20);
            });

            services.AddHttpContextAccessor();

            services.AddTransient<HttpClient>();

            services.AddTransient<Services.UserRoleManager>();

            services.AddTransient<Services.CategoryManager>();

            services.AddTransient<Services.PostManager>();

            services.AddTransient<Services.CommentManager>();

            services.AddTransient<Services.ReplyManager>();

            services.AddTransient<Services.ProfileManager>();

            services.AddTransient<Services.Tools.Tools>();

            services.AddTransient<Services.Tools.FileManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            var supportedCultures = new[]
            {
               new CultureInfo("en-US"),

            };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-US"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            app.UseHttpsRedirection();
            
            app.UseStaticFiles();

            app.UseRouting();

            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
