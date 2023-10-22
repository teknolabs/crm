using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknoLabs.Crm.Application.Features.App.ClientFeature.Commands.MigrateClientDatabase
{
    public sealed class MigrateClientDatabaseRequest : IRequest<MigrateClientDatabaseResponse>
    {
    }
}
