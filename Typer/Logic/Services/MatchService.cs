using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Database;
using Typer.Database.Entities;

namespace Typer.Logic.Services
{
    public interface IMatchService
    {
        Task CreateMatch(long homeTeamId, long awayTeamId, long gameweekId);
        Task UpdateMatchResult(long matchId, int homeTeamGoals, int awayTeamGoals);
        Task<List<Match>> GetMatchesByGameweekId(long gameweekId);
    }

    public class MatchService : IMatchService
    {
        private readonly TyperContext _context;

        public MatchService(TyperContext context)
        {
            _context = context;
        }

        public async Task CreateMatch(long homeTeamId, long awayTeamId, long gameweekId)
        {
            await _context.AddAsync(new Match
            {
                AwayTeamId = awayTeamId,
                HomeTeamId = homeTeamId,
                GameweekId = gameweekId
            });
            await _context.SaveChangesAsync();
        }


        public async Task UpdateMatchResult(long matchId, int homeTeamGoals, int awayTeamGoals)
        {
            var match = await _context.Matches.FirstAsync(x => x.MatchId == matchId);
            match.HomeTeamGoals = homeTeamGoals;
            match.AwayTeamGoals = awayTeamGoals;
            await _context.SaveChangesAsync();
        }

        public async Task<List<Match>> GetMatchesByGameweekId(long gameweekId)
            => await _context.Matches.Where(x => x.GameweekId == gameweekId).ToListAsync();
    }
}
