using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Infrastructure.Entities
{
    public class DbMatchPrediction
    {
        public long MatchPredictionId { get; set; }
        public int HomeTeamGoalPrediction { get; set; }
        public int AwayTeamGoalPrediction { get; set; }

        public Guid UserId { get; set; }
        public long MatchId { get; set; }
        public virtual DbMatch Match { get; set; }
        public virtual DbUser User { get; set; }
    }
}
