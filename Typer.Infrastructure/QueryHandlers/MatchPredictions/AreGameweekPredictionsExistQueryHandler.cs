using Dapper;
using MediatR;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.MatchPredictions.AreGameweekPredictionsExist;

namespace Typer.Infrastructure.QueryHandlers.MatchPredictions
{
    public class AreGameweekPredictionsExistQueryHandler : IRequestHandler<AreGameweekPredictionsExistQuery, MatchPredictionDto>
    {
        private readonly IDbConnection _connection;

        public AreGameweekPredictionsExistQueryHandler(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<MatchPredictionDto> Handle(AreGameweekPredictionsExistQuery request, CancellationToken cancellationToken)
        {
            var query = @"
                SELECT count(*)
                FROM MatchPredictions AS mp
                JOIN Matches AS m ON mp.MatchId = m.MatchId AND m.GameweekId = @GameweekId
                WHERE mp.UserId = @UserId";

            var result = await _connection.ExecuteScalarAsync<int>(query, new { request.GameweekId, request.UserId });

            return new MatchPredictionDto(result > 0);
        }
    }
}