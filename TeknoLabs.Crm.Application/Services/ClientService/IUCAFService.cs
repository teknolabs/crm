using TeknoLabs.Crm.Application.Features.ClientFeature.UCAFFeature.Commands.CreateUCAF;

namespace TeknoLabs.Crm.Application.Services.ClientService
{
    public interface IUCAFService
    {
        Task CreateUcafAsync(CreateUCAFRequest request);
    }
}
