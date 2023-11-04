using TeknoLabs.Crm.Application.Messaging;

namespace TeknoLabs.Crm.Application.Features.App.ClientFeature.Commands.MigrateClientDatabase;

public sealed record MigrateClientDatabaseRequest() : ICommand<MigrateClientDatabaseResponse>;
