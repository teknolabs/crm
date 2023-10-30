using System;
using MediatR;

namespace TeknoLabs.Crm.Application.Features.App.AppUserFeatures.Login;

public sealed class LoginRequest : IRequest<LoginResponse>
{
    public string EmailOrUserName { get; set; } 
    public string Password { get; set; } 
}

