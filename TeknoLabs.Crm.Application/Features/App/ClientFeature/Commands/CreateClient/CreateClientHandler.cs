using System;
using MediatR;
using TeknoLabs.Crm.Application.Services.App;
using TeknoLabs.Crm.Domain.AppEntities;

namespace TeknoLabs.Crm.Application.Features.App.ClientFeature.Commands.CreateClient
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
            Client client = await _clientService.GetClientByName(request.Name);
            if (client != null) throw new Exception("Bu şirket adı daha önce kullanılmış!");
            await _clientService.CreateClient(request);
            return new();
        }
    }
}

