using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Infrastructure.Entities
{
    public class DbSeason
    {
        public DbSeason()
        {
            Gameweeks = new HashSet<DbGameweek>();
        }

        public long SeasonId { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }

        public virtual ICollection<DbGameweek> Gameweeks { get; set; }
    }
}
