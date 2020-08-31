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
        Task<GameweekDto> CreateGameweek(long seasonId, int gameweekNumber);
        Task<List<GameweekDto>> GetGameweeksBySeasonId(long seasonId);
        Task<GameweekDto> EditGameweek(long gameweekId, int gameweekNumber);
        Task DeleteGameweek(long gameweekId);
    }

    public class GameweekService : IGameweekService
    {
        private readonly TyperContext _context;

        public GameweekService(TyperContext context)
        {
            _context = context;
        }

        public async Task<GameweekDto> CreateGameweek(long seasonId, int gameweekNumber)
        {
            var gameweek = new Gameweek
            {
                GameweekNumber = gameweekNumber,
                SeasonId = seasonId
            };
            await _context.Gameweeks.AddAsync(gameweek);
            await _context.SaveChangesAsync();
            return new GameweekDto
            {
                GameweekId = gameweek.GameweekId,
                GameweekNumber = gameweek.GameweekNumber
            };
        }

        public async Task DeleteGameweek(long gameweekId)
        {
            var gameweek = await _context.Gameweeks.FirstAsync(x => x.GameweekId == gameweekId);
            _context.Remove(gameweek);
            await _context.SaveChangesAsync();
        }

        public async Task<GameweekDto> EditGameweek(long gameweekId, int gameweekNumber)
        {
            var gameweek = await _context.Gameweeks.FirstAsync(x => x.GameweekId == gameweekId);
            gameweek.GameweekNumber = gameweekNumber;
            await _context.SaveChangesAsync();
            return new GameweekDto
            {
                GameweekId = gameweek.GameweekId,
                GameweekNumber = gameweek.GameweekNumber
            };
        }

        public async Task<List<GameweekDto>> GetGameweeksBySeasonId(long seasonId)
            => await _context.Gameweeks.Where(x => x.SeasonId == seasonId).Select(y => new GameweekDto
            {
                GameweekId = y.GameweekId,
                GameweekNumber = y.GameweekNumber
            }).ToListAsync();
    }
}
