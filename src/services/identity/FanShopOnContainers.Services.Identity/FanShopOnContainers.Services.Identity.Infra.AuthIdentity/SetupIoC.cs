using FanShopOnContainers.Services.Identity.Application.Users;
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

            services.AddTransient<IUserRepository, UserRepository>();
            return services;
        }
}