using Chat.Domain.Entities;

namespace Chat.Application.Common.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}