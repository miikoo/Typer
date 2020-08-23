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
    public interface IGameweekService
    {
        Task CreateGameweek(long seasonId, int gameweekNumber);
        Task<List<GameweekDto>> GetGameweeksBySeasonId(long seasonId);
    }

    public class GameweekService : IGameweekService
    {
        private readonly TyperContext _context;

        public GameweekService(TyperContext context)
        {
            _context = context;
        }

        public async Task CreateGameweek(long seasonId, int gameweekNumber)
        {

            await _context.Gameweeks.AddAsync(new Gameweek
            {
                GameweekNumber = gameweekNumber,
                SeasonId = seasonId
            });
            await _context.SaveChangesAsync();
        }

        public async Task<List<GameweekDto>> GetGameweeksBySeasonId(long seasonId)
            => await _context.Gameweeks.Where(x => x.SeasonId == seasonId).Select(y => new GameweekDto
            {
                GameweekId = y.GameweekId,
                GameweekNumber = y.GameweekNumber
            }).ToListAsync();
    }
}
