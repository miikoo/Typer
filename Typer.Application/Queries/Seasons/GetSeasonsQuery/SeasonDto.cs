using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.API.Queries.Seasons.GetSeasonQuery
{
    public class SeasonDto
    {
        public SeasonDto(Guid seasonId, int startYear, int endYear)
        {
            SeasonId = seasonId;
            StartYear = startYear;
            EndYear = endYear;
        }

        public Guid SeasonId { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
    }
}
