using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;
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

        public async Task<long> CreateAsync(long homeTeamId, long awayTeamId, long gameweekId, DateTime matchDate)
        {
            var match = new DbMatch
            {
                AwayTeamId = awayTeamId,
                HomeTeamId = homeTeamId,
                GameweekId = gameweekId,
                MatchDate = matchDate
            };
            await _context.AddAsync(match);
            await _context.SaveChangesAsync();
            return match.MatchId;
        }

        public async Task DeleteAsync(long matchId)
        {
            var match = await (from m in _context.Matches where m.MatchId == matchId select m).FirstAsync();
            _context.Matches.Remove(match);
            await _context.SaveChangesAsync();
        }

        public async Task<Match> GetByIdAsync(long matchId)
            => await (from m in _context.Matches
                      where m.MatchId == matchId
                      select new Match
                      {
                          AwayTeamGoals = m.AwayTeamGoals,
                          HomeTeamGoals = m.HomeTeamGoals,
                          MatchDate = m.MatchDate,
                          MatchId = m.MatchId,
                          AwayTeamId = m.AwayTeamId,
                          HomeTeamId = m.HomeTeamId
                      }).FirstAsync();

        public async Task<List<Match>> GetAsync(long gameweekId)
            => await (from m in _context.Matches
                      where m.GameweekId == gameweekId
                      select new Match
                      {
                          AwayTeamGoals = m.AwayTeamGoals,
                          HomeTeamGoals = m.HomeTeamGoals,
                          MatchDate = m.MatchDate,
                          MatchId = m.MatchId,
                          AwayTeamId = m.AwayTeamId,
                          HomeTeamId = m.HomeTeamId
                      }).ToListAsync();

        public async Task UpdateAsync(long matchId, int? homeTeamGoals, int? awayTeamGoals,
            DateTime matchDate, long homeTeamId, long awayTeamId)
        {
            var match = await (from m in _context.Matches where m.MatchId == matchId select m).FirstAsync();
            match.HomeTeamGoals = homeTeamGoals;
            match.AwayTeamGoals = awayTeamGoals;
            match.MatchDate = matchDate;
            match.AwayTeamId = awayTeamId;
            match.HomeTeamId = homeTeamId;
            await _context.SaveChangesAsync();
        }
    }
}
