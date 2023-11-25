using Dapper;
using MediatR;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System;
using Typer.Application.Queries.Users.GetUsersPoints;
using System.Linq;

namespace Typer.Infrastructure.QueryHandlers.User
{
    public class GetUsersPointsQueryHandler : IRequestHandler<GetUsersPointsQuery, List<UserPointsDto>>
    {
        private readonly IDbConnection _dbConnection;

        public GetUsersPointsQueryHandler(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<List<UserPointsDto>> Handle(GetUsersPointsQuery request, CancellationToken cancellationToken)
        {
            var seasonId = await _dbConnection.QueryFirstOrDefaultAsync<string>(
                "SELECT s.SeasonId " +
                "FROM Matches m " +
                "INNER JOIN Gameweeks g ON m.GameweekId = g.GameweekId " +
                "INNER JOIN Seasons s ON g.SeasonId = s.SeasonId " +
                "WHERE m.MatchDate > @CurrentDate " +
                "ORDER BY m.MatchDate", new { CurrentDate = DateTime.UtcNow });

            var users = await _dbConnection.QueryAsync(
                "SELECT Username, UserId FROM Users");

            var result = new List<UserPointsDto>();

            foreach (var user in users)
            {
                var sql = "SELECT COUNT(mp.MatchId) " +
                          "FROM MatchPredictions mp " +
                          "INNER JOIN Matches m ON mp.MatchId = m.MatchId " +
                          "inner join Gameweeks g on g.gameweekId = m.GameweekId " +
                          "INNER JOIN Seasons s ON g.SeasonId = s.SeasonId " +
                          "WHERE mp.UserId = @UserId " +
                          "AND s.SeasonId = @SeasonId " +
                          "AND m.HomeTeamGoals IS NOT NULL " +
                          "AND mp.AwayTeamGoalPrediction IS NOT NULL " +
                          "AND mp.HomeTeamGoalPrediction IS NOT NULL " +
                          "AND mp.HomeTeamGoalPrediction = m.HomeTeamGoals " +
                          "AND mp.AwayTeamGoalPrediction = m.AwayTeamGoals";

                var exactPredictions = await _dbConnection.ExecuteScalarAsync<int>(sql,
                    new { UserId = user.UserId, SeasonId = seasonId });

                var winnerPredictions = await _dbConnection.ExecuteScalarAsync<int>(
                    "SELECT COUNT(mp.MatchId) - @ExactPredictions " +
                    "FROM MatchPredictions mp " +
                    "INNER JOIN Matches m ON mp.MatchId = m.MatchId " +
                    "inner join Gameweeks g on g.gameweekId = m.GameweekId " +
                    "INNER JOIN Seasons s ON g.SeasonId = s.SeasonId " +
                    "WHERE mp.UserId = @UserId " +
                    "AND s.SeasonId = @SeasonId " +
                    "AND m.HomeTeamGoals IS NOT NULL " +
                    "AND mp.AwayTeamGoalPrediction IS NOT NULL " +
                    "AND mp.HomeTeamGoalPrediction IS NOT NULL " +
                    "AND ((mp.HomeTeamGoalPrediction > mp.AwayTeamGoalPrediction " +
                    "AND m.HomeTeamGoals > m.AwayTeamGoals) OR " +
                    "(mp.HomeTeamGoalPrediction < mp.AwayTeamGoalPrediction " +
                    "AND m.HomeTeamGoals < m.AwayTeamGoals) OR " +
                    "(mp.HomeTeamGoalPrediction = mp.AwayTeamGoalPrediction " +
                    "AND m.HomeTeamGoals = m.AwayTeamGoals))",
                    new { UserId = user.UserId, SeasonId = seasonId, ExactPredictions = exactPredictions });

                var incorrectPredictions = await _dbConnection.ExecuteScalarAsync<int>(
                    "SELECT COUNT(mp.MatchId) - @ExactPredictions - @WinnerPredictions " +
                    "FROM MatchPredictions mp " +
                    "INNER JOIN Matches m ON mp.MatchId = m.MatchId " +
                    "inner join Gameweeks g on g.gameweekId = m.GameweekId " +
                    "INNER JOIN Seasons s ON g.SeasonId = s.SeasonId " +
                    "WHERE mp.UserId = @UserId " +
                    "AND s.SeasonId = @SeasonId " +
                    "AND m.HomeTeamGoals IS NOT NULL " +
                    "AND m.AwayTeamGoals IS NOT NULL " +
                    "AND mp.AwayTeamGoalPrediction IS NOT NULL " +
                    "AND mp.HomeTeamGoalPrediction IS NOT NULL",
                    new { UserId = user.UserId, SeasonId = seasonId, ExactPredictions = exactPredictions, WinnerPredictions = winnerPredictions });

                result.Add(new UserPointsDto(exactPredictions * 3 + winnerPredictions, user.Username, exactPredictions, incorrectPredictions, winnerPredictions));
            }

            return result.OrderByDescending(x => x.Points).ThenByDescending(x => x.ExactPredictions).ThenBy(x => x.IncorrectPredictions).ToList();
        }
    }
}
