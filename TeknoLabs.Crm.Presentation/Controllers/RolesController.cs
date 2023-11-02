using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TeknoLabs.Crm.Application.Features.App.RoleFeatures.CreateRole;
using TeknoLabs.Crm.Application.Features.App.RoleFeatures.DeleteRole;
using TeknoLabs.Crm.Application.Features.App.RoleFeatures.GetAllRoles;
using TeknoLabs.Crm.Application.Features.App.RoleFeatures.UpdateRole;
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

    [HttpGet("[action]")]
    public async Task<IActionResult> GetRoles()
    {
        GetAllRolesResponse response = await _mediator.Send(new GetAllRolesRequest());
        return Ok(response);
    }

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateRole(UpdateRoleRequest request)
    {
        UpdateRoleResponse response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpDelete("[action]/{id}")]
    public async Task<IActionResult> DeleteRole(string id)
    {
        DeleteRoleRequest request = new DeleteRoleRequest
        {
            Id = id
        };

        DeleteRoleResponse response = await _mediator.Send(request);
        return Ok(response);
    }
}

