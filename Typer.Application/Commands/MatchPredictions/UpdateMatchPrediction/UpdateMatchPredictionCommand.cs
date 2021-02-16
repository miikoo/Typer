using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.MatchPredictions.UpdateMatchPrediction
{
    public class UpdateMatchPredictionCommand : IRequest<Unit>
    {
        public Guid MatchPredictionId { get; set; }
        public int? HomeTeamGoalsPrediction { get; set; }
        public int? AwayTeamGoalsPrediction { get; set; }
    }
}
