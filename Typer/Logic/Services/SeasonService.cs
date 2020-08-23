using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Database;
using Typer.Database.Entities;
using Typer.Logic.DtoModels;

namespace Typer.Logic.Services
{
    public interface ISeasonService
    {
        Task CreateSeason(int startYear, int endYear);
        Task<List<SeasonDto>> GetSeasons();
        Task EditSeason(int startYear, int endYear, long seasonId);
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

        public async Task EditSeason(int startYear, int endYear, long seasonId)
        {
            var season = await _context.Seasons.FirstAsync(x => x.SeasonId == seasonId);
            season.StartYear = startYear;
            season.EndYear = endYear;
            await _context.SaveChangesAsync();
        }

        public async Task<List<SeasonDto>> GetSeasons()
            =>  await _context.Seasons.Select( x => new SeasonDto
            {
                EndYear = x.EndYear,
                StartYear = x.StartYear,
                SeasonId = x.SeasonId
            }).ToListAsync();
    }
}
