using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Logic.Commands.CreateMatchPrediction
{
    public class CreateMatchPredictionCommand : IRequest<Unit>
    {
        public long MatchId { get; set; }
        public long UserId { get; set; }
        public int AwayTeamGoals { get; set; }
        public int HomeTeamGoals { get; set; }
    }
}
