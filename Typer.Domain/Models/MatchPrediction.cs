using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Domain.Models
{
    public class MatchPrediction
    {
        public MatchPrediction(string matchPredictionId, int? homeTeamGoalPredictions, int? awayTeamGoalPredictions,
            string matchId, string userId)
        {
            MatchPredictionId = matchPredictionId;
            HomeTeamGoalPrediction = homeTeamGoalPredictions;
            AwayTeamGoalPrediction = awayTeamGoalPredictions;
            MatchId = matchId;
            UserId = userId;
        }

        public MatchPrediction()
        {
            
        }

        public string MatchPredictionId { get; set; }
        public int? HomeTeamGoalPrediction { get; set; }
        public int? AwayTeamGoalPrediction { get; set; }
        public string MatchId { get; set; }
        public string UserId { get; set; }

        public static MatchPrediction Create(int? homeTeamGoalPredictions, int? awayTeamGoalPredictions, string matchId, string userId)
            => new MatchPrediction(Guid.NewGuid().ToString(), homeTeamGoalPredictions, awayTeamGoalPredictions, matchId, userId);
    }
}
