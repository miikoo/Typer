using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces.Repositories;
using Typer.Domain.Models;

namespace Typer.Application.Commands.Gameweeks.UpdateGameweek
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
            var gameweek = await _gameweekRepository.GetByIdAsync(request.GameweekId);
            await _gameweekRepository.UpdateAsync(new Gameweek(request.GameweekId, request.GameweekNumber, gameweek.GameweekId));
            return Unit.Value;
        }
    }
}
