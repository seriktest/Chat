using Chat.Domain.Entities;

namespace Chat.Application.Common.Persistence;

public interface IUserRepository

{
    void AddUser(User user);
    User? GetUserByEmail(string email);
}