using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TeknoLabs.Crm.Domain.AppEntities.Identity;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.CreateRole
{
    public sealed class CreateRoleHandler : IRequestHandler<CreateRoleRequest, CreateRoleResponse>
    {
        private readonly RoleManager<AppRole> _roleManager;

        public CreateRoleHandler(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<CreateRoleResponse> Handle(CreateRoleRequest request, CancellationToken cancellationToken)
        {
            AppRole role = await _roleManager.Roles.FirstOrDefaultAsync(k => k.Code == request.Code);
            if (role != null) throw new Exception("Bu rol daha önce tanımlanmış");

            role = new AppRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = request.Name,
                Code = request.Code
            };

            await _roleManager.CreateAsync(role);
            return new();
        }
    }
}

