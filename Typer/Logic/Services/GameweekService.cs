using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Database;
using Typer.Database.Entities;

namespace Typer.Logic.Services
{
    public interface IGameweekService
    {
        Task CreateGameweek(long seasonId);
    }

    public class GameweekService : IGameweekService
    {
        private readonly TyperContext _context;

        public GameweekService(TyperContext context)
        {
            _context = context;
        }

        public async Task CreateGameweek(long seasonId)
        {
            var gameweek = await _context.Gameweeks.Where(x => x.SeasonId == seasonId).OrderByDescending(x => x.GameweekNumber)
                .FirstAsync();

            await _context.Gameweeks.AddAsync(new Gameweek
            {
                GameweekNumber = gameweek.GameweekNumber+1,
                SeasonId = seasonId
            });
            await _context.SaveChangesAsync();
        }
    }
}
