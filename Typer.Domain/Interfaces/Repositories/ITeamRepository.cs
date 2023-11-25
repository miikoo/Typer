using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Typer.Domain.Models;

namespace Typer.Domain.Interfaces.Repositories
{
    public interface ITeamRepository
    {
        Task CreateAsync(params Team[] teams);
        Task<List<Team>> GetAsync();
        Task<Team> GetAsync(string teamId);
        Task UpdateAsync(Team team);
        Task DeleteAsync(string teamId);
        Task<Team> GetByName(string name);
    }
}
