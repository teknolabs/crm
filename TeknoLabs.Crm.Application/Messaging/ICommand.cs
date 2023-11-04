using MediatR;

namespace TeknoLabs.Crm.Application.Messaging;

public interface ICommand<out TResponse> : IRequest<TResponse>
{
}
