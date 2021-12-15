using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rocket_Elevators_Customer_Portal.Areas.Identity.Data;

[assembly: HostingStartup(typeof(Rocket_Elevators_Customer_Portal.Areas.Identity.IdentityHostingStartup))]
namespace Rocket_Elevators_Customer_Portal.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            var connectionString = "server=localhost;user=lemath;password=kintaro1;database=CustomerApp";
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Rocket_Elevators_Customer_PortalIdentityDbContext>(options =>
                    options.UseMySql(connectionString, serverVersion));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Rocket_Elevators_Customer_PortalIdentityDbContext>();
            });
        }
    }
}