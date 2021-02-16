using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Domain.Interfaces.Repositories;
using Typer.Domain.Models;
using Typer.Infrastructure.Entities;

namespace Typer.Infrastructure.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        private readonly TyperContext _context;

        public MatchRepository(TyperContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(params Match[] matches)
        {
            await _context.AddRangeAsync(matches.Select(x => DbMatch.Create(x)));
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid matchId)
        {
            var match = await (from m in _context.Matches where m.MatchId == matchId select m).FirstAsync();
            _context.Matches.Remove(match);
            await _context.SaveChangesAsync();
        }

        public async Task<Match> GetByIdAsync(Guid matchId)
            => await (from m in _context.Matches
                      where m.MatchId == matchId
                      select new Match(m.MatchId, m.HomeTeamGoals, m.AwayTeamGoals, m.MatchDate, m.AwayTeamId,
                          m.HomeTeamId, m.GameweekId)).FirstAsync();

        public async Task<List<Match>> GetAsync(Guid gameweekId)
            => await (from m in _context.Matches
                      where m.GameweekId == gameweekId
                      select new Match(m.MatchId, m.HomeTeamGoals, m.AwayTeamGoals, m.MatchDate, m.AwayTeamId,
                          m.HomeTeamId, m.GameweekId)).ToListAsync();

        public async Task UpdateAsync(params Match[] matches)
        {
            foreach(var match in matches)
            {
                var _match = await (from m in _context.Matches where m.MatchId == match.MatchId select m).FirstAsync();
                _match.HomeTeamGoals = match.HomeTeamGoals;
                _match.AwayTeamGoals = match.AwayTeamGoals;
                _match.MatchDate = match.MatchDate;
            }
            await _context.SaveChangesAsync();
        }
    }
}
