using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Domain.Models
{
    public class Match
    {
        public long MatchId { get; set; }
        public int? HomeTeamGoals { get; set; }
        public int? AwayTeamGoals { get; set; }
        public long HomeTeamId { get; set; }
        public long AwayTeamId { get; set; }
        public DateTime MatchDate { get; set; }
    }
}
