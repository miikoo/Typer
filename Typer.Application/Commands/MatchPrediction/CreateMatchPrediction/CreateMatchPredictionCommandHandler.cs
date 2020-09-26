using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.API.Commands.MatchPrediction.CreateMatchPrediction
{
    public class CreateMatchPredictionCommandHandler : IRequestHandler<CreateMatchPredictionCommand, long>
    {
        private readonly IMatchPredictionRepository _matchPredictionRepository;

        public CreateMatchPredictionCommandHandler(IMatchPredictionRepository matchPredictionRepository)
        {
            _matchPredictionRepository = matchPredictionRepository;
        }

        public async Task<long> Handle(CreateMatchPredictionCommand request, CancellationToken cancellationToken)
            => await _matchPredictionRepository.CreateAsync(request.HomeTeamGoalsPrediction, request.AwayTeamGoalsPrediction,
                request.UserId, request.MatchId);
    }
}
