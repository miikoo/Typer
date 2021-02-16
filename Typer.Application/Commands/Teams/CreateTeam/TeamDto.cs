using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Teams.CreateTeam
{
    public class TeamDto
    {
        public TeamDto(Guid teamId)
        {
            TeamId = teamId;
        }

        public Guid TeamId { get; set; }
    }
}
