using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.API.Commands.Gameweek.DeleteGameweek
{
    public class DeleteGameweekCommand : IRequest<Unit>
    {
        public long GameweekId { get; set; }
    }
}
