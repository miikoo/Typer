using Dapper;
using MediatR;
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.Users.GetUserPoints;

namespace Typer.Infrastructure.QueryHandlers.User
{
    public class GetUserPointsQueryHandler : IRequestHandler<GetUserPointsQuery, UserPointsDto>
    {
        private readonly IDbConnection _dbConnection;

        public GetUserPointsQueryHandler(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<UserPointsDto> Handle(GetUserPointsQuery request, CancellationToken cancellationToken)
        {
            var sql = "SELECT s.SeasonId " +
                "FROM Matches m " +
                "INNER JOIN Gameweeks g ON m.GameweekId = g.GameweekId " +
                "INNER JOIN Seasons s ON g.SeasonId = s.SeasonId " +
                "WHERE m.MatchDate > @CurrentDate " +
                "ORDER BY m.MatchDate";

            var seasonId = await _dbConnection.QueryFirstOrDefaultAsync<string>(sql, new { CurrentDate = DateTime.UtcNow });

            var points = await _dbConnection.QueryFirstAsync<int>(
                "SELECT " +
                "   (SELECT COUNT(mp.MatchId) " +
                "    FROM MatchPredictions mp " +
                "    INNER JOIN Matches m ON mp.MatchId = m.MatchId " +
                "    INNER JOIN Seasons s ON m.SeasonId = s.SeasonId " +
                "    WHERE mp.UserId = @UserId AND s.SeasonId = @SeasonId " +
                "    AND m.HomeTeamGoals IS NOT NULL AND m.AwayTeamGoals IS NOT NULL " +
                "    AND ((mp.HomeTeamGoalPrediction > mp.AwayTeamGoalPrediction " +
                "          AND m.HomeTeamGoals > m.AwayTeamGoals) OR " +
                "         (mp.HomeTeamGoalPrediction < mp.AwayTeamGoalPrediction " +
                "          AND m.HomeTeamGoals < m.AwayTeamGoals) OR " +
                "         (mp.HomeTeamGoalPrediction = mp.AwayTeamGoalPrediction " +
                "          AND m.HomeTeamGoals = m.AwayTeamGoals))) " +
                "   +" +
                "   (SELECT COUNT(mp.MatchId) * 2 " +
                "    FROM MatchPredictions mp " +
                "    INNER JOIN Matches m ON mp.MatchId = m.MatchId " +
                "    INNER JOIN Seasons s ON m.SeasonId = s.SeasonId " +
                "    WHERE mp.UserId = @UserId AND s.SeasonId = @SeasonId " +
                "    AND m.HomeTeamGoals IS NOT NULL AND m.AwayTeamGoals IS NOT NULL " +
                "    AND mp.HomeTeamGoalPrediction = m.HomeTeamGoals " +
                "    AND mp.AwayTeamGoalPrediction = m.AwayTeamGoals)",
                new { UserId = request.UserId, SeasonId = seasonId });

            return new UserPointsDto(points);
        }
    }
}
