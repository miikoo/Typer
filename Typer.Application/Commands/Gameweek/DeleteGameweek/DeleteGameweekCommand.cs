using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Gameweek.DeleteGameweek
{
    public class DeleteGameweekCommand : IRequest<Unit>
    {
        public long GameweekId { get; set; }
    }
}
