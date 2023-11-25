using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Matches.UpdateMatchDetails
{
    public class UpdateMatchDetailsCommand : IRequest<Unit>
    {
        public string HomeTeamId { get; set; }
        public string AwayTeamId { get; set; }
        public DateTime MatchDate { get; set; }
        public string MatchId { get; set; }
    }
}
