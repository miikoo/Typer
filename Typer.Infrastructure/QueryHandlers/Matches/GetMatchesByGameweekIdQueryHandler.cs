using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using MediatR;
using Typer.Application.Queries.Matches.GetMatchesByGameweekId;

namespace Typer.Infrastructure.QueryHandlers.Matches
{
    public class GetMatchesByGameweekIdQueryHandler : IRequestHandler<GetMatchesByGameweekIdQuery, List<MatchDto>>
    {
        private readonly IDbConnection _dbConnection;

        public GetMatchesByGameweekIdQueryHandler(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<List<MatchDto>> Handle(GetMatchesByGameweekIdQuery request, CancellationToken cancellationToken)
        {
            const string query = @"
                SELECT m.MatchId, m.HomeTeamGoals, m.AwayTeamGoals, m.MatchDate, 
                       ht.TeamName AS HomeTeamName, at.TeamName AS AwayTeamName
                FROM Matches AS m
                INNER JOIN Teams AS at ON m.AwayTeamId = at.TeamId
                INNER JOIN Teams AS ht ON m.HomeTeamId = ht.TeamId
                WHERE m.GameweekId = @GameweekId
                ORDER BY m.MatchDate
            ";

            return (await _dbConnection.QueryAsync<MatchDto>(query, new { GameweekId = request.GameweekId })).ToList();
        }
    }
}