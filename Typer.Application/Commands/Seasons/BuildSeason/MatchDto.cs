using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Seasons.BuildSeason
{
    public class MatchDto
    {
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
        public int? HomeTeamGoals { get; set; }
        public int? AwayTeamGoals { get; set; }
        public DateTime MatchDate { get; set; }
        public int GameweekNumber { get; set; }
    }
}
