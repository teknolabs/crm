using System;
using MediatR;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.CreateRole;

public sealed class CreateRoleRequest : IRequest<CreateRoleResponse>
{
    public string Name { get; set; }
    public string Code { get; set; }
}

