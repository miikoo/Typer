using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Match.CreateMatch
{
    public class MatchDto
    {
        public MatchDto(long matchId)
        {
            MatchId = matchId;
        }

        public long MatchId { get; set; }
    }
}
