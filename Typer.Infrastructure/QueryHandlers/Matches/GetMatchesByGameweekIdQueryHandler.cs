﻿using MediatR;
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
            => await (from m in _context.Matches
                      join at in _context.Teams on m.AwayTeamId equals at.TeamId
                      join ht in _context.Teams on m.HomeTeamId equals ht.TeamId
                      where m.GameweekId == request.GameweekId
                      select new MatchDto
                      {
                          AwayTeamGoals = m.AwayTeamGoals,
                          AwayTeamName = at.TeamName,
                          HomeTeamGoals = m.HomeTeamGoals,
                          HomeTeamName = ht.TeamName,
                          MatchDate = m.MatchDate,
                          MatchId = m.MatchId
                      }).OrderBy(x => x.MatchDate).ToListAsync();
    }
}
