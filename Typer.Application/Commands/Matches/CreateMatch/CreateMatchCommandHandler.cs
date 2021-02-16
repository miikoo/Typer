using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces.Repositories;
using Typer.Domain.Models;

namespace Typer.Application.Commands.Matches.CreateMatch
{
    public class CreateMatchCommandHandler : IRequestHandler<CreateMatchCommand, MatchDto>
    {
        private readonly IMatchRepository _matchRepository;

        public CreateMatchCommandHandler(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }

        public async Task<MatchDto> Handle(CreateMatchCommand request, CancellationToken cancellationToken)
        {
            var match = Match.Create(request.HomeTeamGoals, request.AwayTeamGoals, request.MatchDate, request.AwayTeamId,
                request.HomeTeamId, request.GameweekId);
            await _matchRepository.CreateAsync(match);
            return new MatchDto(match.MatchId);
        }
    }
}
