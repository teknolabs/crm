namespace TeknoLabs.Crm.Application.Features.App.AppUserFeatures.Login;

public sealed record LoginResponse(
    string Token,
    string Email,
    string UserId,
    string NameLastName);

