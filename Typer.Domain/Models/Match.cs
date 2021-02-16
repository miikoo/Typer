using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Domain.Models
{
    public class Match
    {
        public Match(Guid matchId, int? homeTeamGoals, int? awayTeamGoals, DateTime matchDate, Guid awayTeamId,
            Guid homeTeamId, Guid gameweekId)
        {
            MatchId = matchId;
            HomeTeamGoals = homeTeamGoals;
            AwayTeamGoals = awayTeamGoals;
            MatchDate = matchDate;
            GameweekId = gameweekId;
            HomeTeamId = homeTeamId;
            AwayTeamId = awayTeamId;
        }

        public Guid MatchId { get; set; }
        public int? HomeTeamGoals { get; set; }
        public int? AwayTeamGoals { get; set; }
        public DateTime MatchDate { get; set; }
        public Guid GameweekId { get; set; }
        public Guid HomeTeamId { get; set; }
        public Guid AwayTeamId { get; set; }

        public static Match Create(int? homeTeamGoals, int? awayTeamGoals, DateTime matchDate, Guid awayTeamId,
            Guid homeTeamId, Guid gameweekId)
            => new Match(Guid.NewGuid(), homeTeamGoals, awayTeamGoals, matchDate, awayTeamId, homeTeamId, gameweekId);
    }
}
