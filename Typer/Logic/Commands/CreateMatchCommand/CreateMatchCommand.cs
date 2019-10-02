using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Typer.Logic.Commands.CreateMatchCommand
{
    public class CreateMatchCommand : IRequest<Unit>
    {
        public long HomeTeamId { get; set; }
        public long AwayTeamId { get; set; }
        public long GameweekId { get; set; }
    }
}
