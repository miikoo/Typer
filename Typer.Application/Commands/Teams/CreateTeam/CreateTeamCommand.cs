using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Teams.CreateTeam
{
    public class CreateTeamCommand : IRequest<TeamDto>
    {
        public string TeamName { get; set; }
    }
}
