using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Domain.Models
{
    public class MatchPrediction
    {
        public long MatchPredictionId { get; set; }
        public int? HomeTeamGoalPrediction { get; set; }
        public int? AwayTeamGoalPrediction { get; set; }
    }
}
