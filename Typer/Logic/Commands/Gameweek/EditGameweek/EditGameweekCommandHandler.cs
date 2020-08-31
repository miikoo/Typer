using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.DtoModels;
using Typer.Logic.Services;

namespace Typer.Logic.Commands.Gameweek.EditGameweek
{
    public class EditGameweekCommandHandler : IRequestHandler<EditGameweekCommand, GameweekDto>
    {
        private readonly IGameweekService _gameweekService;

        public EditGameweekCommandHandler(IGameweekService gameweekService)
        {
            _gameweekService = gameweekService;
        }

        public async Task<GameweekDto> Handle(EditGameweekCommand request, CancellationToken cancellationToken)
        {
            return await _gameweekService.EditGameweek(request.gameweekId, request.gameweekNumber);
        }
    }
}
