using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TeknoLabs.Crm.Application.Abstractions;
using TeknoLabs.Crm.Domain.AppEntities.Identity;

namespace TeknoLabs.Crm.Application.Features.App.AppUserFeatures.Login;

public class LoginHandler : IRequestHandler<LoginRequest, LoginResponse>
{
    private readonly IJwtProvider _jwtProvider;
    private readonly UserManager<AppUser> _userManager;

    public LoginHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager)
    {
        _jwtProvider = jwtProvider;
        _userManager = userManager;
    }

    public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
    {
        AppUser user = await _userManager.Users.Where(k =>
        k.Email == request.EmailOrUserName ||
        k.UserName == request.EmailOrUserName).FirstOrDefaultAsync();

        if (user == null) throw new Exception("Kullanıcı Bulunamadı");

        var checkUser = await _userManager.CheckPasswordAsync(user, request.Password);
        if (!checkUser) throw new Exception("Şifreniz Yanlış");

        List<string> roles = new();

        LoginResponse response = new()
        {
            Email = user.Email,
            NameLastName = user.NameLastName,
            UserId = user.Id,
            Token = await _jwtProvider.CreateTokenAsync(user, roles)
        };

        return response;
    }
}

