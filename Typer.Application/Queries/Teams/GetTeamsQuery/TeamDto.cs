using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Teams.GetTeamsQuery
{
    public class TeamDto
    {
        public TeamDto(Guid teamId, string teamName)
        {
            TeamId = teamId;
            TeamName = teamName;
        }

        public Guid TeamId { get; set; }
        public string TeamName { get; set; }
    }
}
