using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.Services;

namespace Typer.Logic.Commands.CreateMatchPredictionCommand
{
    public class CreateMatchPredictionCommandHandler : IRequestHandler<CreateMatchPredictionCommand, Unit>
    {
        private readonly IMatchPredictionService _matchPredictionService;

        public CreateMatchPredictionCommandHandler(IMatchPredictionService matchPredictionService)
        {
            _matchPredictionService = matchPredictionService
        }

        public async Task<Unit> Handle(CreateMatchPredictionCommand request, CancellationToken cancellationToken)
        {
            await _matchPredictionService.CreateMatchPrediction(request.UserId, request.MatchId, request.HomeTeamGoals, request.AwayTeamGoals);
            return Unit.Value;
        }
    }
}
