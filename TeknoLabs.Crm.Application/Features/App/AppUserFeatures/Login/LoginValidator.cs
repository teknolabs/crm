using FluentValidation;

namespace TeknoLabs.Crm.Application.Features.App.AppUserFeatures.Login;

public sealed class LoginValidator : AbstractValidator<LoginCommand>
{
    public LoginValidator()
    {
        RuleFor(x => x.EmailOrUserName).NotEmpty().WithMessage("Mail yada Kullanıcı adı girmelisiniz.");
        RuleFor(x => x.EmailOrUserName).NotNull().WithMessage("Mail yada Kullanıcı adı girmelisiniz.");
        RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre bilgisi boş olamaz..");
        RuleFor(x => x.Password).NotNull().WithMessage("Şifre bilgisi boş olamaz..");
        RuleFor(x => x.Password).MinimumLength(6).WithMessage("Şifre en az 6 karakter olmalıdır");
        RuleFor(x => x.Password).Matches("[A-Z]").WithMessage("Şifreniz en az 1 büyük harf içermelidir");
        RuleFor(x => x.Password).Matches("[a-z]").WithMessage("Şifreniz en az 1 küçük harf içermelidir");
        RuleFor(x => x.Password).Matches("[0-9]").WithMessage("Şifreniz en az 1 rakam içermelidir");
        RuleFor(x => x.Password).Matches("[^a-zA-Z0-9]").WithMessage("Şifreniz en az 1 özel karakter içermelidir");
    }
}
