using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.API.Commands.Match.UpdateMatchDetails
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
            await _matchRepository.UpdateAsync(request.MatchId, match.HomeTeamGoals,
                match.AwayTeamGoals, request.MatchDate, request.HomeTeamId, request.AwayTeamId);
            return Unit.Value;
        }
    }
}
