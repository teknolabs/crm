using TeknoLabs.Crm.Application.Messaging;

namespace TeknoLabs.Crm.Application.Features.ClientFeature.UCAFFeature.Commands.CreateUCAF;

public sealed record CreateUCAFRequest(
    string Code,
    string Name,
    char Type,
    string ClientId) : ICommand<CreateUCAFResponse>;