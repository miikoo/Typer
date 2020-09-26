using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.API.Commands.Match.UpdateMatchDetails
{
    public class UpdateMatchDetailsCommand : IRequest<Unit>
    {
        public long HomeTeamId { get; set; }
        public long AwayTeamId { get; set; }
        public DateTime MatchDate { get; set; }
        public long MatchId { get; set; }
    }
}
