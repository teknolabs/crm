using MediatR;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.DeleteRole
{
    public sealed class DeleteRoleRequest : IRequest<DeleteRoleResponse>
    {
        public string Id { get; set; } 
    }
}
