using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.MatchPredictions.UpdateMatchPredictions
{
    public class MatchPredictionDto
    {
        public MatchPredictionDto()
        {
            
        }
        public string MatchPredictionId { get; set; }
        public int? HomeTeamGoalsPrediction { get; set; }
        public int? AwayTeamGoalsPrediction { get; set; }
    }
}
