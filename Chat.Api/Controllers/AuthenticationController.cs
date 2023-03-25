using Chat.Api.Filters;
using Chat.Application.Services.Authentication;
using Chat.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthService _authenticationResult;

    public AuthenticationController(IAuthService authenticationResult)
    {
        _authenticationResult = authenticationResult;
    }


    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authResult = _authenticationResult.Register(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);
        
        var response = new AuthenticationResponse(
            authResult.User.Id,
            authResult.User.FirstName,
            authResult.User.LastName,
            authResult.User.Email,
            authResult.Token);
        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResult = _authenticationResult.Login(
            request.Email,
            request.Password);
        
        var response = new AuthenticationResponse(
            authResult.User.Id,
            authResult.User.FirstName,
            authResult.User.LastName,
            authResult.User.Email,
            authResult.Token);
        return Ok(response);
    }
}