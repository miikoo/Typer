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
    public class SeasonRepository : ISeasonRepository
    {
        private readonly TyperContext _context;

        public SeasonRepository(TyperContext context)
        {
            _context = context;
        }

        public async Task<long> CreateAsync(int startYear, int endYear)
        {
            var season = new DbSeason
            {
                EndYear = endYear,
                StartYear = startYear
            };
            await _context.AddAsync(season);
            await _context.SaveChangesAsync();
            return season.SeasonId;
        }

        public async Task DeleteAsync(long seasonId)
        {
            var season = await (from s in _context.Seasons where s.SeasonId == seasonId select s).FirstAsync();
            _context.Seasons.Remove(season);
            await _context.SaveChangesAsync();
        }

        public async Task<Season> GetAsync(long seasonId)
            => await (from s in _context.Seasons
                      where s.SeasonId == seasonId
                      select new Season
                      {
                          StartYear = s.StartYear,
                          SeasonId = s.SeasonId,
                          EndYear = s.EndYear
                      }).FirstAsync();

        public async Task<List<Season>> GetAsync()
            => await (from s in _context.Seasons
                      select new Season
                      {
                          SeasonId = s.SeasonId,
                          EndYear = s.EndYear,
                          StartYear = s.StartYear
                      }).ToListAsync();

        public async Task UpdateAsync(long seasonId, int startYear, int endYear)
        {
            var season = await (from s in _context.Seasons where s.SeasonId == seasonId select s).FirstAsync();
            season.StartYear = startYear;
            season.EndYear = endYear;
            await _context.SaveChangesAsync();
        }
    }
}
