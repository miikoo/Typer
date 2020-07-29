using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Database;
using Typer.Database.Entities;

namespace Typer.Logic.Services
{
    public interface ISeasonService
    {
        Task CreateSeason(int startYear, int endYear);
    }

    public class SeasonService : ISeasonService
    {
        private readonly TyperContext _context;

        public SeasonService(TyperContext context)
        {
            _context = context;
        }

        public async Task CreateSeason(int startYear, int endYear)
        {
            await _context.Seasons.AddAsync(new Season
            {
                StartYear = startYear,
                EndYear = endYear
            });
            await _context.SaveChangesAsync();
        }
    }
}
