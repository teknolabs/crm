using System;
using AutoMapper;
using TeknoLabs.Crm.Application.Features.App.Client.Commands.CreateClient;
using TeknoLabs.Crm.Application.Services.App;
using TeknoLabs.Crm.Domain.AppEntities;
using TeknoLabs.Crm.Persistance.Context;

namespace TeknoLabs.Crm.Persistance.Services.App
{
	public sealed class ClientService : IClientService
	{
        private readonly AppDbContext _appContext;
        private readonly IMapper _mapper;

        public ClientService(AppDbContext appContext, IMapper mapper)
        {
            _appContext = appContext;
            _mapper = mapper;
        }

        public async Task CreateClient(CreateClientRequest request)
        {
            Client client = _mapper.Map<Client>(request);
            await _appContext.Set<Client>().AddAsync(client);
            await _appContext.SaveChangesAsync();
        }
    }
}

