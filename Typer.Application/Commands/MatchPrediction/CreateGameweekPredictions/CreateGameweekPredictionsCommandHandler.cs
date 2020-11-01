using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.Application.Commands.MatchPrediction.CreateGameweekPredictions
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
            foreach (var match in matches.Select(x => new {
                MatchId= x.MatchId,
                matchDate= x.MatchDate
            } ))
                if(match.matchDate > DateTime.UtcNow) 
                    await _matchPredictionRepository.CreateAsync(null, null, request.UserId, match.MatchId);
            return Unit.Value;
        }
    }
}
