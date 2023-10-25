using MediatR;

namespace TeknoLabs.Crm.Application.Features.Client.UCAFFeature.Commands.CreateUCAF
{
    public sealed class CreateUCAFHandler : IRequestHandler<CreateUCAFRequest, CreateUCAFResponse>
    {
        public async Task<CreateUCAFResponse> Handle(CreateUCAFRequest request, CancellationToken cancellationToken)
        {
            return new();
        }
    }
}
