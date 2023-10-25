using TeknoLabs.Crm.Application.Features.Client.UCAFFeature.Commands.CreateUCAF;

namespace TeknoLabs.Crm.Application.Services.Client
{
    public interface IUCAFService
    {
        Task CreateUcafAsync(CreateUCAFRequest request);
    }
}
