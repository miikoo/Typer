using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.MatchPredictions.GetCurrentGameweekPredictions;

namespace Typer.Infrastructure.QueryHandlers.MatchPredictions
{
    public class GetCurrentGameweekPredictionsQueryHandler : IRequestHandler<GetCurrentGameweekPredictionsQuery, List<MatchPredictionDto>>
    {
        private readonly TyperContext _context;

        public GetCurrentGameweekPredictionsQueryHandler(TyperContext context)
        {
            _context = context;
        }

        public async Task<List<MatchPredictionDto>> Handle(GetCurrentGameweekPredictionsQuery request, CancellationToken cancellationToken)
        {

            var currentGameweek = await (from m in _context.Matches
                                 where m.MatchDate > DateTime.UtcNow
                                 join g in _context.Gameweeks on m.GameweekId equals g.GameweekId
                                 orderby m.MatchDate
                                 select g).FirstAsync();
            var firstCurrentGameweekMatchDate = await (from g in _context.Gameweeks
                                                       where g.GameweekId == currentGameweek.GameweekId
                                                       join m in _context.Matches on g.GameweekId equals m.GameweekId
                                                       orderby m.MatchDate
                                                       select m.MatchDate).FirstAsync();
            var  lastCurrentGameweekMatchDate = await (from g in _context.Gameweeks
                                                       where g.GameweekId == currentGameweek.GameweekId 
                                                       join m in _context.Matches on g.GameweekId equals m.GameweekId
                                                       orderby m.MatchDate
                                                       select m.MatchDate).LastAsync();
            var lastPastGameweekMatchDate = await (from g in _context.Gameweeks
                                                   where g.GameweekNumber == currentGameweek.GameweekNumber-1 && g.SeasonId == currentGameweek.SeasonId
                                                   join m in _context.Matches on g.GameweekId equals m.GameweekId
                                                   orderby m.MatchDate
                                                   select m.MatchDate).LastOrDefaultAsync();
            var firstNextGameweekMatchDate = await (from g in _context.Gameweeks
                                                    where g.GameweekNumber == currentGameweek.GameweekNumber+1 && g.SeasonId == currentGameweek.SeasonId
                                                    join m in _context.Matches on g.GameweekId equals m.GameweekId
                                                    orderby m.MatchDate
                                                    select m.MatchDate).FirstOrDefaultAsync();
            var gameweekStarts = firstCurrentGameweekMatchDate.AddSeconds(-((firstCurrentGameweekMatchDate - lastPastGameweekMatchDate).TotalSeconds / 2));
            var gameweekEnds = lastCurrentGameweekMatchDate.AddSeconds((firstNextGameweekMatchDate - lastCurrentGameweekMatchDate).TotalSeconds / 2);

            var matches = (from m in _context.Matches
                           join ht in _context.Teams on m.HomeTeamId equals ht.TeamId
                           join at in _context.Teams on m.AwayTeamId equals at.TeamId
                           join mp in _context.MatchPredictions.Where(x => x.UserId == request.UserId) on m.MatchId
                           equals mp.MatchId into matchPreds
                           from mp in matchPreds.DefaultIfEmpty()
                           where m.MatchDate > gameweekStarts && m.MatchDate < gameweekEnds
                           let matchPredictionId = mp != null ? mp.MatchPredictionId : (Guid?)null
                           let homeTeamGoalPrediction = mp != null ? mp.HomeTeamGoalPrediction : null
                           let awayTeamGoalPrediction = mp != null ? mp.AwayTeamGoalPrediction : null
                           select new MatchPredictionDto(mp.MatchPredictionId, m.HomeTeamGoals, m.AwayTeamGoals, ht.TeamName,
                           at.TeamName, homeTeamGoalPrediction, awayTeamGoalPrediction, m.MatchDate, m.GameweekId)).ToList();
            return matches.OrderBy(x => x.MatchDate).ToList();
        }
    }
}
