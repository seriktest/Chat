namespace Chat.Application.Services.Authentication
{
    public class AuthenticationService : IAuthService
    {
        public AuthenticationResult Register(string firstname, string lastName, string email, string password)
        {
            return new AuthenticationResult(
                Guid.NewGuid(),
                firstname,
                lastName,
                email,
                "token");
        }

        public AuthenticationResult Login(string email, string password)
        {
            return new AuthenticationResult(
                Guid.NewGuid(), 
                "firstName",
                "lastName",
                email,
                "token");
        }
    }
}
