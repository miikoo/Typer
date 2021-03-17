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
            var matches = await (from m in _context.Matches
                           join ht in _context.Teams on m.HomeTeamId equals ht.TeamId
                           join at in _context.Teams on m.AwayTeamId equals at.TeamId
                           join mp in _context.MatchPredictions.Where(x => x.UserId == request.UserId) on m.MatchId
                           equals mp.MatchId into matchPreds
                           from mp in matchPreds.DefaultIfEmpty()
                           where m.MatchDate > DateTime.UtcNow && m.MatchDate < DateTime.UtcNow.AddDays(7)
                           let matchPredictionId = mp != null ? mp.MatchPredictionId : (Guid?)null
                           let homeTeamGoalPrediction = mp != null ? mp.HomeTeamGoalPrediction : null
                           let awayTeamGoalPrediction = mp != null ? mp.AwayTeamGoalPrediction : null
                           select new MatchPredictionDto(mp.MatchPredictionId, m.HomeTeamGoals, m.AwayTeamGoals, ht.TeamName,
                           at.TeamName, homeTeamGoalPrediction, awayTeamGoalPrediction, m.MatchDate)).ToListAsync();
            return matches.OrderBy(x => x.MatchDate).ToList();
        }
    }
}
