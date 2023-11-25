using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.MatchPredictions.CreateMatchPrediction
{
    public class CreateMatchPredictionCommand : IRequest<Unit>
    {
        public string MatchId { get; set; }
        public int? AwayTeamGoalsPrediction { get; set; }
        public int? HomeTeamGoalsPrediction { get; set; }
        public string UserId { get; set; }
    }
}
