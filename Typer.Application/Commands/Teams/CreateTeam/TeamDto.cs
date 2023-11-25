using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Teams.CreateTeam
{
    public class TeamDto
    {
        public TeamDto()
        {
            
        }
        public TeamDto(string teamId)
        {
            TeamId = teamId;
        }

        public string TeamId { get; set; }
    }
}
