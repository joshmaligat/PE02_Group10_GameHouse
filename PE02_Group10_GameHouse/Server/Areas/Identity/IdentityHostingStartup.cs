using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PE02_Group10_GameHouse.Server.Data;
using PE02_Group10_GameHouse.Server.Models;

[assembly: HostingStartup(typeof(PE02_Group10_GameHouse.Server.Areas.Identity.IdentityHostingStartup))]
namespace PE02_Group10_GameHouse.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}