using System.Collections.Generic;

namespace Typer.Database.Entities
{
    public class Match
    {
        public Match()
        {
            MatchPredictions = new HashSet<MatchPrediction>();
        }

        public long MatchId { get; set; }
        public int? HomeTeamGoals { get; set; }
        public int? AwayTeamGoals { get; set; }

        public long HomeTeamId { get; set; }
        public long AwayTeamId { get; set; }
        public long GameweekId { get; set; }

        public virtual ICollection<MatchPrediction> MatchPredictions { get; set; }
        public virtual Gameweek Gameweek { get; set; }
        public virtual Team HomeTeam { get; set; }
        public virtual Team AwayTeam { get; set; }
    }
}
