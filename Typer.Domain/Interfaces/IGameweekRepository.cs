using System.Collections.Generic;
using System.Threading.Tasks;
using Typer.Domain.Models;

namespace Typer.Domain.Interfaces
{
    public interface IGameweekRepository
    {
        Task<long> CreateAsync(long seasonId, int gameweekNumber);
        Task<List<Gameweek>> GetAsync(long seasonId);
        Task<Gameweek> GetByIdAsync(long gameweekId);
        Task UpdateAsync(long gameweekId, int gameweekNumber);
        Task DeleteAsync(long gameweekId);
    }
}