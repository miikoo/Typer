using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces.Repositories;
using Typer.Domain.Models;

namespace Typer.Application.Commands.Matches.UpdateMatchDetails
{
    public class UpdateMatchDetailsCommandHandler : IRequestHandler<UpdateMatchDetailsCommand, Unit>
    {
        private readonly IMatchRepository _matchRepository;

        public UpdateMatchDetailsCommandHandler(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }

        public async Task<Unit> Handle(UpdateMatchDetailsCommand request, CancellationToken cancellationToken)
        {
            var match = await _matchRepository.GetByIdAsync(request.MatchId);
            await _matchRepository.UpdateAsync(Match.Create(match.HomeTeamGoals, match.AwayTeamGoals, request.MatchDate,
                request.AwayTeamId, request.HomeTeamId, match.GameweekId));
            return Unit.Value;
        }
    }
}
