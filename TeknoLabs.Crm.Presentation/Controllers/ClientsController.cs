using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TeknoLabs.Crm.Application.Features.App.Client.Commands.CreateClient;
using TeknoLabs.Crm.Presentation.Abstraction;

namespace TeknoLabs.Crm.Presentation.Controllers
{
	public class ClientsController : ApiController
	{
        public ClientsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> CreateClient(CreateClientRequest request)
        {
           CreateClientResponse response= await _mediator.Send(request);
            return Ok(response);
        }

    }
}

