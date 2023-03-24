using Chat.Application.Common.Authentication;

namespace Chat.Application.Services.Authentication
{
    public class AuthenticationService : IAuthService
    {
        private readonly IJwtTokenGenerator _tokenGenerator;

        public AuthenticationService(IJwtTokenGenerator tokenGenerator)
        {
            _tokenGenerator = tokenGenerator;
        }

        public AuthenticationResult Register(string firstname, string lastName, string email, string password)
        {
            var userId = Guid.NewGuid();
            var token = _tokenGenerator.GenerateToken(userId, firstname, lastName);
            
            return new AuthenticationResult(
                userId,
                firstname,
                lastName,
                email,
                token);
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
