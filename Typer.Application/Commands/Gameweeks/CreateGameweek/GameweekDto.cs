using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Gameweeks.CreateGameweek
{
    public class GameweekDto
    {
        public GameweekDto(Guid id)
        {
            GameweekId = id;
        }

        public Guid GameweekId { get; set; }
    }
}
