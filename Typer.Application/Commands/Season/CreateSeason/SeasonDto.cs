using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Season.CreateSeason
{
    public class SeasonDto
    {
        public SeasonDto(long seasonId)
        {
            SeasonId = seasonId;
        }

        public long SeasonId { get; set; }
    }
}
