using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.Services;

namespace Typer.Logic.Commands.Gameweek.DeleteGameweek
{
    public class DeleteGameweekCommandHandler : IRequestHandler<DeleteGameweekCommand, Unit>
    {
        private readonly IGameweekService _gameweekService;

        public DeleteGameweekCommandHandler(IGameweekService gameweekService)
        {
            _gameweekService = gameweekService;
        }

        public async Task<Unit> Handle(DeleteGameweekCommand request, CancellationToken cancellationToken)
        {
            await _gameweekService.DeleteGameweek(request.GameweekId);
            return Unit.Value;
        }
    }
}
