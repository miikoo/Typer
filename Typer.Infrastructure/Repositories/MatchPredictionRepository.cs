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
    public class MatchPredictionRepository : IMatchPredictionRepository
    {
        private readonly IDbConnection _dbConnection;

        public MatchPredictionRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task CreateAsync(params MatchPrediction[] matchPredictions)
        {
            const string insertQuery = "INSERT INTO MatchPredictions (MatchPredictionId, HomeTeamGoalPrediction, AwayTeamGoalPrediction, MatchId, UserId) " +
                                      "VALUES (@MatchPredictionId, @HomeTeamGoalPrediction, @AwayTeamGoalPrediction, @MatchId, @UserId)";

            await _dbConnection.ExecuteAsync(insertQuery, matchPredictions);
        }

        public async Task DeleteAsync(string matchPredictionId)
        {
            const string deleteQuery = "DELETE FROM MatchPredictions WHERE MatchPredictionId = @MatchPredictionId";
            await _dbConnection.ExecuteAsync(deleteQuery, new { MatchPredictionId = matchPredictionId });
        }

        public async Task<MatchPrediction> GetAsync(string matchPredictionId)
        {
            const string selectQuery = "SELECT * FROM MatchPredictions WHERE MatchPredictionId = @MatchPredictionId";
            return await _dbConnection.QueryFirstOrDefaultAsync<MatchPrediction>(selectQuery, new { MatchPredictionId = matchPredictionId });
        }

        public async Task<List<MatchPrediction>> GetByUserIdAsync(string userId)
        {
            const string selectQuery = "SELECT * FROM MatchPredictions WHERE UserId = @UserId";
            return (await _dbConnection.QueryAsync<MatchPrediction>(selectQuery, new { UserId = userId })).ToList();
        }

        public async Task UpdateAsync(MatchPrediction matchPrediction)
        {
            const string updateQuery = "UPDATE MatchPredictions " +
                                       "SET HomeTeamGoalPrediction = @HomeTeamGoalPrediction, " +
                                       "AwayTeamGoalPrediction = @AwayTeamGoalPrediction " +
                                       "WHERE MatchPredictionId = @MatchPredictionId";

            await _dbConnection.ExecuteAsync(updateQuery, new
            {
                HomeTeamGoalPrediction = matchPrediction.HomeTeamGoalPrediction,
                AwayTeamGoalPrediction = matchPrediction.AwayTeamGoalPrediction,
                MatchPredictionId = matchPrediction.MatchPredictionId
            });
        }

        public async Task UpdateManyAsync(params Tuple<string, int?, int?>[] matchPredictions)
        {
            const string updateQuery = "UPDATE MatchPredictions " +
                                       "SET HomeTeamGoalPrediction = @HomeTeamGoalPrediction, " +
                                       "AwayTeamGoalPrediction = @AwayTeamGoalPrediction " +
                                       "WHERE MatchPredictionId = @MatchPredictionId";

            foreach (var prediction in matchPredictions)
            {
                await _dbConnection.ExecuteAsync(updateQuery, new
                {
                    HomeTeamGoalPrediction = prediction.Item2,
                    AwayTeamGoalPrediction = prediction.Item3,
                    MatchPredictionId = prediction.Item1
                });
            }
        }
    }
}