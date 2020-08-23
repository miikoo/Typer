using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.Services;

namespace Typer.Logic.Commands.Gameweek.CreateGameweek
{
    public class CreateGameweekCommandHandler : IRequestHandler<CreateGameweekCommand, Unit>
    {
        private readonly IGameweekService _gameweekService;

        public CreateGameweekCommandHandler(IGameweekService gameweekService)
        {
            _gameweekService = gameweekService;
        }

        public async Task<Unit> Handle(CreateGameweekCommand request, CancellationToken cancellationToken)
        {
            await _gameweekService.CreateGameweek(request.SeasonId, request.GameweekNumber);
            return Unit.Value;
        }
    }
}
