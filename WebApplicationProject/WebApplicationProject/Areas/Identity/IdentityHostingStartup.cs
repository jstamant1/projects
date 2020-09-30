using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationProjectData;

[assembly: HostingStartup(typeof(WebApplicationProjectUI.Areas.Identity.IdentityHostingStartup))]
namespace WebApplicationProjectUI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WebApplicationProjectContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WebApplicationProjectContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<WebApplicationProjectContext>();
            });
        }
    }
}