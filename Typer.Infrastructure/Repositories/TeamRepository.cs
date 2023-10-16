using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Typer.Domain.Interfaces.Repositories;
using Typer.Domain.Models;
using Typer.Infrastructure.Entities;

namespace Typer.Infrastructure.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly IDbConnection _dbConnection;

        public TeamRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task CreateAsync(params Team[] teams)
        {
            const string insertQuery = "INSERT INTO Teams (TeamId, TeamName) VALUES (@TeamId, @TeamName)";
            await _dbConnection.ExecuteAsync(insertQuery, teams.Select(DbTeam.Create));
        }

        public async Task DeleteAsync(Guid teamId)
        {
            const string deleteQuery = "DELETE FROM Teams WHERE TeamId = @TeamId";
            await _dbConnection.ExecuteAsync(deleteQuery, new { TeamId = teamId });
        }

        public async Task<List<Team>> GetAsync()
        {
            const string selectQuery = "SELECT TeamId, TeamName FROM Teams";
            return (await _dbConnection.QueryAsync<Team>(selectQuery)).AsList();
        }

        public async Task<Team> GetAsync(Guid teamId)
        {
            const string selectQuery = "SELECT TeamId, TeamName FROM Teams WHERE TeamId = @TeamId";
            return await _dbConnection.QueryFirstOrDefaultAsync<Team>(selectQuery, new { TeamId = teamId });
        }

        public async Task<Team> GetByName(string name)
        {
            const string selectQuery = "SELECT TeamId, TeamName FROM Teams WHERE TeamName = @TeamName";
            return await _dbConnection.QueryFirstOrDefaultAsync<Team>(selectQuery, new { TeamName = name });
        }

        public async Task UpdateAsync(Team team)
        {
            const string updateQuery = "UPDATE Teams SET TeamName = @TeamName WHERE TeamId = @TeamId";
            await _dbConnection.ExecuteAsync(updateQuery, new { TeamName = team.TeamName, TeamId = team.TeamId });
        }
    }
}
