using FluentValidation;

namespace TeknoLabs.Crm.Application.Features.App.RoleFeatures.UpdateRole;

public sealed class UpdateRoleValidator : AbstractValidator<UpdateRoleRequest>
{
    public UpdateRoleValidator()
    {
        RuleFor(k => k.Code).NotNull().NotEmpty().WithMessage("Role Kodu boş olamaz");
        RuleFor(k => k.Name).NotNull().NotEmpty().WithMessage("Role Adı boş olamaz");
        RuleFor(k => k.Id).NotEmpty().NotNull().WithMessage("Id bilgisi boş olamaz");
    }
}
