using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces.Repositories;
using Typer.Domain.Models;

namespace Typer.Application.Commands.MatchPredictions.CreateGameweekPredictions
{
    public class CreateGameweekPredictionsCommandHandler : IRequestHandler<CreateGameweekPredictionsCommand, Unit>
    {
        private readonly IMatchPredictionRepository _matchPredictionRepository;
        private readonly IMatchRepository _matchRepository;

        public CreateGameweekPredictionsCommandHandler(IMatchPredictionRepository matchPredictionRepository, IMatchRepository matchRepository)
        {
            _matchPredictionRepository = matchPredictionRepository;
            _matchRepository = matchRepository;
        }

        public async Task<Unit> Handle(CreateGameweekPredictionsCommand request, CancellationToken cancellationToken)
        {
            var matches = await _matchRepository.GetAsync(request.GameweekId);
            var predictions = matches.Where(x => x.MatchDate > DateTime.UtcNow)
                .Select(y => MatchPrediction.Create(null, null, y.MatchId, request.UserId)).ToArray();
            await _matchPredictionRepository.CreateAsync(predictions);
            return Unit.Value;
        }
    }
}
