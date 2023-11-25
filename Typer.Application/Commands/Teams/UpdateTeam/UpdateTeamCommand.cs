using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Teams.UpdateTeam
{
    public class UpdateTeamCommand : IRequest<Unit>
    {
        public string TeamId { get; set; }
        public string TeamName { get; set; }
    }
}
