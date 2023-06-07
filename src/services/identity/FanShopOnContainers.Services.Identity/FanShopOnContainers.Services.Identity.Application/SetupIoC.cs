using Microsoft.Extensions.DependencyInjection;

namespace FanShopOnContainers.Services.Identity.Application;

public static class SetupIoC
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssemblyContaining<ApplicationAssemblyReference>();
        });
        
        return services;
    }
}

internal abstract class ApplicationAssemblyReference {}