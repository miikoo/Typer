using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using Typer.Application.Queries.User.GetUsersPoints;

namespace Typer.Infrastructure.QueryHandlers.User
{
    public class GetUsersPointsQueryHandler : IRequestHandler<GetUsersPointsQuery, List<UserPointsDto>>
    {
        private readonly TyperContext _context;

        public GetUsersPointsQueryHandler(TyperContext context)
        {
            _context = context;
        }

        public async Task<List<UserPointsDto>> Handle(GetUsersPointsQuery request, CancellationToken cancellationToken)
        {
            var seasonId = await(from m in _context.Matches
                                 where m.MatchDate > DateTime.UtcNow
                                 join cg in _context.Gameweeks on m.GameweekId equals cg.GameweekId
                                 join s in _context.Seasons on cg.SeasonId equals s.SeasonId
                                 orderby m.MatchDate
                                 select s.SeasonId).FirstAsync();

            var users = await (from u in _context.Users select new { 
                Username=u.Username,
                UserId=u.UserId
            }).ToListAsync();

            var result = new List<UserPointsDto>();
            foreach (var user in users)
            {
                var exactPredictions  = await (from mp in _context.MatchPredictions
                                   join m in _context.Matches on mp.MatchId equals m.MatchId
                                   join s in _context.Seasons on seasonId equals s.SeasonId
                                   where mp.UserId == user.UserId && s.SeasonId == seasonId && m.HomeTeamGoals != null
                                   && m.AwayTeamGoals != null &&
                                   mp.HomeTeamGoalPrediction == m.HomeTeamGoals && mp.AwayTeamGoalPrediction == m.AwayTeamGoals
                                   select m.MatchId).CountAsync() * 2;

                var winnerPredictions = await (from mp in _context.MatchPredictions
                                            join m in _context.Matches on mp.MatchId equals m.MatchId
                                            join s in _context.Seasons on seasonId equals s.SeasonId
                                            where mp.UserId == user.UserId && s.SeasonId == seasonId && m.HomeTeamGoals != null
                                            && m.AwayTeamGoals != null &&
                                            ((mp.HomeTeamGoalPrediction > mp.AwayTeamGoalPrediction && m.HomeTeamGoals > m.AwayTeamGoals) ||
                                            (mp.HomeTeamGoalPrediction < mp.AwayTeamGoalPrediction && m.HomeTeamGoals < m.AwayTeamGoals) ||
                                            (mp.HomeTeamGoalPrediction == mp.AwayTeamGoalPrediction && m.HomeTeamGoals == m.AwayTeamGoals))
                                            select m.MatchId).CountAsync() - exactPredictions;

                var incorrectPredictions = await (from mp in _context.MatchPredictions
                                                  join m in _context.Matches on mp.MatchId equals m.MatchId
                                                  join s in _context.Seasons on seasonId equals s.SeasonId
                                                  where mp.UserId == user.UserId && s.SeasonId == seasonId && m.HomeTeamGoals != null
                                                  && m.AwayTeamGoals != null && mp.HomeTeamGoalPrediction != null &&
                                                  mp.AwayTeamGoalPrediction !=null
                                                  select m.MatchId).CountAsync() - exactPredictions - winnerPredictions;

                result.Add(new UserPointsDto(exactPredictions * 3+ winnerPredictions, user.Username, exactPredictions, incorrectPredictions,
                    winnerPredictions));
            }
            return result.OrderByDescending(x => x.Points).ThenByDescending(x => x.ExactPredictions)
                .ThenByDescending(x => x.WinnerPredictions).ToList();
        }
    }
}
