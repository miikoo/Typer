using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Domain.Models
{
    public class Gameweek
    {
        public Gameweek(Guid gameweekId, int gameweekNumber, Guid seasonId)
        {
            GameweekId = gameweekId;
            GameweekNumber = gameweekNumber;
            SeasonId = seasonId;
        }

        public Guid GameweekId { get; set; }
        public int GameweekNumber { get; set; }
        public Guid SeasonId { get; set; }

        public static Gameweek Create(int gameweekNumber, Guid seasonId)
            => new Gameweek(Guid.NewGuid(), gameweekNumber, seasonId);
    }
}
