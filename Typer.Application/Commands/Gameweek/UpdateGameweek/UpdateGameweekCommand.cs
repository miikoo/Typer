using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.API.Commands.Gameweek.UpdateGameweek
{
    public class UpdateGameweekCommand : IRequest<Unit>
    {
        public long GameweekId { get; set; }
        public int GameweekNumber { get; set; }
    }
}
