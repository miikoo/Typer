using Dapper;
using MediatR;
using Microsoft.Extensions.Logging;
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
        readonly ILogger<GetSeasonsQueryHandler> _log;

        public GetSeasonsQueryHandler(IDbConnection dbConnection, ILogger<GetSeasonsQueryHandler> log)
        {
            _dbConnection = dbConnection;
            _log = log;
        }

        public async Task<List<SeasonDto>> Handle(GetSeasonsQuery request, CancellationToken cancellationToken)
        {
            string sql = "SELECT SeasonId, StartYear, EndYear FROM Seasons";
            _log.LogInformation("Hello, world!");
            var result = await _dbConnection.QueryAsync<SeasonDto>(sql);

            return result.AsList();
        }
    }
}