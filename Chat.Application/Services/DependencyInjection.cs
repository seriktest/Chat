using Chat.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Chat.Application.Services;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthenticationService>();
        return services;
    }
}