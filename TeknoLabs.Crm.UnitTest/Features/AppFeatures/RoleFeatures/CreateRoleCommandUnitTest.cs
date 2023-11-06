using Moq;
using TeknoLabs.Crm.Application.Features.App.RoleFeatures.CreateRole;
using TeknoLabs.Crm.Application.Services.App;
using TeknoLabs.Crm.Domain.AppEntities.Identity;
using Shouldly;

namespace TeknoLabs.Crm.UnitTest.Features.AppFeatures.RoleFeatures;

public sealed class CreateRoleCommandUnitTest
{
    private readonly Mock<IRoleService> _roleServiceMock;

    public CreateRoleCommandUnitTest()
    {
        _roleServiceMock = new();
    }

    [Fact]
    public async Task AppRoleShouldBeNull()
    {
        AppRole appRole = await _roleServiceMock.Object.GetByCode("UCAF.Create");
        appRole.ShouldBeNull();
    }

    [Fact]
    public async Task CreateRoleCommandResponseShouldNotBeNull()
    {
        var command = new CreateRoleRequest(
            Code: "UCAF.Create",
            Name: "Hesap Planı Kayıt Ekleme");

        var handler = new CreateRoleHandler(_roleServiceMock.Object);

        CreateRoleResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
