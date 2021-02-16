using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Matches.DeleteMatch
{
    public class DeleteMatchCommand : IRequest<Unit>
    {
        public Guid MatchId { get; set; }
    }
}
