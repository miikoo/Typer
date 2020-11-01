using System.Collections.Generic;
using System.Threading.Tasks;
using Typer.Domain.Models;

namespace Typer.Domain.Interfaces
{
    public interface ITeamRepository
    {
        Task<long> CreateAsync(string TeamName);
        Task<List<Team>> GetAsync();
        Task<Team> GetAsync(long teamId);
        Task UpdateAsync(long teamId, string teamName);
        Task DeleteAsync(long teamId);
        Task<Team> GetByName(string name);
    }
}
