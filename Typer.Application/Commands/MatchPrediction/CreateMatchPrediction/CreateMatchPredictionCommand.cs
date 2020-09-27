using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.MatchPrediction.CreateMatchPrediction
{
    public class CreateMatchPredictionCommand : IRequest<Unit>
    {
        public long MatchId { get; set; }
        public int AwayTeamGoalsPrediction { get; set; }
        public int HomeTeamGoalsPrediction { get; set; }
        public Guid UserId { get; set; }
    }
}
