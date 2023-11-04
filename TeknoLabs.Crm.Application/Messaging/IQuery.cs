using MediatR;

namespace TeknoLabs.Crm.Application.Messaging
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
