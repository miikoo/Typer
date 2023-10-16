using Dapper;
using MediatR;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.Teams.GetTeamsQuery;

namespace Typer.Infrastructure.QueryHandlers.Teams
{
    public class GetTeamsQueryHandler : IRequestHandler<GetTeamsQuery, List<TeamDto>>
    {
        private readonly IDbConnection _dbConnection;

        public GetTeamsQueryHandler(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<List<TeamDto>> Handle(GetTeamsQuery request, CancellationToken cancellationToken)
        {
            string sql = "SELECT TeamId, TeamName FROM Teams";

            var teams = await _dbConnection.QueryAsync<TeamDto>(sql);
            return teams.AsList();
        }
    }
}