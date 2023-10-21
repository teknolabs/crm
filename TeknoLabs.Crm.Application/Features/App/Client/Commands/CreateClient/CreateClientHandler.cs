using System;
using MediatR;
using TeknoLabs.Crm.Application.Services.App;
using TeknoLabs.Crm.Domain.AppEntities;

namespace TeknoLabs.Crm.Application.Features.App.Client.Commands.CreateClient
{
    public sealed class CreateClientHandler : IRequestHandler<CreateClientRequest, CreateClientResponse>
    {
        private readonly IClientService _clientService;

        public CreateClientHandler(IClientService clientService)
        {
            _clientService = clientService;
        }

        public async Task<CreateClientResponse> Handle(CreateClientRequest request, CancellationToken cancellationToken)
        {
            //TeknoLabs.Crm.Domain.AppEntities.Client client = await _clientService.GetClientByName(request.Name);
            await _clientService.CreateClient(request);
            return new();
        }
    }
}

