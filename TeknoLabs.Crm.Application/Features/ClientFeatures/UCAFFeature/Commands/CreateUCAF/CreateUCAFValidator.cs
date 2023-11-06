using FluentValidation;

namespace TeknoLabs.Crm.Application.Features.ClientFeature.UCAFFeature.Commands.CreateUCAF;

public sealed class CreateUCAFValidator : AbstractValidator<CreateUCAFRequest>
{
    public CreateUCAFValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().WithMessage("Hesap planı kodu boş olamaz!"); 
        RuleFor(p => p.Code).MinimumLength(5).WithMessage("Hesap planı kodu en az 5 karakter olmalıdır!");
        RuleFor(p => p.Name).NotEmpty().NotNull().WithMessage("Hesap planı adı boş olamaz!"); 
        RuleFor(p => p.ClientId).NotEmpty().NotNull().WithMessage("Şirket bilgisi adı boş olamaz!"); 
        RuleFor(p => p.Type).NotNull().NotEmpty().WithMessage("Hesap planı tipi boş olamaz!");  
    }
}
