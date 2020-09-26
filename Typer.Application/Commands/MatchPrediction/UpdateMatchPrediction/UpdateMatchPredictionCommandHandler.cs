using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.API.Commands.MatchPrediction.UpdateMatchPrediction
{
    public class UpdateMatchPredictionCommandHandler : IRequestHandler<UpdateMatchPredictionCommand, Unit>
    {
        private readonly IMatchPredictionRepository _matchPredictionRepository;

        public UpdateMatchPredictionCommandHandler(IMatchPredictionRepository matchPredictionRepository)
        {
            _matchPredictionRepository = matchPredictionRepository;
        }

        public async Task<Unit> Handle(UpdateMatchPredictionCommand request, CancellationToken cancellationToken)
        {
            await _matchPredictionRepository.UpdateAsync(request.HomeTeamGoalsPrediction, request.AwayTeamGoalsPrediction,
                request.MatchPredictionId);
            return Unit.Value;
        }
    }
}
