using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Seasons.CreateSeason
{
    public class SeasonDto
    {
        public SeasonDto(Guid seasonId)
        {
            SeasonId = seasonId;
        }

        public Guid SeasonId { get; set; }
    }
}
