using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Infrastructure.Entities
{
    public class DbMatch
    {
        public DbMatch()
        {
            MatchPredictions = new HashSet<DbMatchPrediction>();
        }

        public long MatchId { get; set; }
        public int? HomeTeamGoals { get; set; }
        public int? AwayTeamGoals { get; set; }
        public DateTime MatchDate { get; set; }

        public long HomeTeamId { get; set; }
        public long AwayTeamId { get; set; }
        public long GameweekId { get; set; }

        public virtual ICollection<DbMatchPrediction> MatchPredictions { get; set; }
        public virtual DbGameweek Gameweek { get; set; }
        public virtual DbTeam HomeTeam { get; set; }
        public virtual DbTeam AwayTeam { get; set; }
    }
}
