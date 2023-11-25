using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using MediatR;
using Typer.Application.Queries.Gameweeks.GetCurrentSeasonGameweeks;

namespace Typer.Infrastructure.QueryHandlers.Gameweeks
{
    public class GetCurrentSeasonGameweeksQueryHandler : IRequestHandler<GetCurrentSeasonGameweeksQuery, List<GameweekDto>>
    {
        private readonly IDbConnection _dbConnection;

        public GetCurrentSeasonGameweeksQueryHandler(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<List<GameweekDto>> Handle(GetCurrentSeasonGameweeksQuery request, CancellationToken cancellationToken)
        {
            const string currentSeasonQuery = @"
                SELECT s.SeasonId
                FROM Matches m
                JOIN Gameweeks g ON m.GameweekId = g.GameweekId
                JOIN Seasons s ON g.SeasonId = s.SeasonId
                WHERE m.MatchDate > @CurrentDate
                ORDER BY m.MatchDate
                LIMIT 1
            ";

            var seasonId = await _dbConnection.QueryFirstOrDefaultAsync<string>(currentSeasonQuery, new { CurrentDate = DateTime.UtcNow });
            
            const string gameweeksQuery = @"
                SELECT g.GameweekId, g.GameweekNumber
                FROM Gameweeks g
                WHERE g.SeasonId = @SeasonId
                ORDER BY g.GameweekNumber
            ";

            return (await _dbConnection.QueryAsync<GameweekDto>(gameweeksQuery, new { SeasonId = seasonId })).ToList();
        }
    }
}