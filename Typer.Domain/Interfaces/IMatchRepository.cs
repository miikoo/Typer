using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Typer.Domain.Models;

namespace Typer.Domain.Interfaces
{
    public interface IMatchRepository
    {
        Task<long> CreateAsync(long homeTeamId, long awayTeamId, long gameweekId, DateTime matchDate, int? homeTeamGoals, int? awayTeamGoals);
        Task<List<Match>> GetAsync(long gameweekId);
        Task<Match> GetByIdAsync(long matchId);
        Task UpdateAsync(long matchId, int? homeTeamGoals, int? awayTeamGoals, DateTime matchDate,
            long homeTeamId, long awayTeamId);
        Task DeleteAsync(long matchId);
    }
}
