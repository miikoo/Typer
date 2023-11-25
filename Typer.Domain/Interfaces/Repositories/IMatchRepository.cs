using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Typer.Domain.Models;

namespace Typer.Domain.Interfaces.Repositories
{
    public interface IMatchRepository
    {
        Task CreateAsync(params Match[] matches);
        Task<List<Match>> GetAsync(string gameweekId);
        Task<Match> GetByIdAsync(string matchId);
        Task UpdateAsync(params Match[] matches);
        Task DeleteAsync(string matchId);
    }
}
