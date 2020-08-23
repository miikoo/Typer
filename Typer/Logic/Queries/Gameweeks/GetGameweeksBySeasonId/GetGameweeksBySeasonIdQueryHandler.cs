using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.DtoModels;
using Typer.Logic.Services;

namespace Typer.Logic.Queries.Gameweeks.GetGameweeksBySeasonId
{
    public class GetGameweeksBySeasonIdQueryHandler : IRequestHandler<GetGameweeksBySeasonIdQuery, List<GameweekDto>>
    {
        private readonly IGameweekService _gameweekService;

        public GetGameweeksBySeasonIdQueryHandler(IGameweekService gameweekService)
        {
            _gameweekService = gameweekService;
        }

        public async Task<List<GameweekDto>> Handle(GetGameweeksBySeasonIdQuery request, CancellationToken cancellationToken)
            => await _gameweekService.GetGameweeksBySeasonId(request.SeasonId);
    }
}
