using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.API.Commands.Match.UpdateMatchResult
{
    public class UpdateMatchResultCommandHandler : IRequestHandler<UpdateMatchResultCommand, Unit>
    {
        private readonly IMatchRepository _matchRepository;

        public UpdateMatchResultCommandHandler(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }

        public async Task<Unit> Handle(UpdateMatchResultCommand request, CancellationToken cancellationToken)
        {
            var match = await _matchRepository.GetByIdAsync(request.MatchId);
            await _matchRepository.UpdateAsync(request.MatchId, request.HomeTeamGoals, request.AwayTeamGoals, match.MatchDate,
                match.HomeTeamId, match.AwayTeamId);
            return Unit.Value;
        }
    }
}
