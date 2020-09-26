using System.Collections.Generic;
using System.Threading.Tasks;
using Typer.Domain.Models;

namespace Typer.Domain.Interfaces
{
    public interface ISeasonRepository
    {
        Task<List<Season>> GetAsync();
        Task<Season> GetAsync(long seasonId);
        Task UpdateAsync(long seasonId, int startYear, int endYear);
        Task<long> CreateAsync(int startYear, int endYear);
        Task DeleteAsync(long seasonId);
    }
}
