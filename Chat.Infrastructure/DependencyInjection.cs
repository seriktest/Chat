using Chat.Application.Common.Authentication;
using Chat.Application.Common.Persistence;
using Chat.Application.Common.Services;
using Chat.Application.Services.Authentication;
using Chat.Infrastructure.Authentication;
using Chat.Infrastructure.Persistence;
using Chat.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Chat.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

        services.AddScoped<IUserRepository, UserRepository>();
        
        return services;
    }
}