using MediatR;

namespace TeknoLabs.Crm.Application.Features.App.Client.Commands.CreateClient
{
    public sealed class CreateClientRequest : IRequest<CreateClientResponse>
	{
        public string Name { get; set; }

        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}

