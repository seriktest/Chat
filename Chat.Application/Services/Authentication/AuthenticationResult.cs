using Chat.Domain.Entities;

namespace Chat.Application.Services.Authentication
{
    public record AuthenticationResult(
        User User,
        string Token);
}
