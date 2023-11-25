using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Typer.Domain.Models;

namespace Typer.Domain.Interfaces.Repositories
{
    public interface IGameweekRepository
    {
        Task CreateAsync(params Gameweek[] gameweeks);
        Task<List<Gameweek>> GetAsync(string seasonId);
        Task<Gameweek> GetByIdAsync(string gameweekId);
        Task UpdateAsync(Gameweek gameweek);
        Task DeleteAsync(string gameweekId);
    }
}