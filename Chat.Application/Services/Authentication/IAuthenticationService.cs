using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Application.Services.Authentication
{
    internal interface IAuthenticationService
    {
        AuthenticationResult Login(string firstname, string lastName,
            string email, string password);
        AuthenticationResult Register(string email, string password);
    }
}
