using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Season.BuildSeason
{
    public class BuildSeasonCommand : IRequest<Unit>
    {
        public int GameweekAmount { get; set; }
        public List<string> TeamNames { get; set; }
        public List<MatchDto> Matches { get; set; }
        public long SeasonId { get; set; }
    }
}
