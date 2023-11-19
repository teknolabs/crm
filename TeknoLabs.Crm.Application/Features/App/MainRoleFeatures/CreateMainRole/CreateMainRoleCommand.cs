using System;
using TeknoLabs.Crm.Application.Messaging;

namespace TeknoLabs.Crm.Application.Features.App.MainRoleFeatures.CreateMainRole;

public sealed record CreateMainRoleCommand (
	string Title,
	string ClientId) : ICommand<CreateMainRoleResponse>;
