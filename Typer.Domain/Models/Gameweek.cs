using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Domain.Models
{
    public class Gameweek
    {
        public Gameweek(string gameweekId, int gameweekNumber, string seasonId)
        {
            GameweekId = gameweekId;
            GameweekNumber = gameweekNumber;
            SeasonId = seasonId;
        }

        public Gameweek()
        {
            
        }

        public string GameweekId { get; set; }
        public int GameweekNumber { get; set; }
        public string SeasonId { get; set; }

        public static Gameweek Create(int gameweekNumber, string seasonId)
            => new Gameweek(Guid.NewGuid().ToString(), gameweekNumber, seasonId);
    }
}
