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
    public class GameweekRepository : IGameweekRepository
    {
        private readonly TyperContext _context;

        public GameweekRepository(TyperContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(params Gameweek[] gameweeks)
        {
            await _context.AddRangeAsync(gameweeks.Select(x => DbGameweek.Create(x)));
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid gameweekId)
        {
            var gameweek = await (from g in _context.Gameweeks where g.GameweekId == gameweekId select g).FirstAsync();
            _context.Gameweeks.Remove(gameweek);
            await _context.SaveChangesAsync();
        }

        public async Task<Gameweek> GetByIdAsync(Guid gameweekId)
            => await (from g in _context.Gameweeks
                      where g.GameweekId == gameweekId
                      select new Gameweek(g.GameweekId, g.GameweekNumber, g.SeasonId)).FirstAsync();

        public async Task<List<Gameweek>> GetAsync(Guid seasonId)
            => await (from g in _context.Gameweeks
                      where g.SeasonId == seasonId
                      select new Gameweek(g.GameweekId, g.GameweekNumber, g.SeasonId)).ToListAsync();

        public async Task UpdateAsync(Gameweek gameweek)
        {
            var _gameweek = await (from g in _context.Gameweeks where g.GameweekId == gameweek.GameweekId select g).FirstAsync();
            _gameweek.GameweekNumber = gameweek.GameweekNumber;
            await _context.SaveChangesAsync();
        }
    }
}
