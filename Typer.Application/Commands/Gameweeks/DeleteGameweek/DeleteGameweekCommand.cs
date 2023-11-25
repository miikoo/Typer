using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Gameweeks.DeleteGameweek
{
    public class DeleteGameweekCommand : IRequest<Unit>
    {
        public string GameweekId { get; set; }
    }
}
