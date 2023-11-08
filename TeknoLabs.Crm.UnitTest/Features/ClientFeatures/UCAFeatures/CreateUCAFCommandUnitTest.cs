using Moq;
using Shouldly;
using TeknoLabs.Crm.Application.Features.ClientFeature.UCAFFeature.Commands.CreateUCAF;
using TeknoLabs.Crm.Application.Services.ClientService;

namespace TeknoLabs.Crm.UnitTest.Features.CompanyFeatures.UCAFeatures;

public sealed class CreateUCAFCommandUnitTest
{
    private readonly Mock<IUCAFService> _ucafService;

    public CreateUCAFCommandUnitTest()
    {
        _ucafService = new();
    }

    [Fact]
    public async Task CreateUCAFCommandResponseShouldNotBeNull()
    {
        var command = new CreateUCAFRequest(
            Code: "100.01.001",
            Name: "TL Kasa",
            Type: 'M',
            ClientId: "585985c0-4576-4d62-ae67-59a6f72ae906");

        var handler = new CreateUCAFHandler(_ucafService.Object);

        CreateUCAFResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
