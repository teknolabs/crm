using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknoLabs.Crm.Application.Features.Client.UCAFFeature.Commands.CreateUCAF
{
    public sealed class CreateUCAFRequest : IRequest<CreateUCAFResponse>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public char Type { get; set; }
        public string ClientId { get; set; }
    }
}
