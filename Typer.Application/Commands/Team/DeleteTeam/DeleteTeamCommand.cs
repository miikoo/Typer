using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Team.DeleteTeam
{
    public class DeleteTeamCommand : IRequest<Unit>
    {
        public long TeamId { get; set; }
    }
}
