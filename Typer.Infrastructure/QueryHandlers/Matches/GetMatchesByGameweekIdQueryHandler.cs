using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.Matches.GetMatchesByGameweekId;

namespace Typer.Infrastructure.QueryHandlers.Matches
{
    public class GetMatchesByGameweekIdQueryHandler : IRequestHandler<GetMatchesByGameweekIdQuery, List<MatchDto>>
    {
        private readonly TyperContext _context;

        public GetMatchesByGameweekIdQueryHandler(TyperContext context)
        {
            _context = context;
        }

        public async Task<List<MatchDto>> Handle(GetMatchesByGameweekIdQuery request, CancellationToken cancellationToken)
        {
            var matches = await (from m in _context.Matches
                                 join at in _context.Teams on m.AwayTeamId equals at.TeamId
                                 join ht in _context.Teams on m.HomeTeamId equals ht.TeamId
                                 where m.GameweekId == request.GameweekId
                                 select new MatchDto(m.MatchId, m.HomeTeamGoals, m.AwayTeamGoals, m.MatchDate,
                                     ht.TeamName, at.TeamName)).ToListAsync();
            return matches.OrderBy(x => x.MatchDate).ToList();
        }
    }
}
