using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Typer.Domain.Models;

namespace Typer.Domain.Interfaces.Repositories
{
    public interface IMatchRepository
    {
        Task CreateAsync(params Match[] matches);
        Task<List<Match>> GetAsync(Guid gameweekId);
        Task<Match> GetByIdAsync(Guid matchId);
        Task UpdateAsync(params Match[] matches);
        Task DeleteAsync(Guid matchId);
    }
}
