using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Team.CreateTeam
{
    public class CreateTeamCommand : IRequest<long>
    {
        public string TeamName { get; set; }
    }
}
