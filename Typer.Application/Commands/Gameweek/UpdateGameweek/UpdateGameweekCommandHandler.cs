using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.Application.Commands.Gameweek.UpdateGameweek
{
    public class UpdateGameweekCommandHandler : IRequestHandler<UpdateGameweekCommand, Unit>
    {
        private readonly IGameweekRepository _gameweekRepository;

        public UpdateGameweekCommandHandler(IGameweekRepository gameweekRepository)
        {
            _gameweekRepository = gameweekRepository;
        }

        public async Task<Unit> Handle(UpdateGameweekCommand request, CancellationToken cancellationToken)
        {
            await _gameweekRepository.UpdateAsync(request.GameweekId, request.GameweekNumber);
            return Unit.Value;
        }
    }
}
