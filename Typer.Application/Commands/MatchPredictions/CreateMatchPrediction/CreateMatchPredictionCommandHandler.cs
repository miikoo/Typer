using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces.Repositories;
using Typer.Domain.Models;

namespace Typer.Application.Commands.MatchPredictions.CreateMatchPrediction
{
    public class CreateMatchPredictionCommandHandler : IRequestHandler<CreateMatchPredictionCommand, Unit>
    {
        private readonly IMatchPredictionRepository _matchPredictionRepository;

        public CreateMatchPredictionCommandHandler(IMatchPredictionRepository matchPredictionRepository)
        {
            _matchPredictionRepository = matchPredictionRepository;
        }

        public async Task<Unit> Handle(CreateMatchPredictionCommand request, CancellationToken cancellationToken)
        {
            await _matchPredictionRepository.CreateAsync(MatchPrediction.Create(request.HomeTeamGoalsPrediction,
                request.AwayTeamGoalsPrediction, request.MatchId, request.UserId));
            return Unit.Value;
        }
    }
}
