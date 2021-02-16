using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces.Repositories;
using Typer.Domain.Models;

namespace Typer.Application.Commands.Gameweeks.CreateGameweek
{
    public class CreateGameweekCommandHandler : IRequestHandler<CreateGameweekCommand, GameweekDto>
    {
        private readonly IGameweekRepository _gameweekRepository;

        public CreateGameweekCommandHandler(IGameweekRepository gameweekRepository)
        {
            _gameweekRepository = gameweekRepository;
        }

        public async Task<GameweekDto> Handle(CreateGameweekCommand request, CancellationToken cancellationToken)
        {
            var gameweek = Gameweek.Create(request.GameweekNumber, request.SeasonId);
            await _gameweekRepository.CreateAsync(gameweek);
            return new GameweekDto(gameweek.GameweekId);
        }
    }
}
