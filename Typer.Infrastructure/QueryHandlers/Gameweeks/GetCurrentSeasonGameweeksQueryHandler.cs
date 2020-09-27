using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.Gameweek.GetCurrentSeasonGameweeks;

namespace Typer.Infrastructure.QueryHandlers.Gameweeks
{
    public class GetCurrentSeasonGameweeksQueryHandler : IRequestHandler<GetCurrentSeasonGameweeksQuery, List<GameweekDto>>
    {
        private readonly TyperContext _context;

        public GetCurrentSeasonGameweeksQueryHandler(TyperContext context)
        {
            _context = context;
        }

        public async Task<List<GameweekDto>> Handle(GetCurrentSeasonGameweeksQuery request, CancellationToken cancellationToken)
        {
            var seasonId = await (from m in _context.Matches
                                  where m.MatchDate > DateTime.UtcNow
                                  join cg in _context.Gameweeks on m.GameweekId equals cg.GameweekId
                                  join s in _context.Seasons on cg.SeasonId equals s.SeasonId
                                  orderby m.MatchDate
                                  select s.SeasonId).FirstAsync();

            return await (from g in _context.Gameweeks
                          where g.SeasonId == seasonId
                          select new GameweekDto
                          {
                              GameweekId = g.GameweekId,
                              GameweekNumber = g.GameweekNumber
                          }
                      ).ToListAsync();
        }

    }
}
