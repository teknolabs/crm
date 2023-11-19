using System;
using TeknoLabs.Crm.Application.Messaging;
using TeknoLabs.Crm.Domain.AppEntities;

namespace TeknoLabs.Crm.Application.Features.App.MainRoleFeatures.CreateMainRole;

public class CreateMainRoleHandler : ICommandHandler<CreateMainRoleCommand,CreateMainRoleResponse>
{
    private readonly IMainRoleService _mainRoleService;

    public CreateMainRoleHandler(IMainRoleService mainRoleService)
    {
        _mainRoleService = mainRoleService;
    }

    public async Task<CreateMainRoleResponse> Handle(CreateMainRoleCommand request, CancellationToken cancellationToken)
    {
        MainRole checkMainRoleTitle = await _mainRoleService.GetByTitleAndCompanyId(request.Title, request.ClientId, cancellationToken);
        if (checkMainRoleTitle != null) throw new Exception("Bu rol daha önce kaydedilmiş!");

        MainRole mainRole = new(
            Guid.NewGuid().ToString(),
            request.Title,
            request.ClientId != null ? false : true,
            request.ClientId);

        await _mainRoleService.CreateAsync(mainRole, cancellationToken);

        return new();
    } 
}

