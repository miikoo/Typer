using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Typer.Domain.Models;

namespace Typer.Domain.Interfaces.Repositories
{
    public interface IMatchPredictionRepository
    {
        Task CreateAsync(params MatchPrediction[] matchPredictions);
        Task<List<MatchPrediction>> GetByUserIdAsync(string userId);
        Task<MatchPrediction> GetAsync(string matchPredictionId);
        Task UpdateAsync(MatchPrediction matchPrediction);
        Task UpdateManyAsync(params Tuple<string, int?, int?>[] matchPredictions);
        Task DeleteAsync(string matchPredictionId);
    }
}
