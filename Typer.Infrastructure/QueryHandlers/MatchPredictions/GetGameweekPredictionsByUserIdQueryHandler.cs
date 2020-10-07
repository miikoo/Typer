using MediatR;
using Microsoft.EntityFrameworkCore;
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
            => await (from mp in _context.MatchPredictions
                      join m in _context.Matches on new { request.GameweekId, mp.MatchId } equals new { m.GameweekId, m.MatchId }
                      join at in _context.Teams on m.AwayTeamId equals at.TeamId
                      join ht in _context.Teams on m.HomeTeamId equals ht.TeamId
                      where mp.UserId == request.UserId && m.GameweekId == request.GameweekId
                      select new MatchPredictionDto(mp.MatchPredictionId, m.HomeTeamGoals, m.AwayTeamGoals, ht.TeamName, at.TeamName,
                          mp.HomeTeamGoalPrediction, mp.AwayTeamGoalPrediction, m.MatchDate)).ToListAsync();
    }
}
