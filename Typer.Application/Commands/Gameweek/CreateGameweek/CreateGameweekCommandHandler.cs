using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.Application.Commands.Gameweek.CreateGameweek
{
    public class CreateGameweekCommandHandler : IRequestHandler<CreateGameweekCommand, Unit>
    {
        private readonly IGameweekRepository _gameweekRepository;

        public CreateGameweekCommandHandler(IGameweekRepository gameweekRepository)
        {
            _gameweekRepository = gameweekRepository;
        }

        public async Task<Unit> Handle(CreateGameweekCommand request, CancellationToken cancellationToken)
        {
            await _gameweekRepository.CreateAsync(request.SeasonId, request.GameweekNumber);
            return Unit.Value;
        }
    }
}
