using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.MatchPredictions.GetGameweekPredictionsByUserId;

namespace Typer.Infrastructure.QueryHandlers.MatchPredictions
{
    public class GetGameweekPredictionsByUserIdQueryHandler : IRequestHandler<GetGameweekPredictionsByUserIdQuery, List<MatchPredictionDto>>
    {
        private readonly TyperContext _context;

        public GetGameweekPredictionsByUserIdQueryHandler(TyperContext context)
        {
            _context = context;
        }

        public async Task<List<MatchPredictionDto>> Handle(GetGameweekPredictionsByUserIdQuery request, CancellationToken cancellationToken)
        {
            var gameweek = await (from g in _context.Gameweeks
                                        where g.GameweekId == request.GameweekId
                                        select g).FirstAsync();
            var firstGameweekMatchDate = await (from g in _context.Gameweeks
                                                       where g.GameweekId == request.GameweekId 
                                                       join m in _context.Matches on g.GameweekId equals m.GameweekId
                                                       orderby m.MatchDate
                                                       select m.MatchDate).FirstAsync();
            var lastGameweekMatchDate = await (from g in _context.Gameweeks
                                                      where g.GameweekId == request.GameweekId
                                                      join m in _context.Matches on g.GameweekId equals m.GameweekId
                                                      orderby m.MatchDate
                                                      select m.MatchDate).LastAsync();
            var lastPastGameweekMatchDate = await (from g in _context.Gameweeks
                                                   where g.GameweekNumber == gameweek.GameweekNumber - 1 && g.SeasonId == gameweek.SeasonId
                                                   join m in _context.Matches on g.GameweekId equals m.GameweekId
                                                   orderby m.MatchDate
                                                   select m.MatchDate).LastOrDefaultAsync();
            var firstNextGameweekMatchDate = await (from g in _context.Gameweeks
                                                    where g.GameweekNumber == gameweek.GameweekNumber + 1 && g.SeasonId == gameweek.SeasonId
                                                    join m in _context.Matches on g.GameweekId equals m.GameweekId
                                                    orderby m.MatchDate
                                                    select m.MatchDate).FirstOrDefaultAsync();
            var gameweekStarts = firstGameweekMatchDate.AddSeconds(-((firstGameweekMatchDate - lastPastGameweekMatchDate).TotalSeconds / 2));
            var gameweekEnds = lastGameweekMatchDate.AddSeconds((firstNextGameweekMatchDate - lastGameweekMatchDate).TotalSeconds / 2);

            var matches = (from m in _context.Matches
                              join ht in _context.Teams on m.HomeTeamId equals ht.TeamId
                              join at in _context.Teams on m.AwayTeamId equals at.TeamId
                              join mp in _context.MatchPredictions.Where(x => x.UserId == request.UserId) on m.MatchId
                              equals mp.MatchId into matchPreds from mp in matchPreds.DefaultIfEmpty()
                              where m.MatchDate > gameweekStarts && m.MatchDate < gameweekEnds
                              let matchPredictionId = mp != null ? mp.MatchPredictionId : (Guid?)null
                              let homeTeamGoalPrediction = mp != null ? mp.HomeTeamGoalPrediction : null
                              let awayTeamGoalPrediction = mp != null ? mp.AwayTeamGoalPrediction : null 
                              select new MatchPredictionDto(mp.MatchPredictionId, m.HomeTeamGoals, m.AwayTeamGoals, ht.TeamName, 
                              at.TeamName, homeTeamGoalPrediction, awayTeamGoalPrediction, m.MatchDate)).ToList();
            return matches.OrderBy(x => x.MatchDate).ToList();
        }
    }
}
