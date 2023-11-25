using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Matches.CreateMatch
{
    public class MatchDto
    {
        public MatchDto()
        {
            
        }
        public MatchDto(string matchId)
        {
            MatchId = matchId;
        }

        public string MatchId { get; set; }
    }
}
