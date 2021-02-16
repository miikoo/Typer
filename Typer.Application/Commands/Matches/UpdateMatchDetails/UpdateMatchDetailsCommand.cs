using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Matches.UpdateMatchDetails
{
    public class UpdateMatchDetailsCommand : IRequest<Unit>
    {
        public Guid HomeTeamId { get; set; }
        public Guid AwayTeamId { get; set; }
        public DateTime MatchDate { get; set; }
        public Guid MatchId { get; set; }
    }
}
