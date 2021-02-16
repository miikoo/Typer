using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces.Repositories;
using Typer.Domain.Models;

namespace Typer.Application.Commands.Matches.UpdateMatchResult
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
            await _matchRepository.UpdateAsync(new Match(request.MatchId, request.HomeTeamGoals, request.AwayTeamGoals, match.MatchDate, 
                match.AwayTeamId, match.HomeTeamId, match.GameweekId));
            return Unit.Value;
        }
    }
}
