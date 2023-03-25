using Chat.Application.Common.Authentication;
using Chat.Application.Common.Persistence;
using Chat.Domain.Entities;

namespace Chat.Application.Services.Authentication
{
    public class AuthenticationService : IAuthService
    {
        private readonly IJwtTokenGenerator _tokenGenerator;
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IJwtTokenGenerator tokenGenerator, IUserRepository userRepository)
        {
            _tokenGenerator = tokenGenerator;
            _userRepository = userRepository;
        }

        public AuthenticationResult Register(string firstname, string lastName, string email, string password)
        {
            if (_userRepository.GetUserByEmail(email) is not null)
            {
                throw new Exception("User exist.");
            }

            var user = new User()
            {
                FirstName = firstname,
                LastName = lastName,
                Email = email,
                Password = password
            };
            
            _userRepository.AddUser(user);
            
            var token = _tokenGenerator.GenerateToken(user);
            
            return new AuthenticationResult(
                user,
                token);
        }

        public AuthenticationResult Login(string email, string password)
        {
            if (_userRepository.GetUserByEmail(email) is not { } user)
            {
                throw new Exception("User not exist.");
            }

            if (user.Password != password)
            {
                throw new Exception("Invalid password.");
            }

            var token = _tokenGenerator.GenerateToken(user);
            
            return new AuthenticationResult(
                user,
                token);
        }
    }
}
