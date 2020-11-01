using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.Application.Commands.MatchPrediction.UpdateMatchPredictions
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
            foreach (var prediction in request.Predictions)
                await _matchPredictionRepository.UpdateAsync(prediction.HomeTeamGoalsPrediction, prediction.AwayTeamGoalsPrediction
                    , prediction.MatchPredictionId);
            return Unit.Value;
        }
    }
}
