using TeknoLabs.Crm.Application.Messaging;
using TeknoLabs.Crm.Application.Services.ClientService;

namespace TeknoLabs.Crm.Application.Features.ClientFeature.UCAFFeature.Commands.CreateUCAF
{
    public sealed class CreateUCAFHandler : ICommandHandler<CreateUCAFRequest, CreateUCAFResponse>
    {
        private readonly IUCAFService _ucafService;

        public CreateUCAFHandler(IUCAFService ucafService)
        {
            _ucafService = ucafService;
        }

        public async Task<CreateUCAFResponse> Handle(CreateUCAFRequest request, CancellationToken cancellationToken)
        {
            await _ucafService.CreateUcafAsync(request);
            return new();
        }
    }
}
