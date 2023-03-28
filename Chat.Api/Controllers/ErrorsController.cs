using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Api.Controllers;

public class ErrorsController : ControllerBase
{
    
    [Route("/error")]
    public IActionResult Error()
    {
        var exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        return Problem();
    }
}