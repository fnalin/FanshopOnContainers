using FanShopOnContainers.Services.Identity.Infra.AuthIdentity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FanShopOnContainers.Services.Identity.Infra.AuthIdentity;

public static class SetupIoC
{
        public static IServiceCollection AddInfraAuthIdentity(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<IdentityDataContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("IdentityConn"));
            });
            
            
            return services;
        }
}