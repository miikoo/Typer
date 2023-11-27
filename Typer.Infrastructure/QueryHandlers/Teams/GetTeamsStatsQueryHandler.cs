using Dapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.Teams.GetTeamsStats;
using Typer.Infrastructure.Entities;

namespace Typer.Infrastructure.QueryHandlers.Teams
{
    public class GetTeamsStatsQueryHandler : IRequestHandler<GetTeamsStatsQuery, List<TeamStats>>
    {
        private readonly IDbConnection _dbConnection;

        public GetTeamsStatsQueryHandler(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<List<TeamStats>> Handle(GetTeamsStatsQuery request, CancellationToken cancellationToken)
        {
            var result = new List<TeamStats>();

            string matchesQuery = "SELECT * " +
                                  "FROM Matches " +
                                  "WHERE MatchDate < @CurrentDate";

            string gameweekMatchesQuery = "SELECT MatchId, HomeTeamId, AwayTeamId, HomeTeamGoals, AwayTeamGoals " +
                                         "FROM Matches " +
                                         "WHERE GameweekId = @GameweekId";

            string allTeamsQuery = "SELECT TeamId, TeamName FROM Teams";
            
            var matches = await _dbConnection.QueryAsync<DbMatch>(matchesQuery, new { CurrentDate = DateTime.UtcNow });
            var gameweekId = matches.First().GameweekId;
            var gameweekMatches = await _dbConnection.QueryAsync<DbMatch>(gameweekMatchesQuery, new { GameweekId = gameweekId });
            var allTeams = await _dbConnection.QueryAsync<DbTeam>(allTeamsQuery);

            var teams = allTeams.Where(team =>
                gameweekMatches.Any(m => m.HomeTeamId == team.TeamId || m.AwayTeamId == team.TeamId)
            );

            foreach (var team in teams)
            {
                var mh = matches.Where(m => m.HomeTeamId == team.TeamId).ToList();
                var ma = matches.Where(m => m.AwayTeamId == team.TeamId).ToList();

                var scoredGoals = mh.Sum(m => m.HomeTeamGoals ?? 0) + ma.Sum(m => m.AwayTeamGoals ?? 0);
                var concededGoals = mh.Sum(m => m.AwayTeamGoals ?? 0) + ma.Sum(m => m.HomeTeamGoals ?? 0);

                var winsAH = mh.Count(m => m.HomeTeamGoals > m.AwayTeamGoals);
                var winsAA = ma.Count(m => m.AwayTeamGoals > m.HomeTeamGoals);
                var wins = winsAA + winsAH;

                var draws = mh.Concat(ma).Count(m => m.HomeTeamGoals == m.AwayTeamGoals && m.HomeTeamGoals != null);

                var losses = mh.Count() + ma.Count() - wins - draws - mh.Concat(ma).Count(m => m.HomeTeamGoals == null);

                result.Add(new TeamStats(team.TeamId, team.TeamName, scoredGoals, concededGoals, wins * 3 + draws, wins, draws, losses));
            }

            return result.OrderByDescending(x => x.Points).ThenByDescending(x => x.ScoredGoals - x.ConcededGoals)
                .ThenByDescending(x => x.ScoredGoals).ToList();
        }
    }
}
