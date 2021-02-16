using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Teams.DeleteTeam
{
    public class DeleteTeamCommand : IRequest<Unit>
    {
        public Guid TeamId { get; set; }
    }
}
