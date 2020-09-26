using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.Application.Commands.Gameweek.CreateGameweek
{
    public class CreateGameweekCommandHandler : IRequestHandler<CreateGameweekCommand, long>
    {
        private readonly IGameweekRepository _gameweekRepository;

        public CreateGameweekCommandHandler(IGameweekRepository gameweekRepository)
        {
            _gameweekRepository = gameweekRepository;
        }

        public async Task<long> Handle(CreateGameweekCommand request, CancellationToken cancellationToken)
            => await _gameweekRepository.CreateAsync(request.SeasonId, request.GameweekNumber);
    }
}
