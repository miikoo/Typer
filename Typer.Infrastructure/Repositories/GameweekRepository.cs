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

namespace Typer.Infrastructure.Repositories
{
    public class GameweekRepository : IGameweekRepository
    {
        private readonly IDbConnection _dbConnection;

        public GameweekRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task CreateAsync(params Gameweek[] gameweeks)
        {
            const string insertQuery = "INSERT INTO Gameweeks (GameweekId, GameweekNumber, SeasonId) " +
                                      "VALUES (@GameweekId, @GameweekNumber, @SeasonId)";

            await _dbConnection.ExecuteAsync(insertQuery, gameweeks);
        }

        public async Task DeleteAsync(string gameweekId)
        {
            const string deleteQuery = "DELETE FROM Gameweeks WHERE GameweekId = @GameweekId";
            await _dbConnection.ExecuteAsync(deleteQuery, new { GameweekId = gameweekId });
        }

        public async Task<Gameweek> GetByIdAsync(string gameweekId)
        {
            const string selectQuery = "SELECT * FROM Gameweeks WHERE GameweekId = @GameweekId";
            return await _dbConnection.QueryFirstOrDefaultAsync<Gameweek>(selectQuery, new { GameweekId = gameweekId });
        }

        public async Task<List<Gameweek>> GetAsync(string seasonId)
        {
            const string selectQuery = "SELECT * FROM Gameweeks WHERE SeasonId = @SeasonId";
            return (await _dbConnection.QueryAsync<Gameweek>(selectQuery, new { SeasonId = seasonId })).ToList();
        }

        public async Task UpdateAsync(Gameweek gameweek)
        {
            const string updateQuery = "UPDATE Gameweeks " +
                                       "SET GameweekNumber = @GameweekNumber " +
                                       "WHERE GameweekId = @GameweekId";

            await _dbConnection.ExecuteAsync(updateQuery, new
            {
                GameweekId = gameweek.GameweekId,
                GameweekNumber = gameweek.GameweekNumber
            });
        }
    }
}
