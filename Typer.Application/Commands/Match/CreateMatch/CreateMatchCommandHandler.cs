using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.Application.Commands.Match.CreateMatch
{
    public class CreateMatchCommandHandler : IRequestHandler<CreateMatchCommand, long>
    {
        private readonly IMatchRepository _matchRepository;

        public CreateMatchCommandHandler(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }

        public async Task<long> Handle(CreateMatchCommand request, CancellationToken cancellationToken)
            => await _matchRepository.CreateAsync(request.HomeTeamId, request.AwayTeamId, request.GameweekId, request.MatchDate);
    }
}
