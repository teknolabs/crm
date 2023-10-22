using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TeknoLabs.Crm.Application.Features.App.ClientFeature.Commands.CreateClient;
using TeknoLabs.Crm.Application.Features.App.ClientFeature.Commands.MigrateClientDatabase;
using TeknoLabs.Crm.Presentation.Abstraction;

namespace TeknoLabs.Crm.Presentation.Controllers
{
    public class ClientsController : ApiController
    {
        public ClientsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateClient(CreateClientRequest request)
        {
            CreateClientResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> MigrateClientDatabases()
        {
            MigrateClientDatabaseRequest request = new MigrateClientDatabaseRequest();
            MigrateClientDatabaseResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}

