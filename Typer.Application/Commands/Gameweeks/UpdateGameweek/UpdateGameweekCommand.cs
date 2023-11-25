using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Gameweeks.UpdateGameweek
{
    public class UpdateGameweekCommand : IRequest<Unit>
    {
        public string GameweekId { get; set; }
        public int GameweekNumber { get; set; }
    }
}
