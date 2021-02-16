using System;
using System.Collections.Generic;
using System.Text;
using Typer.Domain.Models;

namespace Typer.Infrastructure.Entities
{
    public class DbGameweek
    {
        public DbGameweek()
        {
            Matches = new HashSet<DbMatch>();
        }

        public Guid GameweekId { get; set; }
        public int GameweekNumber { get; set; }

        public long ExternalId { get; set; }
        public Guid SeasonId { get; set; }
        public virtual DbSeason Season { get; set; }
        public virtual ICollection<DbMatch> Matches { get; set; }

        public static DbGameweek Create(Gameweek gameweek)
            => new DbGameweek
            {
                SeasonId = gameweek.SeasonId,
                GameweekNumber = gameweek.GameweekNumber,
                GameweekId = gameweek.GameweekId
            };
    }
}
