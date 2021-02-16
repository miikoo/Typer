using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Matches.GetMatchesByGameweekId
{
    public class MatchDto
    {
        public MatchDto(Guid matchId, int? homeTeamGoals, int? awayTeamGoals, DateTime matchDate,
            string homeTeamName, string awayTeamName)
        {
            MatchId = matchId;
            HomeTeamGoals = homeTeamGoals;
            AwayTeamGoals = awayTeamGoals;
            MatchDate = matchDate;
            HomeTeamName = homeTeamName;
            AwayTeamName = awayTeamName;
        }

        public Guid MatchId { get; set; }
        public int? HomeTeamGoals { get; set; }
        public int? AwayTeamGoals { get; set; }
        public DateTime MatchDate { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
    }
}
