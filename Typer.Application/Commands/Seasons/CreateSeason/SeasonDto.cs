using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Seasons.CreateSeason
{
    public class SeasonDto
    {
        public SeasonDto()
        {
            
        }
        public SeasonDto(string seasonId)
        {
            SeasonId = seasonId;
        }

        public string SeasonId { get; set; }
    }
}
