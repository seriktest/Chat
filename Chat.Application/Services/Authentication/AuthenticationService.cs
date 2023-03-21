namespace Chat.Application.Services.Authentication
{
    public class AuthenticationService : IAuthService
    {
        public AuthenticationResult Register(string firstname, string lastName, string email, string password)
        {
            return new AuthenticationResult(
                new Guid(),
                firstname,
                lastName,
                email,
                "token");
        }

        public AuthenticationResult Login(string email, string password)
        {
            return new AuthenticationResult(
                new Guid(),
                "firstName",
                "lastName",
                email,
                "token");
        }
    }
}
