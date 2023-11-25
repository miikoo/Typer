using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Teams.GetTeamsQuery
{
    public class TeamDto
    {
        public TeamDto(string teamId, string teamName)
        {
            TeamId = teamId;
            TeamName = teamName;
        }

        public TeamDto()
        {
            
        }

        public string TeamId { get; set; }
        public string TeamName { get; set; }
    }
}
