using Chat.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request) => Ok(request);

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request) => Ok(request);
}