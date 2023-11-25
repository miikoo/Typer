using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Typer.Domain.Models;

namespace Typer.Domain.Interfaces.Repositories
{
    public interface ISeasonRepository
    {
        Task<List<Season>> GetAsync();
        Task<Season> GetAsync(string seasonId);
        Task UpdateAsync(Season season);
        Task CreateAsync(Season season);
        Task DeleteAsync(string seasonId);
    }
}
