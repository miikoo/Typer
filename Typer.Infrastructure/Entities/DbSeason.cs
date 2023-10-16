using System;
using System.Collections.Generic;
using System.Text;
using Typer.Domain.Models;

namespace Typer.Infrastructure.Entities
{
    public class DbSeason
    {
        public DbSeason()
        {
        }

        public Guid SeasonId { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }

        public static DbSeason Create(Season season)
            => new()
            {
                EndYear = season.EndYear,
                StartYear = season.StartYear,
                SeasonId = season.SeasonId
            };
    }
}
