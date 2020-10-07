using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Typer.Domain.Models;

namespace Typer.Domain.Interfaces
{
    public interface IMatchPredictionRepository
    {
        Task<long> CreateAsync(int? homeTeamGoalPrediction, int? awayTeamGoalPrediction, Guid userId, long matchId);
        Task<List<MatchPrediction>> GetAsync(Guid userId);
        Task<MatchPrediction> GetAsync(long matchPredictionId);
        Task UpdateAsync(int? homeTeamGoalPrediction, int? awayTeamGoalPrediction, long matchPredictionId);
        Task DeleteAsync(long matchPredictionId);
    }
}
