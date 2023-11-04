using TeknoLabs.Crm.Application.Messaging;
using TeknoLabs.Crm.Application.Services.App;

namespace TeknoLabs.Crm.Application.Features.App.ClientFeature.Commands.MigrateClientDatabase;

internal class MigrateClientDatabaseHandler : ICommandHandler<MigrateClientDatabaseRequest, MigrateClientDatabaseResponse>
{
    private readonly IClientService _clientService;

    public MigrateClientDatabaseHandler(IClientService clientService)
    {
        _clientService = clientService;
    }

    public async Task<MigrateClientDatabaseResponse> Handle(MigrateClientDatabaseRequest request, CancellationToken cancellationToken)
    {
        await _clientService.MigrateClientDatabases();
        return new();
    }
}
