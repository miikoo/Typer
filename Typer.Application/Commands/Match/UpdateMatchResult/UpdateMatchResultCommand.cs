using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.API.Commands.Match.UpdateMatchResult
{
    public class UpdateMatchResultCommand : IRequest<Unit>
    {
        public long MatchId { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
    }
}
