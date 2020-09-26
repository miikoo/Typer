using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Matches.GetMatchesByGameweekId
{
    public class MatchDto
    {
        public long MatchId { get; set; }
        public int? HomeTeamGoals { get; set; }
        public int? AwayTeamGoals { get; set; }
        public DateTime MatchDate { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
    }
}
