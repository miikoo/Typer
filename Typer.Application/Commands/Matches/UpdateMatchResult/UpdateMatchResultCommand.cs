using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Matches.UpdateMatchResult
{
    public class UpdateMatchResultCommand : IRequest<Unit>
    {
        public Guid MatchId { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
    }
}
