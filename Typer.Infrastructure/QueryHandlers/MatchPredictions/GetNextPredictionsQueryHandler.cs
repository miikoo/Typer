using Dapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.MatchPredictions.GetNextPredictions;

namespace Typer.Infrastructure.QueryHandlers.MatchPredictions
{
    public class GetNextPredictionsQueryHandler : IRequestHandler<GetNextPredictionsQuery, List<MatchPredictionDto>>
    {
        private readonly IDbConnection _dbConnection;

        public GetNextPredictionsQueryHandler(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<List<MatchPredictionDto>> Handle(GetNextPredictionsQuery request, CancellationToken cancellationToken)
        {
            string sql = @"
                SELECT TOP (@NumOfPredictions) mp.MatchPredictionId, m.HomeTeamGoals, m.AwayTeamGoals, ht.TeamName AS HomeTeamName,
                at.TeamName AS AwayTeamName, mp.HomeTeamGoalPrediction, mp.AwayTeamGoalPrediction, m.MatchDate
                FROM Matches m
                JOIN Teams ht ON m.HomeTeamId = ht.TeamId
                JOIN Teams at ON m.AwayTeamId = at.TeamId
                LEFT JOIN MatchPredictions mp ON m.MatchId = mp.MatchId AND mp.UserId = @UserId
                WHERE m.MatchDate > @CurrentDate
                ORDER BY m.MatchDate";

            var parameters = new
            {
                UserId = request.UserId,
                CurrentDate = DateTime.UtcNow,
                NumOfPredictions = request.NumOfPredictions
            };

            var result = await _dbConnection.QueryAsync<MatchPredictionDto>(sql, parameters);

            return result.AsList();
        }
    }
}