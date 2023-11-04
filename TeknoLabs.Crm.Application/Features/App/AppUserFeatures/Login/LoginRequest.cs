using TeknoLabs.Crm.Application.Messaging;

namespace TeknoLabs.Crm.Application.Features.App.AppUserFeatures.Login;

public sealed record LoginCommand(string EmailOrUserName, string Password):ICommand<LoginResponse>;
    
 