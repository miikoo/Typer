using System;
using System.Collections.Generic;
using System.Text;
using Typer.Domain.Models;

namespace Typer.Infrastructure.Entities
{
    public class DbGameweek
    {
        public DbGameweek()
        {
        }

        public string GameweekId { get; set; }
        public int GameweekNumber { get; set; }
        
        public string SeasonId { get; set; }

        public static DbGameweek Create(Gameweek gameweek)
            => new()
            {
                SeasonId = gameweek.SeasonId,
                GameweekNumber = gameweek.GameweekNumber,
                GameweekId = gameweek.GameweekId
            };
    }
}
