using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using MediatR;
using Typer.Application.Queries.Gameweeks.GetGameweeksBySeasonId;

namespace Typer.Infrastructure.QueryHandlers.Gameweeks
{
    public class GetGameweeksBySeasonIdQueryHandler : IRequestHandler<GetGameweeksBySeasonIdQuery, List<GameweekDto>>
    {
        private readonly IDbConnection _dbConnection;

        public GetGameweeksBySeasonIdQueryHandler(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<List<GameweekDto>> Handle(GetGameweeksBySeasonIdQuery request, CancellationToken cancellationToken)
        {
            const string query = @"
                SELECT GameweekId, GameweekNumber
                FROM Gameweeks
                WHERE SeasonId = @SeasonId
                ORDER BY GameweekNumber
            ";

            return (await _dbConnection.QueryAsync<GameweekDto>(query, new { SeasonId = request.SeasonId })).ToList();
        }
    }
}