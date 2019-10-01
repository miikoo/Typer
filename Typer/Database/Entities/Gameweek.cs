using System.Collections.Generic;

namespace Typer.Database.Entities
{
    public class Gameweek
    {
        public Gameweek()
        {
            Matches = new HashSet<Match>();
        }

        public long GameweekId { get; set; }
        public int GameweekNumber { get; set; }

        public long SeasonId { get; set; }
        public virtual Season Season { get; set; }
        public virtual ICollection<Match> Matches { get; set; }
    }
}
