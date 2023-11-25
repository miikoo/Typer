using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Typer.Domain.Interfaces.Repositories;
using Typer.Domain.Models;
using Typer.Infrastructure.Entities;

namespace Typer.Infrastructure.Repositories
{
    public class SeasonRepository : ISeasonRepository
    {
        private readonly IDbConnection _dbConnection;

        public SeasonRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task CreateAsync(Season season)
        {
            const string insertQuery = "INSERT INTO Seasons (SeasonId, StartYear, EndYear) VALUES (@SeasonId, @StartYear, @EndYear)";
            await _dbConnection.ExecuteAsync(insertQuery, DbSeason.Create(season));
        }

        public async Task DeleteAsync(string seasonId)
        {
            const string deleteQuery = "DELETE FROM Seasons WHERE SeasonId = @SeasonId";
            await _dbConnection.ExecuteAsync(deleteQuery, new { SeasonId = seasonId });
        }

        public async Task<Season> GetAsync(string seasonId)
        {
            const string selectQuery = "SELECT * FROM Seasons WHERE SeasonId = @SeasonId";
            return await _dbConnection.QueryFirstOrDefaultAsync<Season>(selectQuery, new { SeasonId = seasonId });
        }

        public async Task<List<Season>> GetAsync()
        {
            const string selectQuery = "SELECT * FROM Seasons";
            return (await _dbConnection.QueryAsync<Season>(selectQuery)).AsList();
        }

        public async Task UpdateAsync(Season season)
        {
            const string updateQuery = "UPDATE Seasons SET StartYear = @StartYear, EndYear = @EndYear WHERE SeasonId = @SeasonId";
            await _dbConnection.ExecuteAsync(updateQuery, DbSeason.Create(season));
        }
    }
}