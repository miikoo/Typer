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
    public class GameweekRepository : IGameweekRepository
    {
        private readonly TyperContext _context;

        public GameweekRepository(TyperContext context)
        {
            _context = context;
        }

        public async Task<long> CreateAsync(long seasonId, int gameweekNumber)
        {
            var gameweek = new DbGameweek
            {
                SeasonId = seasonId,
                GameweekNumber = gameweekNumber
            };
            await _context.AddAsync(gameweek);
            await _context.SaveChangesAsync();
            return gameweek.GameweekId;
        }

        public async Task DeleteAsync(long gameweekId)
        {
            var gameweek = await (from g in _context.Gameweeks where g.GameweekId == gameweekId select g).FirstAsync();
            _context.Gameweeks.Remove(gameweek);
            await _context.SaveChangesAsync();
        }

        public async Task<Gameweek> GetByIdAsync(long gameweekId)
            => await (from g in _context.Gameweeks where g.GameweekId == gameweekId select new Gameweek
            {
                GameweekId = g.GameweekId,
                GameweekNumber = g.GameweekNumber
            }).FirstAsync();

        public async Task<List<Gameweek>> GetAsync(long seasonId)
            => await (from g in _context.Gameweeks
                      where g.SeasonId == seasonId
                      select new Gameweek
                      {
                          GameweekId = g.GameweekId,
                          GameweekNumber = g.GameweekNumber
                      }).ToListAsync();

        public async Task UpdateAsync(long gameweekId, int gameweekNumber)
        {
            var gameweek = await (from g in _context.Gameweeks where g.GameweekId == gameweekId select g).FirstAsync();
            gameweek.GameweekNumber = gameweekNumber;
            await _context.SaveChangesAsync();
        }
    }
}
