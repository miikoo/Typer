using System;
using System.Collections.Generic;
using System.Text;
using Typer.Domain.Models;

namespace Typer.Infrastructure.Entities
{
    public class DbMatchPrediction
    {
        public Guid MatchPredictionId { get; set; }
        public int? HomeTeamGoalPrediction { get; set; }
        public int? AwayTeamGoalPrediction { get; set; }

        public Guid UserId { get; set; }
        public Guid MatchId { get; set; }

        public static DbMatchPrediction Create(MatchPrediction matchPrediction)
            => new()
            {
                AwayTeamGoalPrediction = matchPrediction.AwayTeamGoalPrediction,
                HomeTeamGoalPrediction = matchPrediction.HomeTeamGoalPrediction,
                UserId = matchPrediction.UserId,
                MatchId = matchPrediction.MatchId,
                MatchPredictionId = matchPrediction.MatchPredictionId
            };
    }
}