using System.Collections.Generic;

namespace Typer.Database.Entities
{
    public class Season
    {
        public Season()
        {
            Gameweeks = new HashSet<Gameweek>();
        }

        public long SeasonId { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }

        public ICollection<Gameweek> Gameweeks { get; set; }
    }
}
