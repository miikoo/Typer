using Dapper;
using MediatR;
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.Seasons.IsNextSeasonExist;

namespace Typer.Infrastructure.QueryHandlers.Seasons
{
    public class IsNextSeasonExistQueryHandler : IRequestHandler<IsNextSeasonExistQuery, SeasonDto>
    {
        private readonly IDbConnection _dbConnection;

        public IsNextSeasonExistQueryHandler(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<SeasonDto> Handle(IsNextSeasonExistQuery request, CancellationToken cancellationToken)
        {
            string sql = "SELECT COUNT(*) FROM Matches WHERE MatchDate > @CurrentDateTime";

            var parameters = new { CurrentDateTime = DateTime.UtcNow };

            int count = await _dbConnection.ExecuteScalarAsync<int>(sql, parameters);

            return new SeasonDto(count > 0);
        }
    }
}