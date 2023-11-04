using FluentValidation;
using FluentValidation.Results;
using MediatR;
using TeknoLabs.Crm.Application.Messaging;

namespace TeknoLabs.Crm.Application.Behavior;

public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : class, ICommand<TResponse>
{
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (!_validators.Any())
        {
            return await next();
        }

        var context = new ValidationContext<TRequest>(request);

        var errorDictionary = _validators
            .Select(k => k.Validate(context))
            .SelectMany(k => k.Errors)
            .Where(k => k != null)
            .GroupBy(
            k => k.PropertyName,
            k => k.ErrorMessage, (propertyName, errorMessage) => new
            {
                Key = propertyName,
                Values = errorMessage.Distinct().ToArray()
            })
            .ToDictionary(x => x.Key, x => x.Values[0]);

        if (errorDictionary.Any())
        {
            var errors = errorDictionary.Select(k => new ValidationFailure
            {
                PropertyName = k.Value,
                ErrorCode = k.Key
            });
            throw new ValidationException(errors);
        }
        return await next();
    }
}
