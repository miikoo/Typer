using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces.Repositories;

namespace Typer.Application.Commands.MatchPredictions.UpdateMatchPredictions
{
    public class UpdateMatchPredictionsCommandHandler : IRequestHandler<UpdateMatchPredictionsCommand, Unit>
    {
        private readonly IMatchPredictionRepository _matchPredictionRepository;

        public UpdateMatchPredictionsCommandHandler(IMatchPredictionRepository matchPredictionRepository)
        {
            _matchPredictionRepository = matchPredictionRepository;
        }

        public async Task<Unit> Handle(UpdateMatchPredictionsCommand request, CancellationToken cancellationToken)
        {
            var predictions = request.Predictions.Select(x => Tuple.Create(x.MatchPredictionId,
                x.HomeTeamGoalsPrediction, x.AwayTeamGoalsPrediction)).ToArray();
            await _matchPredictionRepository.UpdateManyAsync(predictions);
            return Unit.Value;
        }
    }
}
