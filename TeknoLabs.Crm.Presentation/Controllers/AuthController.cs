using MediatR;
using Microsoft.AspNetCore.Mvc;
using TeknoLabs.Crm.Application.Features.App.AppUserFeatures.Login;
using TeknoLabs.Crm.Presentation.Abstraction;

namespace TeknoLabs.Crm.Presentation.Controllers;

public class AuthController : ApiController
{
    public AuthController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Login(LoginCommand request)
    {
        LoginResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}

