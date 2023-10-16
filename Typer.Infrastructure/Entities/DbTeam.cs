using System;
using System.Collections.Generic;
using System.Text;
using Typer.Domain.Models;

namespace Typer.Infrastructure.Entities
{
    public class DbTeam
    {
        public DbTeam()
        {
        }

        public Guid TeamId { get; set; }
        public string TeamName { get; set; }

        public static DbTeam Create(Team team)
            => new()
            {
                TeamName = team.TeamName,
                TeamId = team.TeamId
            };
    }
}