using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Gameweek.CreateGameweek
{
    public class GameweekDto
    {
        public GameweekDto(long id)
        {
            GameweekId = id;
        }

        public long GameweekId { get; set; }
    }
}
