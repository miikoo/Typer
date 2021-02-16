using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Domain.Models
{
    public class MatchPrediction
    {
        public MatchPrediction(Guid matchPredictionId, int? homeTeamGoalPredictions, int? awayTeamGoalPredictions,
            Guid matchId, Guid userId)
        {
            MatchPredictionId = matchPredictionId;
            HomeTeamGoalPrediction = homeTeamGoalPredictions;
            AwayTeamGoalPrediction = awayTeamGoalPredictions;
            MatchId = matchId;
            UserId = userId;
        }

        public Guid MatchPredictionId { get; set; }
        public int? HomeTeamGoalPrediction { get; set; }
        public int? AwayTeamGoalPrediction { get; set; }
        public Guid MatchId { get; set; }
        public Guid UserId { get; set; }

        public static MatchPrediction Create(int? homeTeamGoalPredictions, int? awayTeamGoalPredictions, Guid matchId, Guid userId)
            => new MatchPrediction(Guid.NewGuid(), homeTeamGoalPredictions, awayTeamGoalPredictions, matchId, userId);
    }
}
