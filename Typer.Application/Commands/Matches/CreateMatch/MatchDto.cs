using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Matches.CreateMatch
{
    public class MatchDto
    {
        public MatchDto(Guid matchId)
        {
            MatchId = matchId;
        }

        public Guid MatchId { get; set; }
    }
}
