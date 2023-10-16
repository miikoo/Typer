using Dapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.MatchPredictions.GetCurrentGameweekPredictions;

namespace Typer.Infrastructure.QueryHandlers.MatchPredictions
{
    public class GetCurrentGameweekPredictionsQueryHandler : IRequestHandler<GetCurrentGameweekPredictionsQuery, List<MatchPredictionDto>>
    {
        private readonly IDbConnection _connection;

        public GetCurrentGameweekPredictionsQueryHandler(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<List<MatchPredictionDto>> Handle(GetCurrentGameweekPredictionsQuery request, CancellationToken cancellationToken)
        {
            var query = @"
                SELECT mp.MatchPredictionId, m.HomeTeamGoals, m.AwayTeamGoals, ht.TeamName AS HomeTeamName,
                    at.TeamName AS AwayTeamName, mp.HomeTeamGoalPrediction, mp.AwayTeamGoalPrediction, m.MatchDate
                FROM Matches AS m
                JOIN Teams AS ht ON m.HomeTeamId = ht.TeamId
                JOIN Teams AS at ON m.AwayTeamId = at.TeamId
                LEFT JOIN MatchPredictions AS mp ON m.MatchId = mp.MatchId AND mp.UserId = @UserId
                WHERE m.MatchDate > GETDATE() AND m.MatchDate < DATEADD(DAY, 7, GETDATE())";

            var parameters = new { UserId = request.UserId };
            var matches = await _connection.QueryAsync<MatchPredictionDto>(query, parameters);

            return matches.OrderBy(x => x.MatchDate).ToList();
        }
    }
}