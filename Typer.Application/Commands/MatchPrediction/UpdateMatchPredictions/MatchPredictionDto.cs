using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.MatchPrediction.UpdateMatchPredictions
{
    public class MatchPredictionDto
    {
        public long MatchPredictionId { get; set; }
        public int? HomeTeamGoalsPrediction { get; set; }
        public int? AwayTeamGoalsPrediction { get; set; }
    }
}
