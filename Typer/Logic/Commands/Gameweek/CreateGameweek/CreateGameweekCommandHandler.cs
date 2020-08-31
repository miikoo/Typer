using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.DtoModels;
using Typer.Logic.Services;

namespace Typer.Logic.Commands.Gameweek.CreateGameweek
{
    public class CreateGameweekCommandHandler : IRequestHandler<CreateGameweekCommand, GameweekDto>
    {
        private readonly IGameweekService _gameweekService;

        public CreateGameweekCommandHandler(IGameweekService gameweekService)
        {
            _gameweekService = gameweekService;
        }

        public async Task<GameweekDto> Handle(CreateGameweekCommand request, CancellationToken cancellationToken)
        {
            return await _gameweekService.CreateGameweek(request.SeasonId, request.GameweekNumber);
        }
    }
}
