﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Application.Services.Authentication
{
    public interface IAuthService
    {
        AuthenticationResult Register(string firstname, string lastName,
            string email, string password);
        AuthenticationResult Login(string email, string password);
    }
}
