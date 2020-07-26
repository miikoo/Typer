using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Logic.Commands.Gameweek.CreateGameweek
{
    public class CreateGameweekCommand : IRequest<Unit>
    {
        public long SeasonId { get; set; }
    }
}
