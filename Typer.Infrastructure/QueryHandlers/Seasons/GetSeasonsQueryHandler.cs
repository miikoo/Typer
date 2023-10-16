using Dapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Typer.API.Queries.Seasons.GetSeasonQuery;

namespace Typer.Infrastructure.QueryHandlers.Seasons
{
    public class GetSeasonsQueryHandler : IRequestHandler<GetSeasonsQuery, List<SeasonDto>>
    {
        private readonly IDbConnection _dbConnection;

        public GetSeasonsQueryHandler(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<List<SeasonDto>> Handle(GetSeasonsQuery request, CancellationToken cancellationToken)
        {
            string sql = "SELECT SeasonId, StartYear, EndYear FROM Seasons";

            var result = await _dbConnection.QueryAsync<SeasonDto>(sql);

            return result.AsList();
        }
    }
}