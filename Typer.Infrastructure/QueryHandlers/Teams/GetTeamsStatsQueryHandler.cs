using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using Typer.Application.Queries.Teams.GetTeamsStats;
using System;
using Microsoft.EntityFrameworkCore;
using Typer.Infrastructure.Entities;

namespace Typer.Infrastructure.QueryHandlers.Teams
{
    public class GetTeamsStatsQueryHandler : IRequestHandler<GetTeamsStatsQuery, List<TeamStats>>
    {
        private readonly TyperContext _context;

        public GetTeamsStatsQueryHandler(TyperContext context)
        {
            _context = context;
        }

        public async Task<List<TeamStats>> Handle(GetTeamsStatsQuery request, CancellationToken cancellationToken)
        {
            var result = new List<TeamStats>();

            var seasonId = await (from m in _context.Matches
                                  where m.MatchDate > DateTime.UtcNow
                                  join cg in _context.Gameweeks on m.GameweekId equals cg.GameweekId
                                  join s in _context.Seasons on cg.SeasonId equals s.SeasonId
                                  orderby m.MatchDate
                                  select s.SeasonId).FirstAsync();

            var matches = await (from m in _context.Matches
                                 join g in _context.Gameweeks on seasonId equals g.SeasonId
                                 where m.GameweekId == g.GameweekId
                                 select m).ToListAsync();

            var GameweekMatches = await (from m in _context.Matches
                                         join g in _context.Gameweeks on seasonId equals g.SeasonId
                                         where g.GameweekId == m.GameweekId && g.GameweekNumber == 3
                                         select m).ToListAsync();

            var allTeams = await (from t in _context.Teams select t).ToListAsync();
            List<DbTeam> teams = new List<DbTeam>();
            foreach (var team in allTeams)
                if (GameweekMatches.Where(x => x.HomeTeamId == team.TeamId || x.AwayTeamId == team.TeamId).Any())
                    teams.Add(team);


            foreach (var team in teams)
            {
                var mh =  (from m in matches where team.TeamId == m.HomeTeamId select m).ToList();
                var ma = (from m in matches where team.TeamId == m.AwayTeamId select m).ToList();

                var scoredGoals = (from m in mh select m.HomeTeamGoals).Sum() + (from m in ma select m.AwayTeamGoals).Sum();
                var concededGoals = (from m in mh select m.AwayTeamGoals).Sum() + (from m in ma select m.HomeTeamGoals).Sum();

                var winsAH = (from m in mh where m.HomeTeamGoals > m.AwayTeamGoals select m).Count();
                var winsAA = (from m in ma where m.AwayTeamGoals > m.HomeTeamGoals select m).Count();
                var wins = winsAA + winsAH;

                var draws = (from m in mh.Concat(ma) where m.HomeTeamGoals == m.AwayTeamGoals && m.HomeTeamGoals != null select m).Count();

                var losses = mh.Count() + ma.Count() - wins - draws - (from m in mh.Concat(ma) where m.HomeTeamGoals == null select m).Count();

                result.Add(new TeamStats(team.TeamId, team.TeamName, scoredGoals, concededGoals, wins*3+draws, wins, draws, losses));
            }

            return result.OrderByDescending(x => x.Points).ThenByDescending(x => x.ScoredGoals - x.ConcededGoals)
                .ThenByDescending(x => x.ScoredGoals).ToList();
        }
    }
}
