using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Typer.Database;
using Typer.Database.Entities;

namespace Typer.Logic.Services
{
    public interface IMatchService
    {
        Task CreateMatch(long homeTeamId, long awayTeamId, long gameweekId);
        Task UpdateMatchResult(long matchId, int homeTeamGoals, int awayTeamGoals);
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
    }
}
