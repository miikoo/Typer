using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.Gameweeks.GetGameweeksBySeasonId;

namespace Typer.Infrastructure.QueryHandlers.Gameweeks
{
    public class GetGameweeksBySeasonIdQueryHandler : IRequestHandler<GetGameweeksBySeasonIdQuery, List<GameweekDto>>
    {
        private readonly TyperContext _context;

        public GetGameweeksBySeasonIdQueryHandler(TyperContext context)
        {
            _context = context;
        }

        public async Task<List<GameweekDto>> Handle(GetGameweeksBySeasonIdQuery request, CancellationToken cancellationToken)
        {
            var gameweeks = await (from g in _context.Gameweeks
                   where g.SeasonId == request.SeasonId
                   select new GameweekDto(g.GameweekId, g.GameweekNumber))
              .ToListAsync();
            return gameweeks?.OrderBy(x => x.GameweekNumber).ToList();
        }
    }
}