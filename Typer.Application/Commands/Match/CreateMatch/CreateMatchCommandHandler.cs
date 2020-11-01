using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.Application.Commands.Match.CreateMatch
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
            var id = await _matchRepository.CreateAsync(request.HomeTeamId, request.AwayTeamId, request.GameweekId, request.MatchDate, 
                request.HomeTeamGoals, request.AwayTeamGoals);
            return new MatchDto(id);
        }
    }
}
