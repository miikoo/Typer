using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Gameweeks.GetGameweeksBySeasonId
{
    public class GameweekDto
    {
        public GameweekDto()
        {
            
        }
        public GameweekDto(string gameweekId, int gameweekNumber)
        {
            GameweekId = gameweekId;
            GameweekNumber = gameweekNumber;
        }

        public string GameweekId { get; set; }
        public int GameweekNumber { get; set; }
    }
}
