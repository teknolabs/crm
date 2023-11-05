using FluentValidation;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.CreateRole;

public sealed class CreateRoleValidator : AbstractValidator<CreateRoleRequest>
{
    public CreateRoleValidator()
    {
        RuleFor(k => k.Code).NotNull().NotEmpty().WithMessage("Role Kodu boş olamaz");
        RuleFor(k => k.Name).NotNull().NotEmpty().WithMessage("Role Adı boş olamaz");
    }
}
