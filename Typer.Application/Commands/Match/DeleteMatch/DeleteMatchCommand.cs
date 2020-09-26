using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Match.DeleteMatch
{
    public class DeleteMatchCommand : IRequest<Unit>
    {
        public long MatchId { get; set; }
    }
}
