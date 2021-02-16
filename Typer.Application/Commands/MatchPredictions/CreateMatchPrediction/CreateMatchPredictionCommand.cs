using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.MatchPredictions.CreateMatchPrediction
{
    public class CreateMatchPredictionCommand : IRequest<Unit>
    {
        public Guid MatchId { get; set; }
        public int? AwayTeamGoalsPrediction { get; set; }
        public int? HomeTeamGoalsPrediction { get; set; }
        public Guid UserId { get; set; }
    }
}
