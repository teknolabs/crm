using System;
using TeknoLabs.Crm.Application.Features.App.Client.Commands.CreateClient;
using TeknoLabs.Crm.Domain.AppEntities;

namespace TeknoLabs.Crm.Application.Services.App
{
	public interface IClientService
	{
		Task CreateClient(CreateClientRequest request);
        Task<Client> GetClientByName(string name);
    }
}

