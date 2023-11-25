using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Domain.Models
{
    public class Season
    {
        public Season(string seasonId, int startYear, int endYear)
        {
            SeasonId = seasonId;
            StartYear = startYear;
            EndYear = endYear;
        }

        public Season()
        {
            
        }

        public string SeasonId { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }

        public static Season Create(int startYear, int endYear)
            => new Season(Guid.NewGuid().ToString(), startYear, endYear);
    }
}
