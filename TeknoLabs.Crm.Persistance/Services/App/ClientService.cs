using System;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TeknoLabs.Crm.Application.Features.App.ClientFeature.Commands.CreateClient;
using TeknoLabs.Crm.Application.Services.App;
using TeknoLabs.Crm.Domain.AppEntities;
using TeknoLabs.Crm.Persistance.Context;

namespace TeknoLabs.Crm.Persistance.Services.App
{
    public sealed class ClientService : IClientService
    {
        private static readonly Func<AppDbContext, string, Task<Client?>>
            GetClientByNameCompiled =
            EF.CompileAsyncQuery((AppDbContext context, string name) =>
            context.Set<Client>().FirstOrDefault(x => x.Name == name)
            );

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
            client.Id = Guid.NewGuid().ToString();
            await _appContext.Set<Client>().AddAsync(client);
            await _appContext.SaveChangesAsync();
        }

        public async Task<Client?> GetClientByName(string name)
        {
            return await GetClientByNameCompiled(_appContext, name);
        }

        public async Task MigrateClientDatabases()
        {
            var clients = await _appContext.Set<Client>().ToListAsync();
            foreach (var client in clients)
            {
                var db = new ClientDbContext(client);
                db.Database.Migrate();
            }
        }
    }
}

