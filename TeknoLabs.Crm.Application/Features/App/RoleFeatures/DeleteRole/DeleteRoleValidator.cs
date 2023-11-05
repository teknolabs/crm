using FluentValidation;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.DeleteRole;

public sealed class DeleteRoleValidator : AbstractValidator<DeleteRoleRequest>
{
    public DeleteRoleValidator()
    {
        RuleFor(k => k.Id).NotEmpty().NotNull().WithMessage("Id bilgisi boş olamaz");
    }
}
