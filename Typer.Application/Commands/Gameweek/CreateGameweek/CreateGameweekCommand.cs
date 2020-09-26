using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Gameweek.CreateGameweek
{
    public class CreateGameweekCommand : IRequest<long>
    {
        public int GameweekNumber { get; set; }
        public long SeasonId { get; set; }
    }
}
