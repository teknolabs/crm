using FluentValidation;

namespace TeknoLabs.Crm.Application.Features.App.ClientFeature.Commands.CreateClient;

public sealed class CreateClientValidator : AbstractValidator<CreateClientRequest>
{
    public CreateClientValidator()
    {
        RuleFor(k => k.DatabaseName).NotEmpty().WithMessage("Database bilgisi yazılmalıdır");
        RuleFor(k => k.DatabaseName).NotNull().WithMessage("Database bilgisi yazılmalıdır");
        RuleFor(k => k.ServerName).NotEmpty().WithMessage("Server bilgisi yazılmalıdır");
        RuleFor(k => k.ServerName).NotNull().WithMessage("Server bilgisi yazılmalıdır");
        RuleFor(k => k.Name).NotEmpty().WithMessage("Şirket adı yazılmalıdır");
        RuleFor(k => k.Name).NotNull().WithMessage("Şirket adı yazılmalıdır");
    }
}
