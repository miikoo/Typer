namespace Typer.Database.Entities
{
    public class MatchPrediction
    {
        public long MatchPredictionId { get; set; }
        public int HomeTeamGoalPrediction { get; set; }
        public int AwayTeamGoalPrediction { get; set; }

        public string UserId { get; set; }
        public long MatchId { get; set; }
        public virtual Match Match { get; set; }
        public virtual User User { get; set; }
    }
}
