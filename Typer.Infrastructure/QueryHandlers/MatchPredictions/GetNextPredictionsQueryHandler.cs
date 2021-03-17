using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.MatchPredictions.GetNextPredictions;

namespace Typer.Infrastructure.QueryHandlers.MatchPredictions
{
    public class GetNextPredictionsQueryHandler : IRequestHandler<GetNextPredictionsQuery, List<MatchPredictionDto>>
    {
        private readonly TyperContext _context;

        public GetNextPredictionsQueryHandler(TyperContext context)
        {
            _context = context;
        }

        public async Task<List<MatchPredictionDto>> Handle(GetNextPredictionsQuery request, CancellationToken cancellationToken)
            => await (from m in _context.Matches
                      join at in _context.Teams on m.AwayTeamId equals at.TeamId
                      join ht in _context.Teams on m.HomeTeamId equals ht.TeamId
                      join matchPred in _context.MatchPredictions.Where(x => x.UserId == request.UserId)
                      on m.MatchId equals matchPred.MatchId into matchPreds
                      from mp in matchPreds.DefaultIfEmpty()
                      where m.MatchDate > DateTime.UtcNow
                      let matchPredictionId = mp != null ? mp.MatchPredictionId : (Guid?)null
                      let homeTeamGoalPrediction = mp != null ? mp.HomeTeamGoalPrediction : null
                      let awayTeamGoalPrediction = mp != null ? mp.AwayTeamGoalPrediction : null
                      orderby m.MatchDate
                      select new MatchPredictionDto(mp.MatchPredictionId, m.HomeTeamGoals, m.AwayTeamGoals, ht.TeamName,
                      at.TeamName, homeTeamGoalPrediction, awayTeamGoalPrediction, m.MatchDate))
            .Take(request.NumOfPredictions).ToListAsync();
    }
}
