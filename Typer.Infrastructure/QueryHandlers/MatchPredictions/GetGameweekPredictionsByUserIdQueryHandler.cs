using Dapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.MatchPredictions.GetGameweekPredictionsByUserId;

namespace Typer.Infrastructure.QueryHandlers.MatchPredictions
{
    public class GetGameweekPredictionsByUserIdQueryHandler : IRequestHandler<GetGameweekPredictionsByUserIdQuery, List<MatchPredictionDto>>
    {
        private readonly IDbConnection _dbConnection;

        public GetGameweekPredictionsByUserIdQueryHandler(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<List<MatchPredictionDto>> Handle(GetGameweekPredictionsByUserIdQuery request, CancellationToken cancellationToken)
        {
            string sql = @"
                SELECT mp.MatchPredictionId, m.HomeTeamGoals, m.AwayTeamGoals, ht.TeamName AS HomeTeamName,
                at.TeamName AS AwayTeamName, mp.HomeTeamGoalPrediction HomeTeamGoalsPrediction, mp.AwayTeamGoalPrediction AwayTeamGoalsPrediction, m.MatchDate
                FROM Matches m
                JOIN Teams ht ON m.HomeTeamId = ht.TeamId
                JOIN Teams at ON m.AwayTeamId = at.TeamId
                LEFT JOIN MatchPredictions mp ON m.MatchId = mp.MatchId AND mp.UserId = @UserId
                WHERE m.GameweekId = @GameweekId
                ORDER BY m.MatchDate";

            var parameters = new { UserId = request.UserId, GameweekId = request.GameweekId };

            var result = await _dbConnection.QueryAsync<MatchPredictionDto>(sql, parameters);

            return result.AsList();
        }
    }
}