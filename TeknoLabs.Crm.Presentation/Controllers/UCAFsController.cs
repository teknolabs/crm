using MediatR;
using Microsoft.AspNetCore.Mvc;
using TeknoLabs.Crm.Application.Features.ClientFeature.UCAFFeature.Commands.CreateUCAF;
using TeknoLabs.Crm.Presentation.Abstraction;

namespace TeknoLabs.Crm.Presentation.Controllers
{
    public sealed class UCAFsController : ApiController
    {
        public UCAFsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateUCAF(CreateUCAFRequest request)
        {
            CreateUCAFResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
