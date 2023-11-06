using Moq;
using TeknoLabs.Crm.Application.Features.App.ClientFeature.Commands.CreateClient;
using TeknoLabs.Crm.Application.Services.App;
using TeknoLabs.Crm.Domain.AppEntities;
using Shouldly;

namespace TeknoLabs.Crm.UnitTest.Features.AppFeatures.CompanyFeatures;

public sealed class CreateCompanyCommandUnitTest
{
    private readonly Mock<IClientService> _clientService;

    public CreateCompanyCommandUnitTest()
    {
        _clientService = new();
    }

    [Fact]
    public async Task CompanyShouldBeNull()
    {
        Client company = (await _clientService.Object.GetClientByName("Saydam Ltd Şti"))!;
        company.ShouldBeNull();
    }

    [Fact]
    public async Task CreateCompanyCommandResponseShouldNotBeNull()
    {
        var command = new CreateClientRequest(
            Name: "Saydam Ltd Şti",
           ServerName: "localhost",
           DatabaseName: "SaydamMuhasebeDb",
           UserId: "",
           Password: "");

        var handler = new CreateClientHandler(_clientService.Object);


        CreateClientResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
