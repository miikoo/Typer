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
        Task<SeasonDto> CreateSeason(int startYear, int endYear);
        Task<List<SeasonDto>> GetSeasons();
        Task<SeasonDto> EditSeason(int startYear, int endYear, long seasonId);
        Task DeleteSeason(long seasonId);
    }

    public class SeasonService : ISeasonService
    {
        private readonly TyperContext _context;

        public SeasonService(TyperContext context)
        {
            _context = context;
        }

        public async Task<SeasonDto> CreateSeason(int startYear, int endYear)
        {
            var season = new Season
            {
                StartYear = startYear,
                EndYear = endYear
            };
            await _context.Seasons.AddAsync(season);
            await _context.SaveChangesAsync();
            return new SeasonDto
            {
                SeasonId = season.SeasonId,
                StartYear = season.StartYear,
                EndYear = season.EndYear
            };
        }

        public async Task DeleteSeason(long seasonId)
        {
            var season = await _context.Seasons.FirstAsync(x => x.SeasonId == seasonId);
            _context.Remove(season);
            await _context.SaveChangesAsync();
        }

        public async Task<SeasonDto> EditSeason(int startYear, int endYear, long seasonId)
        {
            var season = await _context.Seasons.FirstAsync(x => x.SeasonId == seasonId);
            season.StartYear = startYear;
            season.EndYear = endYear;
            await _context.SaveChangesAsync();
            return new SeasonDto
            {
                StartYear = season.StartYear,
                EndYear = season.EndYear,
                SeasonId = season.SeasonId
            };
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
