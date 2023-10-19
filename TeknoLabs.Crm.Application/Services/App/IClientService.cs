using System;
using TeknoLabs.Crm.Application.Features.App.Client.Commands.CreateClient;

namespace TeknoLabs.Crm.Application.Services.App
{
	public interface IClientService
	{
		Task CreateClient(CreateClientRequest request);
	}
}

