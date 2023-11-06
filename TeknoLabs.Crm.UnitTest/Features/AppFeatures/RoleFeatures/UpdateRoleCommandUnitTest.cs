using Moq;
using TeknoLabs.Crm.Application.Features.App.RoleFeatures.UpdateRole;
using TeknoLabs.Crm.Application.Services.App;
using TeknoLabs.Crm.Domain.AppEntities.Identity;
using Shouldly;

namespace TeknoLabs.Crm.UnitTest.Features.AppFeatures.RoleFeatures;

public sealed class UpdateRoleCommandUnitTest
{
    private readonly Mock<IRoleService> _roleServiceMock;

    public UpdateRoleCommandUnitTest()
    {
        _roleServiceMock = new();
    }

    [Fact]
    public async Task AppRoleShouldNotBe()
    {
        _roleServiceMock.Setup(
            x => x.GetById(It.IsAny<string>()))
            .ReturnsAsync(new AppRole());
    }

    [Fact]
    public async Task AppRoleCodeShouldBeUniqe()
    {
        AppRole checkRoleCode = await _roleServiceMock.Object.GetByCode("UCAF.Create");
        checkRoleCode.ShouldBeNull();
    }

    [Fact]
    public async Task UpdateRoleCommandResponseShouldNotBeNull()
    {
        var command = new UpdateRoleRequest(
            Id: "486083b2-57f1-4a72-b72b-55bf752a2d31",
            Code: "UCAF.Create",
            Name: "Hesap Planı Kayıt Ekleme");

        _roleServiceMock.Setup(
            x => x.GetById(It.IsAny<string>()))
            .ReturnsAsync(new AppRole());

        var handler = new UpdateRoleHandler(_roleServiceMock.Object);

        UpdateRoleResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
