using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.Users.GetUserPoints;

namespace Typer.Infrastructure.QueryHandlers.User
{
    public class GetUserPointsQueryHandler : IRequestHandler<GetUserPointsQuery, UserPointsDto>
    {
        private readonly TyperContext _context;

        public GetUserPointsQueryHandler(TyperContext context)
        {
            _context = context;
        }

        public async Task<UserPointsDto> Handle(GetUserPointsQuery request, CancellationToken cancellationToken)
        {
            var seasonId = await (from m in _context.Matches
                                  where m.MatchDate > DateTime.UtcNow
                                  join cg in _context.Gameweeks on m.GameweekId equals cg.GameweekId
                                  join s in _context.Seasons on cg.SeasonId equals s.SeasonId
                                  orderby m.MatchDate
                                  select s.SeasonId).FirstAsync();
            var points = await (from mp in _context.MatchPredictions
                                      join m in _context.Matches on mp.MatchId equals m.MatchId
                                      join s in _context.Seasons on seasonId equals s.SeasonId
                                      where mp.UserId == request.UserId && s.SeasonId == seasonId && m.HomeTeamGoals != null
                                      && m.AwayTeamGoals != null &&
                                      ((mp.HomeTeamGoalPrediction > mp.AwayTeamGoalPrediction && m.HomeTeamGoals > m.AwayTeamGoals) ||
                                      (mp.HomeTeamGoalPrediction < mp.AwayTeamGoalPrediction && m.HomeTeamGoals < m.AwayTeamGoals) ||
                                      (mp.HomeTeamGoalPrediction == mp.AwayTeamGoalPrediction && m.HomeTeamGoals == m.AwayTeamGoals))
                                      select m.MatchId).CountAsync() +
                                await (from mp in _context.MatchPredictions
                                       join m in _context.Matches on mp.MatchId equals m.MatchId
                                       join s in _context.Seasons on seasonId equals s.SeasonId
                                       where mp.UserId == request.UserId && s.SeasonId == seasonId && m.HomeTeamGoals != null
                                       && m.AwayTeamGoals != null &&
                                       mp.HomeTeamGoalPrediction == m.HomeTeamGoals && mp.AwayTeamGoalPrediction == m.AwayTeamGoals
                                       select m.MatchId).CountAsync() * 2;
            return new UserPointsDto(points);
        }
    }
}
