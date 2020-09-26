using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Team.UpdateTeam
{
    public class UpdateTeamCommand : IRequest<Unit>
    {
        public long TeamId { get; set; }
        public string TeamName { get; set; }
    }
}
