using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.Gameweek.GetGameweeksBySeasonId;

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
            => await (from g in _context.Gameweeks
                      where g.SeasonId == request.SeasonId
                      select new GameweekDto
                      {
                          GameweekId = g.GameweekId,
                          GameweekNumber = g.GameweekNumber
                      }).ToListAsync();
    }
}
