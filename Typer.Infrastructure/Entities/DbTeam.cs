using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Infrastructure.Entities
{
    public class DbTeam
    {
        public DbTeam()
        {
            MatchesAsHomeTeam = new HashSet<DbMatch>();
            MatchesAsAwayTeam = new HashSet<DbMatch>();
        }

        public long TeamId { get; set; }
        public string TeamName { get; set; }
        public virtual ICollection<DbMatch> MatchesAsHomeTeam { get; set; }
        public virtual ICollection<DbMatch> MatchesAsAwayTeam { get; set; }
    }
}