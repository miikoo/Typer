using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces.Repositories;
using Typer.Domain.Models;

namespace Typer.Application.Commands.MatchPredictions.UpdateMatchPrediction
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
            var prediction = await _matchPredictionRepository.GetAsync(request.MatchPredictionId);
            await _matchPredictionRepository.UpdateAsync(MatchPrediction.Create(request.HomeTeamGoalsPrediction,
                request.AwayTeamGoalsPrediction, prediction.MatchId, prediction.UserId));
            return Unit.Value;
        }
    }
}
