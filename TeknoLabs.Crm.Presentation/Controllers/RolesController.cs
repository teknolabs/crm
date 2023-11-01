using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TeknoLabs.Crm.Application.Features.App.RoleFeatures.CreateRole;
using TeknoLabs.Crm.Presentation.Abstraction;

namespace TeknoLabs.Crm.Presentation.Controllers;

public class RolesController : ApiController
{
    public RolesController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateRole(CreateRoleRequest request)
    {
        CreateRoleResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}

