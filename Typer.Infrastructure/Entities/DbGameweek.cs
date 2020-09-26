using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Infrastructure.Entities
{
    public class DbGameweek
    {
        public DbGameweek()
        {
            Matches = new HashSet<DbMatch>();
        }

        public long GameweekId { get; set; }
        public int GameweekNumber { get; set; }

        public long SeasonId { get; set; }
        public virtual DbSeason Season { get; set; }
        public virtual ICollection<DbMatch> Matches { get; set; }
    }
}
