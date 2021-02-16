using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Typer.Domain.Models;

namespace Typer.Domain.Interfaces.Repositories
{
    public interface IMatchPredictionRepository
    {
        Task CreateAsync(params MatchPrediction[] matchPredictions);
        Task<List<MatchPrediction>> GetByUserIdAsync(Guid userId);
        Task<MatchPrediction> GetAsync(Guid matchPredictionId);
        Task UpdateAsync(MatchPrediction matchPrediction);
        Task UpdateManyAsync(params Tuple<Guid, int?, int?>[] matchPredictions);
        Task DeleteAsync(Guid matchPredictionId);
    }
}
