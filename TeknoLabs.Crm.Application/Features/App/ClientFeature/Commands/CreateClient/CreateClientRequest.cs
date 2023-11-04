using TeknoLabs.Crm.Application.Messaging;

namespace TeknoLabs.Crm.Application.Features.App.ClientFeature.Commands.CreateClient;

public sealed record CreateClientRequest(
    string Name,
    string ServerName,
    string DatabaseName,
    string UserId,
    string Password
    )
    : ICommand<CreateClientResponse>;

