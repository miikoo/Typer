using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.Application.Commands.Gameweek.DeleteGameweek
{
    public class DeleteGameweekCommandHandler : IRequestHandler<DeleteGameweekCommand, Unit>
    {
        private readonly IGameweekRepository _gameweekRepository;

        public DeleteGameweekCommandHandler(IGameweekRepository gameweekRepository)
        {
            _gameweekRepository = gameweekRepository;
        }

        public async Task<Unit> Handle(DeleteGameweekCommand request, CancellationToken cancellationToken)
        {
            await _gameweekRepository.DeleteAsync(request.GameweekId);
            return Unit.Value;
        }
    }
}
