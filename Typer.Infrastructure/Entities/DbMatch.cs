using System;
using System.Collections.Generic;
using System.Text;
using Typer.Domain.Models;

namespace Typer.Infrastructure.Entities
{
    public class DbMatch
    {
        public DbMatch()
        {
        }

        public Guid MatchId { get; set; }
        public int? HomeTeamGoals { get; set; }
        public int? AwayTeamGoals { get; set; }
        public DateTime MatchDate { get; set; }

        public Guid HomeTeamId { get; set; }
        public Guid AwayTeamId { get; set; }
        public Guid GameweekId { get; set; }
        

        public static DbMatch Create(Match match)
            => new()
            {
                AwayTeamGoals = match.AwayTeamGoals,
                AwayTeamId = match.AwayTeamId,
                GameweekId = match.GameweekId,
                HomeTeamGoals = match.HomeTeamGoals,
                HomeTeamId = match.HomeTeamId,
                MatchDate = match.MatchDate,
                MatchId = match.MatchId
            };
    }
}
