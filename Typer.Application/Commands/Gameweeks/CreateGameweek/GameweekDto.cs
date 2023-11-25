using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Gameweeks.CreateGameweek
{
    public class GameweekDto
    {
        public GameweekDto()
        {
            
        }
        public GameweekDto(string id)
        {
            GameweekId = id;
        }

        public string GameweekId { get; set; }
    }
}
