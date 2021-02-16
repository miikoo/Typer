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
            MatchesAsHomeTeam = new HashSet<DbMatch>();
            MatchesAsAwayTeam = new HashSet<DbMatch>();
        }

        public Guid TeamId { get; set; }
        public string TeamName { get; set; }
        public virtual ICollection<DbMatch> MatchesAsHomeTeam { get; set; }
        public virtual ICollection<DbMatch> MatchesAsAwayTeam { get; set; }

        public static DbTeam Create(Team team)
            => new DbTeam
            {
                TeamName = team.TeamName,
                TeamId = team.TeamId
            };
    }
}