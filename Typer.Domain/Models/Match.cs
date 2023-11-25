using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Domain.Models
{
    public class Match
    {
        public Match()
        {
            
        }

        public Match(string matchId, int? homeTeamGoals, int? awayTeamGoals, DateTime matchDate, string awayTeamId,
            string homeTeamId, string gameweekId)
        {
            MatchId = matchId;
            HomeTeamGoals = homeTeamGoals;
            AwayTeamGoals = awayTeamGoals;
            MatchDate = matchDate;
            GameweekId = gameweekId;
            HomeTeamId = homeTeamId;
            AwayTeamId = awayTeamId;
        }

        public string MatchId { get; set; }
        public int? HomeTeamGoals { get; set; }
        public int? AwayTeamGoals { get; set; }
        public DateTime MatchDate { get; set; }
        public string GameweekId { get; set; }
        public string HomeTeamId { get; set; }
        public string AwayTeamId { get; set; }

        public static Match Create(int? homeTeamGoals, int? awayTeamGoals, DateTime matchDate, string awayTeamId,
            string homeTeamId, string gameweekId)
            => new Match(Guid.NewGuid().ToString(), homeTeamGoals, awayTeamGoals, matchDate, awayTeamId, homeTeamId, gameweekId);
    }
}
