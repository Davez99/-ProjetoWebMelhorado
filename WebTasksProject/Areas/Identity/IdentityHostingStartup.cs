using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebTasksProject.Areas.Identity.Data;
using WebTasksProject.Data;

[assembly: HostingStartup(typeof(WebTasksProject.Areas.Identity.IdentityHostingStartup))]
namespace WebTasksProject.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WebTasksProjectContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WebTasksProjectContextConnection")));

                services.AddDefaultIdentity<WebTasksProjectUser>(options => 
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                    .AddEntityFrameworkStores<WebTasksProjectContext>();
            });
        }
    }
}