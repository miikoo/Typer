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
    public class SeasonRepository : ISeasonRepository
    {
        private readonly TyperContext _context;

        public SeasonRepository(TyperContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Season season)
        {
            await _context.AddAsync(DbSeason.Create(season));
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid seasonId)
        {
            var season = await (from s in _context.Seasons where s.SeasonId == seasonId select s).FirstAsync();
            _context.Seasons.Remove(season);
            await _context.SaveChangesAsync();
        }

        public async Task<Season> GetAsync(Guid seasonId)
            => await (from s in _context.Seasons
                      where s.SeasonId == seasonId
                      select new Season(s.SeasonId, s.StartYear, s.EndYear)).FirstAsync();

        public async Task<List<Season>> GetAsync()
            => await (from s in _context.Seasons
                      select new Season(s.SeasonId, s.StartYear, s.EndYear)).ToListAsync();

        public async Task UpdateAsync(Season season)
        {
            var _season = await (from s in _context.Seasons where s.SeasonId == season.SeasonId select s).FirstAsync();
            _season.StartYear = season.StartYear;
            _season.EndYear = season.EndYear;
            await _context.SaveChangesAsync();
        }
    }
}
