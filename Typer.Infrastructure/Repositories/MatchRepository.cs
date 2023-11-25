using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using Typer.Domain.Interfaces.Repositories;
using Typer.Domain.Models;
using Typer.Infrastructure.Entities;

namespace Typer.Infrastructure.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        private readonly IDbConnection _dbConnection;

        public MatchRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task CreateAsync(params Match[] matches)
        {
            const string insertQuery = "INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId) " +
                                      "VALUES (@MatchId, @HomeTeamGoals, @AwayTeamGoals, @MatchDate, @HomeTeamId, @AwayTeamId, @GameweekId)";

            await _dbConnection.ExecuteAsync(insertQuery, matches.Select(x => DbMatch.Create(x)));
        }

        public async Task DeleteAsync(string matchId)
        {
            const string deleteQuery = "DELETE FROM Matches WHERE MatchId = @MatchId";
            await _dbConnection.ExecuteAsync(deleteQuery, new { MatchId = matchId });
        }

        public async Task<Match> GetByIdAsync(string matchId)
        {
            const string selectQuery = "SELECT * FROM Matches WHERE MatchId = @MatchId";
            return await _dbConnection.QueryFirstOrDefaultAsync<Match>(selectQuery, new { MatchId = matchId });
        }

        public async Task<List<Match>> GetAsync(string gameweekId)
        {
            const string selectQuery = "SELECT * FROM Matches WHERE GameweekId = @GameweekId";
            return (await _dbConnection.QueryAsync<Match>(selectQuery, new { GameweekId = gameweekId })).ToList();
        }

        public async Task UpdateAsync(params Match[] matches)
        {
            const string updateQuery = "UPDATE Matches " +
                                      "SET HomeTeamGoals = @HomeTeamGoals, " +
                                      "AwayTeamGoals = @AwayTeamGoals, " +
                                      "MatchDate = @MatchDate " +
                                      "WHERE MatchId = @MatchId";

            foreach (var match in matches)
            {
                await _dbConnection.ExecuteAsync(updateQuery, match);
            }
        }
    }
}
